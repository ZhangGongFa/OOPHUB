using QuanLyKhachHangWinApp.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachHangWinApp
{
    public partial class frmUpdate : Form
    {
        private readonly int selectedCustomerId;

        public frmUpdate(int customerId)
        {
            InitializeComponent();
            selectedCustomerId = customerId;
            LoadCustomerData();
        }

        // Đổi tên phương thức cho rõ ràng hơn
        private void LoadCustomerData()
        {
            try
            {
                KhachHang khachHang = new KhachHang();
                // Sử dụng trực tiếp phương thức GetCustomerData để lấy dữ liệu
                khachHang = khachHang.GetCustomerData(selectedCustomerId);

                // Gán dữ liệu cho các điều khiển
                txtIDUpdate.Text = khachHang.MaKH.ToString();
                txtNameUpdate.Text = khachHang.TenKH;
                txtPhoneUpdate.Text = khachHang.SDT;
                dtmDateUpdate.Value = khachHang.NgaySinh;
                cboSexUpdate.SelectedItem = khachHang.GioiTinh;
                cboTypeCustomerUpdate.SelectedItem = khachHang.LoaiKH;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Lỗi khi tải dữ liệu khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Rút gọn logic xác nhận
            if (MessageBox.Show("Bạn có muốn sửa thông tin khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateCustomer();
                DialogResult = DialogResult.OK; // Đánh dấu form được đóng với kết quả "OK"
                Close();
            }
        }

        // Đổi tên phương thức cho rõ ràng hơn
        private void UpdateCustomer()
        {
            try
            {
                KhachHang khachHang = new KhachHang
                {
                    MaKH = int.Parse(txtIDUpdate.Text),
                    TenKH = txtNameUpdate.Text,
                    GioiTinh = cboSexUpdate.SelectedItem?.ToString(),
                    SDT = txtPhoneUpdate.Text,
                    NgaySinh = dtmDateUpdate.Value,
                    LoaiKH = cboTypeCustomerUpdate.SelectedItem?.ToString()
                };

                khachHang.SuaThongTinKhachHang(khachHang);

                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Loại bỏ các event handler không sử dụng
    }
}