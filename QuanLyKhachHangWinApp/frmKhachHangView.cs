using QuanLyKhachHangWinApp.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachHangWinApp
{
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        Modify modify = new Modify();

        private void LoadData()
        {
            try
            {
                dgvQLKH.DataSource = modify.getAllKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TimKiemKhachHang();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TimKiemKhachHang();
        }

        private void TimKiemKhachHang()
        {
            try
            {
                string loaiKhachHang = txtSearch.Text;
                KhachHang khachHang = new KhachHang();
                DataTable resultTable = khachHang.TimKiemKhachHangTheoLoai(loaiKhachHang);
                dgvQLKH.DataSource = resultTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddView_Click(object sender, EventArgs e)
        {
            frmAdd fm = new frmAdd();
            fm.ShowDialog();

            if (fm.DialogResult == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateView_Click(object sender, EventArgs e)
        {
            SuaKhachHang();
        }

        private void SuaKhachHang()
        {
            try
            {
                int customerId = (int)dgvQLKH.CurrentRow.Cells[0].Value;
                frmUpdate frmUpdate = new frmUpdate(customerId);
                frmUpdate.ShowDialog();

                if (frmUpdate.DialogResult == DialogResult.OK)
                {
                    LoadData();
                    MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaKhachHang();
        }

        private void XoaKhachHang()
        {
            try
            {
                int customerId = (int)dgvQLKH.CurrentRow.Cells[0].Value;
                string? tenKhachHang = dgvQLKH.CurrentRow.Cells[1].Value.ToString();

                DialogResult dr = MessageBox.Show($"Bạn muốn xóa khách hàng '{tenKhachHang}' này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    KhachHang khachHang = new KhachHang();
                    khachHang.XoaKhachHang(customerId);
                    LoadData();
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLKH.Rows[e.RowIndex];
                txtID.Text = row.Cells["MaKH"].Value.ToString();
                txtName.Text = row.Cells["TenKH"].Value.ToString();
                cboSex.Text = row.Cells["GioiTinh"].Value.ToString();
                txtPhone.Text = row.Cells["SDT"].Value.ToString();
                dtmDate.Text = row.Cells["NgaySinh"].Value.ToString();
                cboTypeCustomer.Text = row.Cells["LoaiKH"].Value.ToString();
            }
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}