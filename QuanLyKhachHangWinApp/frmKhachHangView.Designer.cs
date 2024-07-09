namespace QuanLyKhachHangWinApp
{
    partial class frmQLKhachHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            cboTypeCustomer = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            grpButton = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdateView = new System.Windows.Forms.Button();
            btnAddView = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            cboSex = new System.Windows.Forms.ComboBox();
            dtmDate = new System.Windows.Forms.DateTimePicker();
            dgvQLKH = new System.Windows.Forms.DataGridView();
            label9 = new System.Windows.Forms.Label();
            btnShowAll = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            grpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.MediumAquamarine;
            label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(40, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.MediumAquamarine;
            label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(36, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.MediumAquamarine;
            label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(40, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 17);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.MediumAquamarine;
            label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(477, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 17);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.MediumAquamarine;
            label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(477, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 17);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.MediumAquamarine;
            label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(477, 97);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(115, 17);
            label6.TabIndex = 5;
            label6.Text = "Loại khách hàng";
            // 
            // txtID
            // 
            txtID.BackColor = System.Drawing.SystemColors.Window;
            txtID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.Location = new System.Drawing.Point(166, 14);
            txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new System.Drawing.Size(193, 24);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.SystemColors.Window;
            txtName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(166, 56);
            txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(193, 24);
            txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = System.Drawing.SystemColors.Window;
            txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhone.Location = new System.Drawing.Point(627, 11);
            txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new System.Drawing.Size(193, 24);
            txtPhone.TabIndex = 4;
            // 
            // cboTypeCustomer
            // 
            cboTypeCustomer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTypeCustomer.FormattingEnabled = true;
            cboTypeCustomer.Items.AddRange(new object[] { "VIP", "Thường" });
            cboTypeCustomer.Location = new System.Drawing.Point(627, 97);
            cboTypeCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboTypeCustomer.Name = "cboTypeCustomer";
            cboTypeCustomer.Size = new System.Drawing.Size(193, 24);
            cboTypeCustomer.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.Honeydew;
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(863, 130);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(91, 36);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // grpButton
            // 
            grpButton.BackColor = System.Drawing.Color.Teal;
            grpButton.Controls.Add(btnDelete);
            grpButton.Controls.Add(btnUpdateView);
            grpButton.Controls.Add(btnAddView);
            grpButton.Location = new System.Drawing.Point(264, 370);
            grpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grpButton.Name = "grpButton";
            grpButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grpButton.Size = new System.Drawing.Size(494, 65);
            grpButton.TabIndex = 15;
            grpButton.TabStop = false;
            grpButton.UseWaitCursor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Honeydew;
            btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(195, 20);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(102, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.UseWaitCursor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateView
            // 
            btnUpdateView.BackColor = System.Drawing.Color.Honeydew;
            btnUpdateView.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdateView.Location = new System.Drawing.Point(363, 20);
            btnUpdateView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnUpdateView.Name = "btnUpdateView";
            btnUpdateView.Size = new System.Drawing.Size(102, 31);
            btnUpdateView.TabIndex = 1;
            btnUpdateView.Text = "Sửa";
            btnUpdateView.UseVisualStyleBackColor = false;
            btnUpdateView.UseWaitCursor = true;
            btnUpdateView.Click += btnUpdateView_Click;
            // 
            // btnAddView
            // 
            btnAddView.BackColor = System.Drawing.Color.Honeydew;
            btnAddView.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddView.Location = new System.Drawing.Point(18, 20);
            btnAddView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddView.Name = "btnAddView";
            btnAddView.Size = new System.Drawing.Size(102, 31);
            btnAddView.TabIndex = 0;
            btnAddView.Text = "Thêm";
            btnAddView.UseVisualStyleBackColor = false;
            btnAddView.UseWaitCursor = true;
            btnAddView.Click += btnAddView_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(363, 182);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(275, 25);
            label7.TabIndex = 16;
            label7.Text = "QUẢN LÝ KHÁCH HÀNG";
            label7.Click += label7_Click;
            // 
            // cboSex
            // 
            cboSex.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Nam ", "Nữ" });
            cboSex.Location = new System.Drawing.Point(166, 97);
            cboSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboSex.Name = "cboSex";
            cboSex.Size = new System.Drawing.Size(193, 24);
            cboSex.TabIndex = 3;
            // 
            // dtmDate
            // 
            dtmDate.CustomFormat = "yyyy-MM-dd";
            dtmDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtmDate.Location = new System.Drawing.Point(627, 58);
            dtmDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtmDate.Name = "dtmDate";
            dtmDate.Size = new System.Drawing.Size(193, 24);
            dtmDate.TabIndex = 5;
            // 
            // dgvQLKH
            // 
            dgvQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLKH.BackgroundColor = System.Drawing.Color.Teal;
            dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKH.Location = new System.Drawing.Point(67, 218);
            dgvQLKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvQLKH.Name = "dgvQLKH";
            dgvQLKH.RowHeadersWidth = 51;
            dgvQLKH.RowTemplate.Height = 29;
            dgvQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvQLKH.Size = new System.Drawing.Size(886, 141);
            dgvQLKH.TabIndex = 20;
            dgvQLKH.CellClick += dgvQLKH_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.MediumAquamarine;
            label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(10, 140);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(153, 17);
            label9.TabIndex = 22;
            label9.Text = "Nhập Loại khách hàng";
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = System.Drawing.Color.Honeydew;
            btnShowAll.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShowAll.Location = new System.Drawing.Point(67, 181);
            btnShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(168, 31);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Hiển thị tất cả";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(166, 138);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(654, 24);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmQLKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MediumAquamarine;
            ClientSize = new System.Drawing.Size(992, 430);
            Controls.Add(btnShowAll);
            Controls.Add(label9);
            Controls.Add(dgvQLKH);
            Controls.Add(dtmDate);
            Controls.Add(cboSex);
            Controls.Add(label7);
            Controls.Add(grpButton);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cboTypeCustomer);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmQLKhachHang";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản Lý Khách Hàng";
            Load += frmQLKhachHang_Load;
            grpButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboTypeCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnAddView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.DataGridView dgvQLKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearch;
    }
}