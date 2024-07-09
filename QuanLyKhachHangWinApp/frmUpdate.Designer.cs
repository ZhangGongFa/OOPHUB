namespace QuanLyKhachHangWinApp
{
    partial class frmUpdate
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
            btnCancel = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            cboTypeCustomerUpdate = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtPhoneUpdate = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtNameUpdate = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtIDUpdate = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cboSexUpdate = new System.Windows.Forms.ComboBox();
            dtmDateUpdate = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Honeydew;
            btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(280, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 55);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(87, 383);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 55);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cboTypeCustomerUpdate
            // 
            cboTypeCustomerUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTypeCustomerUpdate.FormattingEnabled = true;
            cboTypeCustomerUpdate.Items.AddRange(new object[] { "VIP", "Thuong" });
            cboTypeCustomerUpdate.Location = new System.Drawing.Point(163, 308);
            cboTypeCustomerUpdate.Name = "cboTypeCustomerUpdate";
            cboTypeCustomerUpdate.Size = new System.Drawing.Size(255, 28);
            cboTypeCustomerUpdate.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(29, 308);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(128, 20);
            label6.TabIndex = 37;
            label6.Text = "Loại khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(37, 256);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 20);
            label5.TabIndex = 35;
            label5.Text = "Ngày sinh";
            // 
            // txtPhoneUpdate
            // 
            txtPhoneUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhoneUpdate.Location = new System.Drawing.Point(163, 196);
            txtPhoneUpdate.Name = "txtPhoneUpdate";
            txtPhoneUpdate.Size = new System.Drawing.Size(255, 28);
            txtPhoneUpdate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(37, 199);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(103, 20);
            label4.TabIndex = 33;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(37, 144);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 20);
            label3.TabIndex = 31;
            label3.Text = "Giới tính";
            // 
            // txtNameUpdate
            // 
            txtNameUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNameUpdate.Location = new System.Drawing.Point(163, 89);
            txtNameUpdate.Name = "txtNameUpdate";
            txtNameUpdate.Size = new System.Drawing.Size(255, 28);
            txtNameUpdate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(37, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 20);
            label2.TabIndex = 29;
            label2.Text = "Tên khách hàng";
            // 
            // txtIDUpdate
            // 
            txtIDUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIDUpdate.Location = new System.Drawing.Point(163, 39);
            txtIDUpdate.Name = "txtIDUpdate";
            txtIDUpdate.Size = new System.Drawing.Size(255, 28);
            txtIDUpdate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(37, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 20);
            label1.TabIndex = 27;
            label1.Text = "Mã khách hàng";
            // 
            // cboSexUpdate
            // 
            cboSexUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboSexUpdate.FormattingEnabled = true;
            cboSexUpdate.Items.AddRange(new object[] { "Nam", "Nu" });
            cboSexUpdate.Location = new System.Drawing.Point(163, 144);
            cboSexUpdate.Name = "cboSexUpdate";
            cboSexUpdate.Size = new System.Drawing.Size(255, 28);
            cboSexUpdate.TabIndex = 3;
            // 
            // dtmDateUpdate
            // 
            dtmDateUpdate.CustomFormat = "yyyy-MM-dd";
            dtmDateUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtmDateUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtmDateUpdate.Location = new System.Drawing.Point(163, 251);
            dtmDateUpdate.Name = "dtmDateUpdate";
            dtmDateUpdate.Size = new System.Drawing.Size(255, 28);
            dtmDateUpdate.TabIndex = 5;
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Thistle;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(475, 450);
            Controls.Add(dtmDateUpdate);
            Controls.Add(cboSexUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(cboTypeCustomerUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhoneUpdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNameUpdate);
            Controls.Add(label2);
            Controls.Add(txtIDUpdate);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdate";
            Text = "Chỉnh Sửa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboTypeCustomerUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSexUpdate;
        private System.Windows.Forms.DateTimePicker dtmDateUpdate;
    }
}