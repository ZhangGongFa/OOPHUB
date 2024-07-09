using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangWinApp.Class
{
    class KhachHang //tạo lớp khách hàng
    {
        private int _MaKH;
        private string _TenKH;
        private string _GioiTinh;
        private string _SDT;
        private DateTime _NgaySinh;
        private string _LoaiKH;

        public KhachHang()
        {
        }

        public KhachHang(int maKH, string tenKH, string gioiTinh, string sDT, DateTime ngaySinh, string loaiKH)
        {
            _MaKH = maKH;
            _TenKH = tenKH;
            _GioiTinh = gioiTinh;
            _SDT = sDT;
            _NgaySinh = ngaySinh;
            _LoaiKH = loaiKH;
        }

        public int MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string LoaiKH { get => _LoaiKH; set => _LoaiKH = value; }



        //Hàm ThemKhachHang
        public void ThemKhachHang(KhachHang khachHang, out string errorMessage)
        {
            errorMessage = ""; // Khởi tạo thông báo lỗi

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand("ThemKhachHang", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số
                cmd.Parameters.Add(new SqlParameter("@MaKH", khachHang.MaKH));
                cmd.Parameters.Add(new SqlParameter("@TenKH", khachHang.TenKH));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", khachHang.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", khachHang.SDT));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", khachHang.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@LoaiKH", khachHang.LoaiKH));

                // Thêm tham số đầu ra để nhận thông báo lỗi
                SqlParameter errorMessageParam = new SqlParameter("@ThongBaoLoi", SqlDbType.NVarChar, 100);
                errorMessageParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(errorMessageParam);

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();

                // Lấy thông báo lỗi từ tham số đầu ra
                errorMessage = Convert.ToString(cmd.Parameters["@ThongBaoLoi"].Value);
            }
        }

        //Hàm này lấy thông tin khách hàng dựa trên MaKH, mục đích viết hàm này lấy dữ liệu đã chọn show lên Form Update
        public KhachHang GetCustomerData(int CustomerId)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "select * from [KHACHHANG] where MaKH = " + CustomerId;
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand(query, sqlConnection); 
            SqlDataReader dr = cmd.ExecuteReader();
            
            KhachHang khachHang = new KhachHang();

            if (dr != null)
            {
                while (dr.Read())
                {
                    khachHang.MaKH = Convert.ToInt32(dr["MaKH"]);
                    khachHang.TenKH = dr["TenKH"].ToString();
                    khachHang.GioiTinh = dr["GioiTinh"].ToString().Trim(); //.Trim() loại bỏ cách trắng không cần thiết;
                    khachHang.SDT = dr["SDT"].ToString();
                    khachHang.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
                    khachHang.LoaiKH = dr["LoaiKH"].ToString().Trim(); //.Trim() loại bỏ cách trắng không cần thiết

                }
            }
            return khachHang;
        }

        //Hàm SuaThongTinKhachHang
        public void SuaThongTinKhachHang(KhachHang khachHang)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand("SuaThongTinKhachHang", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MaKH", khachHang.MaKH));
                cmd.Parameters.Add(new SqlParameter("@TenKH", khachHang.TenKH));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", khachHang.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", khachHang.SDT));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", khachHang.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@LoaiKH", khachHang.LoaiKH));
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

        }

        //Hàm XoaKhachHang
        public void XoaKhachHang (int maKH)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("XoaKhachHang", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKH", maKH));
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //Hàm TimKiemKhachHangTheoLoai
        public DataTable TimKiemKhachHangTheoLoai(string loaiKhachHang)
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand("TimKiemTheoLoaiKhachHang", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LoaiKhachHang", loaiKhachHang));
                sqlConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    resultTable.Load(reader);
                }
            }

            return resultTable;
        }

    }
}
