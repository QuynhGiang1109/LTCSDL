namespace QuanLyRapChieu.frmAdminUserControl
{
    partial class StaffUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUC));
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.Show_MK = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_idNV = new System.Windows.Forms.TextBox();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblStaffName_Account = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.btnInsertAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.lbAccUC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            this.SuspendLayout();
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND/CCCD";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // idVN
            // 
            this.idVN.DataPropertyName = "idNV";
            this.idVN.HeaderText = "Mã nhân viên";
            this.idVN.MinimumWidth = 6;
            this.idVN.Name = "idVN";
            this.idVN.ReadOnly = true;
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.AllowUserToDeleteRows = false;
            this.dtgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVN,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi,
            this.SDT,
            this.CMND});
            this.dtgvStaff.Location = new System.Drawing.Point(0, 207);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.Size = new System.Drawing.Size(994, 404);
            this.dtgvStaff.TabIndex = 24;
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.Show_MK);
            this.grpAccount.Controls.Add(this.txt_Pass);
            this.grpAccount.Controls.Add(this.txt_idNV);
            this.grpAccount.Controls.Add(this.nudAccountType);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.lblStaffName_Account);
            this.grpAccount.Controls.Add(this.lblAccountType);
            this.grpAccount.Controls.Add(this.lblStaffID_Account);
            this.grpAccount.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.Location = new System.Drawing.Point(248, 8);
            this.grpAccount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grpAccount.Size = new System.Drawing.Size(483, 138);
            this.grpAccount.TabIndex = 25;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Thông tin tài khoản";
            // 
            // Show_MK
            // 
            this.Show_MK.AutoSize = true;
            this.Show_MK.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_MK.Location = new System.Drawing.Point(339, 108);
            this.Show_MK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Show_MK.Name = "Show_MK";
            this.Show_MK.Size = new System.Drawing.Size(77, 19);
            this.Show_MK.TabIndex = 7;
            this.Show_MK.Text = "Mật Khẩu";
            this.Show_MK.UseMnemonic = false;
            this.Show_MK.UseVisualStyleBackColor = true;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(327, 68);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(111, 29);
            this.txt_Pass.TabIndex = 8;
            // 
            // txt_idNV
            // 
            this.txt_idNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idNV.Location = new System.Drawing.Point(103, 68);
            this.txt_idNV.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_idNV.Name = "txt_idNV";
            this.txt_idNV.Size = new System.Drawing.Size(111, 26);
            this.txt_idNV.TabIndex = 7;
            // 
            // nudAccountType
            // 
            this.nudAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAccountType.Location = new System.Drawing.Point(327, 22);
            this.nudAccountType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nudAccountType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAccountType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(106, 26);
            this.nudAccountType.TabIndex = 6;
            this.nudAccountType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(17, 27);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:\r\n";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(103, 26);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(111, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            this.lblStaffName_Account.AutoSize = true;
            this.lblStaffName_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName_Account.Location = new System.Drawing.Point(244, 72);
            this.lblStaffName_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffName_Account.Name = "lblStaffName_Account";
            this.lblStaffName_Account.Size = new System.Drawing.Size(77, 19);
            this.lblStaffName_Account.TabIndex = 4;
            this.lblStaffName_Account.Text = "Password:\r\n";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(244, 27);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(74, 19);
            this.lblAccountType.TabIndex = 4;
            this.lblAccountType.Text = "Loại TK: ";
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID_Account.Location = new System.Drawing.Point(17, 72);
            this.lblStaffID_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(64, 19);
            this.lblStaffID_Account.TabIndex = 4;
            this.lblStaffID_Account.Text = "Mã NV:";
            // 
            // btnInsertAccount
            // 
            this.btnInsertAccount.AutoRoundedCorners = true;
            this.btnInsertAccount.BorderColor = System.Drawing.Color.White;
            this.btnInsertAccount.BorderRadius = 16;
            this.btnInsertAccount.BorderThickness = 2;
            this.btnInsertAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertAccount.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnInsertAccount.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnInsertAccount.ForeColor = System.Drawing.Color.White;
            this.btnInsertAccount.IndicateFocus = true;
            this.btnInsertAccount.Location = new System.Drawing.Point(308, 155);
            this.btnInsertAccount.Name = "btnInsertAccount";
            this.btnInsertAccount.Size = new System.Drawing.Size(83, 34);
            this.btnInsertAccount.TabIndex = 34;
            this.btnInsertAccount.Text = "Thêm";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoRoundedCorners = true;
            this.btnDeleteAccount.BorderColor = System.Drawing.Color.White;
            this.btnDeleteAccount.BorderRadius = 16;
            this.btnDeleteAccount.BorderThickness = 2;
            this.btnDeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAccount.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.IndicateFocus = true;
            this.btnDeleteAccount.Location = new System.Drawing.Point(453, 155);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteAccount.TabIndex = 35;
            this.btnDeleteAccount.Text = "Xóa";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.AutoRoundedCorners = true;
            this.btnUpdateAccount.BorderColor = System.Drawing.Color.White;
            this.btnUpdateAccount.BorderRadius = 16;
            this.btnUpdateAccount.BorderThickness = 2;
            this.btnUpdateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAccount.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.IndicateFocus = true;
            this.btnUpdateAccount.Location = new System.Drawing.Point(590, 155);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(83, 34);
            this.btnUpdateAccount.TabIndex = 36;
            this.btnUpdateAccount.Text = "Sửa";
            // 
            // lbAccUC
            // 
            this.lbAccUC.AutoSize = true;
            this.lbAccUC.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccUC.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbAccUC.Location = new System.Drawing.Point(38, 150);
            this.lbAccUC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccUC.Name = "lbAccUC";
            this.lbAccUC.Size = new System.Drawing.Size(177, 21);
            this.lbAccUC.TabIndex = 38;
            this.lbAccUC.Text = "OMG Account Cinema";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(59, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 133);
            this.panel1.TabIndex = 39;
            // 
            // StaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAccUC);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnInsertAccount);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.dtgvStaff);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffUC";
            this.Size = new System.Drawing.Size(994, 611);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVN;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.CheckBox Show_MK;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_idNV;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblStaffName_Account;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffID_Account;
        private Guna.UI2.WinForms.Guna2Button btnInsertAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAccount;
        private System.Windows.Forms.Label lbAccUC;
        private System.Windows.Forms.Panel panel1;
    }
}
