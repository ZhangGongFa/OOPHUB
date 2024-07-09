using System;
using System.Windows.Forms;
using QuanLyKhachHangWinApp.Class;

namespace QuanLyKhachHangWinApp
{

    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void bntAdd(object sender, EventArgs e)
        {
            string errorMessage = ThemKhachHang(); // Gọi phương thức và nhận thông báo lỗi

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Phương thức ThemKhachHang được tối ưu và trả về thông báo lỗi
        private string ThemKhachHang()
        {
            try
            {
                // Khởi tạo đối tượng KhachHang và gán giá trị từ form
                KhachHang khachHang = new KhachHang
                {
                    MaKH = int.Parse(txtIDNew.Text),
                    TenKH = txtNameNew.Text,
                    GioiTinh = cboSexNew.SelectedItem.ToString(),
                    SDT = txtPhoneNew.Text,
                    NgaySinh = dtmDateAdd.Value,
                    LoaiKH = cboTypeCustomerNew.SelectedItem.ToString()
                };

                // Gọi phương thức ThemKhachHang từ lớp KhachHang
                khachHang.ThemKhachHang(khachHang, out string errorMessage);

                // Kiểm tra lỗi từ phương thức ThemKhachHang
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    return errorMessage;
                }

                return null; // Không có lỗi
            }
            catch (FormatException)
            {
                return "Lỗi định dạng dữ liệu. Vui lòng kiểm tra lại.";
            }
            catch (Exception ex)
            {
                return "Đã xảy ra lỗi: " + ex.Message;
            }
        }

        // Xóa các sự kiện không sử dụng 
        private void cboTypeCustomerNew_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void frmAdd_Load(object sender, EventArgs e) { }

        private void cboSexNew_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
