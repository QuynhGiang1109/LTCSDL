namespace QuanLyRapChieu
{
    partial class frmStaff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.el_TestLichChieu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pn_LichChieuPhim = new Guna.UI2.WinForms.Guna2Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.el_Backgr = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtv_CaChieu = new System.Windows.Forms.DataGridView();
            this.gn_Backgr = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Tgian = new System.Windows.Forms.Label();
            this.lbl_Phim = new System.Windows.Forms.Label();
            this.cboFilmName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.btn_ChonVe = new System.Windows.Forms.Button();
            this.gn_Sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pn_LichChieuPhim.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_CaChieu)).BeginInit();
            this.gn_Backgr.SuspendLayout();
            this.gn_Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // el_TestLichChieu
            // 
            this.el_TestLichChieu.BorderRadius = 20;
            this.el_TestLichChieu.TargetControl = this.pn_LichChieuPhim;
            // 
            // pn_LichChieuPhim
            // 
            this.pn_LichChieuPhim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pn_LichChieuPhim.Controls.Add(this.btnClose);
            this.pn_LichChieuPhim.Controls.Add(this.labelX);
            this.pn_LichChieuPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_LichChieuPhim.Location = new System.Drawing.Point(0, 0);
            this.pn_LichChieuPhim.Name = "pn_LichChieuPhim";
            this.pn_LichChieuPhim.Size = new System.Drawing.Size(1380, 73);
            this.pn_LichChieuPhim.TabIndex = 6;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(486, 19);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(393, 41);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "LỊCH CHIẾU PHIM 🎥";
            // 
            // el_Backgr
            // 
            this.el_Backgr.BorderRadius = 20;
            this.el_Backgr.TargetControl = this.gn_Backgr;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_CaChieu);
            this.panel1.Location = new System.Drawing.Point(403, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 757);
            this.panel1.TabIndex = 8;
            // 
            // dtv_CaChieu
            // 
            this.dtv_CaChieu.AllowUserToAddRows = false;
            this.dtv_CaChieu.AllowUserToDeleteRows = false;
            this.dtv_CaChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_CaChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_CaChieu.Location = new System.Drawing.Point(0, 0);
            this.dtv_CaChieu.Name = "dtv_CaChieu";
            this.dtv_CaChieu.ReadOnly = true;
            this.dtv_CaChieu.RowHeadersWidth = 62;
            this.dtv_CaChieu.RowTemplate.Height = 28;
            this.dtv_CaChieu.Size = new System.Drawing.Size(977, 757);
            this.dtv_CaChieu.TabIndex = 1;
            this.dtv_CaChieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_CaChieu_CellContentClick);
            // 
            // gn_Backgr
            // 
            this.gn_Backgr.BackColor = System.Drawing.SystemColors.Control;
            this.gn_Backgr.BorderRadius = 20;
            this.gn_Backgr.Controls.Add(this.dtpThoiGian);
            this.gn_Backgr.Controls.Add(this.cboFilmName);
            this.gn_Backgr.Controls.Add(this.lbl_Phim);
            this.gn_Backgr.Controls.Add(this.lbl_Tgian);
            this.gn_Backgr.Location = new System.Drawing.Point(40, 44);
            this.gn_Backgr.Name = "gn_Backgr";
            this.gn_Backgr.Size = new System.Drawing.Size(319, 239);
            this.gn_Backgr.TabIndex = 0;
            // 
            // lbl_Tgian
            // 
            this.lbl_Tgian.AutoSize = true;
            this.lbl_Tgian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tgian.Location = new System.Drawing.Point(25, 39);
            this.lbl_Tgian.Name = "lbl_Tgian";
            this.lbl_Tgian.Size = new System.Drawing.Size(101, 26);
            this.lbl_Tgian.TabIndex = 0;
            this.lbl_Tgian.Text = "Ngày 📅 ";
            // 
            // lbl_Phim
            // 
            this.lbl_Phim.AutoSize = true;
            this.lbl_Phim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phim.Location = new System.Drawing.Point(25, 119);
            this.lbl_Phim.Name = "lbl_Phim";
            this.lbl_Phim.Size = new System.Drawing.Size(96, 26);
            this.lbl_Phim.TabIndex = 1;
            this.lbl_Phim.Text = "Phim 🎬";
            // 
            // cboFilmName
            // 
            this.cboFilmName.BackColor = System.Drawing.Color.Transparent;
            this.cboFilmName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilmName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilmName.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.cboFilmName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilmName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilmName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboFilmName.ItemHeight = 30;
            this.cboFilmName.Location = new System.Drawing.Point(30, 149);
            this.cboFilmName.Name = "cboFilmName";
            this.cboFilmName.Size = new System.Drawing.Size(262, 36);
            this.cboFilmName.TabIndex = 1;
            this.cboFilmName.SelectedIndexChanged += new System.EventHandler(this.cboFilmName_SelectedIndexChanged);
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Location = new System.Drawing.Point(30, 69);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(262, 33);
            this.dtpThoiGian.TabIndex = 8;
            this.dtpThoiGian.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
            // 
            // btn_ChonVe
            // 
            this.btn_ChonVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonVe.Location = new System.Drawing.Point(222, 330);
            this.btn_ChonVe.Name = "btn_ChonVe";
            this.btn_ChonVe.Size = new System.Drawing.Size(137, 35);
            this.btn_ChonVe.TabIndex = 1;
            this.btn_ChonVe.Text = "CHỌN VÉ";
            this.btn_ChonVe.UseVisualStyleBackColor = true;
            this.btn_ChonVe.Click += new System.EventHandler(this.btn_ChonVe_Click);
            // 
            // gn_Sidebar
            // 
            this.gn_Sidebar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gn_Sidebar.Controls.Add(this.btn_ChonVe);
            this.gn_Sidebar.Controls.Add(this.gn_Backgr);
            this.gn_Sidebar.Location = new System.Drawing.Point(0, 73);
            this.gn_Sidebar.Name = "gn_Sidebar";
            this.gn_Sidebar.Size = new System.Drawing.Size(405, 757);
            this.gn_Sidebar.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.Location = new System.Drawing.Point(1304, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(76, 74);
            this.btnClose.TabIndex = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gn_Sidebar);
            this.Controls.Add(this.pn_LichChieuPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.pn_LichChieuPhim.ResumeLayout(false);
            this.pn_LichChieuPhim.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_CaChieu)).EndInit();
            this.gn_Backgr.ResumeLayout(false);
            this.gn_Backgr.PerformLayout();
            this.gn_Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse el_TestLichChieu;
        private Guna.UI2.WinForms.Guna2Panel pn_LichChieuPhim;
        private System.Windows.Forms.Label labelX;
        private Guna.UI2.WinForms.Guna2Elipse el_Backgr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtv_CaChieu;
        private Guna.UI2.WinForms.Guna2Panel gn_Backgr;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilmName;
        private System.Windows.Forms.Label lbl_Phim;
        private System.Windows.Forms.Label lbl_Tgian;
        private System.Windows.Forms.Button btn_ChonVe;
        private Guna.UI2.WinForms.Guna2Panel gn_Sidebar;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}