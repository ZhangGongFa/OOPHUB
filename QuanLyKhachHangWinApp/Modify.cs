using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachHangWinApp
{
    class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand cmd;
        public Modify()
        {
        }

        //Hàm getAllKhachHang để truy vấn và trả về tất cả thông tin về khách hàng từ cơ sở dữ liệu
        public DataTable getAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from KHACHHANG";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
