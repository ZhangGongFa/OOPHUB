namespace QuanLyKhachHangWinApp
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            txtIDNew = new System.Windows.Forms.TextBox();
            txtNameNew = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtPhoneNew = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cboTypeCustomerNew = new System.Windows.Forms.ComboBox();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            cboSexNew = new System.Windows.Forms.ComboBox();
            dtmDateAdd = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            label1.Click += label1_Click;
            // 
            // txtIDNew
            // 
            txtIDNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIDNew.Location = new System.Drawing.Point(140, 28);
            txtIDNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtIDNew.Name = "txtIDNew";
            txtIDNew.Size = new System.Drawing.Size(224, 24);
            txtIDNew.TabIndex = 1;
            txtIDNew.TextChanged += textBox1_TextChanged;
            // 
            // txtNameNew
            // 
            txtNameNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNameNew.Location = new System.Drawing.Point(140, 66);
            txtNameNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNameNew.Name = "txtNameNew";
            txtNameNew.Size = new System.Drawing.Size(224, 24);
            txtNameNew.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(30, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 17);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(30, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 17);
            label3.TabIndex = 4;
            label3.Text = "Giới tính";
            // 
            // txtPhoneNew
            // 
            txtPhoneNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhoneNew.Location = new System.Drawing.Point(140, 146);
            txtPhoneNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPhoneNew.Name = "txtPhoneNew";
            txtPhoneNew.Size = new System.Drawing.Size(224, 24);
            txtPhoneNew.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(30, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 17);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(30, 191);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 17);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(23, 230);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 17);
            label6.TabIndex = 10;
            label6.Text = "Loại khách hàng";
            // 
            // cboTypeCustomerNew
            // 
            cboTypeCustomerNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTypeCustomerNew.FormattingEnabled = true;
            cboTypeCustomerNew.Items.AddRange(new object[] { "VIP", "Thuong" });
            cboTypeCustomerNew.Location = new System.Drawing.Point(140, 230);
            cboTypeCustomerNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboTypeCustomerNew.Name = "cboTypeCustomerNew";
            cboTypeCustomerNew.Size = new System.Drawing.Size(224, 24);
            cboTypeCustomerNew.TabIndex = 6;
            cboTypeCustomerNew.SelectedIndexChanged += cboTypeCustomerNew_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.Honeydew;
            btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(57, 290);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(82, 39);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += bntAdd;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Honeydew;
            btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(251, 290);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 39);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // cboSexNew
            // 
            cboSexNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboSexNew.FormattingEnabled = true;
            cboSexNew.Items.AddRange(new object[] { "Nam", "Nu" });
            cboSexNew.Location = new System.Drawing.Point(140, 105);
            cboSexNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboSexNew.Name = "cboSexNew";
            cboSexNew.Size = new System.Drawing.Size(224, 24);
            cboSexNew.TabIndex = 3;
            cboSexNew.SelectedIndexChanged += cboSexNew_SelectedIndexChanged;
            // 
            // dtmDateAdd
            // 
            dtmDateAdd.CustomFormat = "yyyy-MM-dd";
            dtmDateAdd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtmDateAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtmDateAdd.Location = new System.Drawing.Point(140, 186);
            dtmDateAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtmDateAdd.Name = "dtmDateAdd";
            dtmDateAdd.Size = new System.Drawing.Size(224, 24);
            dtmDateAdd.TabIndex = 5;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Thistle;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(386, 338);
            Controls.Add(dtmDateAdd);
            Controls.Add(cboSexNew);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cboTypeCustomerNew);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhoneNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNameNew);
            Controls.Add(label2);
            Controls.Add(txtIDNew);
            Controls.Add(label1);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdd";
            Text = "Thêm Khách Hàng";
            Load += frmAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDNew;
        private System.Windows.Forms.TextBox txtNameNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTypeCustomerNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSexNew;
        private System.Windows.Forms.DateTimePicker dtmDateAdd;
    }
}