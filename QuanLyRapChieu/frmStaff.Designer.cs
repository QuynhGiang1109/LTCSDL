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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.el_TestLichChieu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pn_LichChieuPhim = new Guna.UI2.WinForms.Guna2Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.gn_Sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_ChonVe = new System.Windows.Forms.Button();
            this.gn_Backgr = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.cboPhongChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_PhongChieu = new System.Windows.Forms.Label();
            this.cboSuatChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gn_boxxuatchieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_SuatChieu = new System.Windows.Forms.Label();
            this.cboFilmName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Phim = new System.Windows.Forms.Label();
            this.lbl_Tgian = new System.Windows.Forms.Label();
            this.el_Backgr = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Tinhtrangve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phòng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuatChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtv_CaChieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pn_LichChieuPhim.SuspendLayout();
            this.gn_Sidebar.SuspendLayout();
            this.gn_Backgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_CaChieu)).BeginInit();
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
            this.pn_LichChieuPhim.Controls.Add(this.labelX);
            this.pn_LichChieuPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_LichChieuPhim.Location = new System.Drawing.Point(0, 0);
            this.pn_LichChieuPhim.Name = "pn_LichChieuPhim";
            this.pn_LichChieuPhim.Size = new System.Drawing.Size(898, 60);
            this.pn_LichChieuPhim.TabIndex = 6;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(311, 9);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(344, 45);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "LỊCH CHIẾU PHIM 🎥";
            // 
            // gn_Sidebar
            // 
            this.gn_Sidebar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gn_Sidebar.Controls.Add(this.btn_ChonVe);
            this.gn_Sidebar.Controls.Add(this.gn_Backgr);
            this.gn_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.gn_Sidebar.Location = new System.Drawing.Point(0, 60);
            this.gn_Sidebar.Name = "gn_Sidebar";
            this.gn_Sidebar.Size = new System.Drawing.Size(250, 540);
            this.gn_Sidebar.TabIndex = 7;
            // 
            // btn_ChonVe
            // 
            this.btn_ChonVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonVe.Location = new System.Drawing.Point(160, 451);
            this.btn_ChonVe.Name = "btn_ChonVe";
            this.btn_ChonVe.Size = new System.Drawing.Size(75, 36);
            this.btn_ChonVe.TabIndex = 1;
            this.btn_ChonVe.Text = "OK";
            this.btn_ChonVe.UseVisualStyleBackColor = true;
            // 
            // gn_Backgr
            // 
            this.gn_Backgr.BackColor = System.Drawing.SystemColors.Control;
            this.gn_Backgr.BorderRadius = 20;
            this.gn_Backgr.Controls.Add(this.dtpThoiGian);
            this.gn_Backgr.Controls.Add(this.cboPhongChieu);
            this.gn_Backgr.Controls.Add(this.lbl_PhongChieu);
            this.gn_Backgr.Controls.Add(this.cboSuatChieu);
            this.gn_Backgr.Controls.Add(this.gn_boxxuatchieu);
            this.gn_Backgr.Controls.Add(this.lbl_SuatChieu);
            this.gn_Backgr.Controls.Add(this.cboFilmName);
            this.gn_Backgr.Controls.Add(this.lbl_Phim);
            this.gn_Backgr.Controls.Add(this.lbl_Tgian);
            this.gn_Backgr.Location = new System.Drawing.Point(14, 29);
            this.gn_Backgr.Name = "gn_Backgr";
            this.gn_Backgr.Size = new System.Drawing.Size(221, 398);
            this.gn_Backgr.TabIndex = 0;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Location = new System.Drawing.Point(13, 69);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(200, 26);
            this.dtpThoiGian.TabIndex = 8;
            // 
            // cboPhongChieu
            // 
            this.cboPhongChieu.BackColor = System.Drawing.Color.Transparent;
            this.cboPhongChieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongChieu.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.cboPhongChieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhongChieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhongChieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhongChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhongChieu.ItemHeight = 30;
            this.cboPhongChieu.Location = new System.Drawing.Point(10, 334);
            this.cboPhongChieu.Name = "cboPhongChieu";
            this.cboPhongChieu.Size = new System.Drawing.Size(199, 36);
            this.cboPhongChieu.TabIndex = 5;
            // 
            // lbl_PhongChieu
            // 
            this.lbl_PhongChieu.AutoSize = true;
            this.lbl_PhongChieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhongChieu.Location = new System.Drawing.Point(7, 306);
            this.lbl_PhongChieu.Name = "lbl_PhongChieu";
            this.lbl_PhongChieu.Size = new System.Drawing.Size(144, 25);
            this.lbl_PhongChieu.TabIndex = 7;
            this.lbl_PhongChieu.Text = "Phòng chiếu🏢";
            // 
            // cboSuatChieu
            // 
            this.cboSuatChieu.BackColor = System.Drawing.Color.Transparent;
            this.cboSuatChieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuatChieu.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.cboSuatChieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSuatChieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSuatChieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSuatChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSuatChieu.ItemHeight = 30;
            this.cboSuatChieu.Location = new System.Drawing.Point(11, 242);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(199, 36);
            this.cboSuatChieu.TabIndex = 3;
            // 
            // gn_boxxuatchieu
            // 
            this.gn_boxxuatchieu.BackColor = System.Drawing.Color.Transparent;
            this.gn_boxxuatchieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gn_boxxuatchieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gn_boxxuatchieu.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.gn_boxxuatchieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gn_boxxuatchieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gn_boxxuatchieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gn_boxxuatchieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gn_boxxuatchieu.ItemHeight = 30;
            this.gn_boxxuatchieu.Location = new System.Drawing.Point(11, 242);
            this.gn_boxxuatchieu.Name = "gn_boxxuatchieu";
            this.gn_boxxuatchieu.Size = new System.Drawing.Size(184, 36);
            this.gn_boxxuatchieu.TabIndex = 3;
            // 
            // lbl_SuatChieu
            // 
            this.lbl_SuatChieu.AutoSize = true;
            this.lbl_SuatChieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SuatChieu.Location = new System.Drawing.Point(7, 215);
            this.lbl_SuatChieu.Name = "lbl_SuatChieu";
            this.lbl_SuatChieu.Size = new System.Drawing.Size(132, 25);
            this.lbl_SuatChieu.TabIndex = 4;
            this.lbl_SuatChieu.Text = "Suất chiếu ⏰";
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
            this.cboFilmName.Location = new System.Drawing.Point(10, 151);
            this.cboFilmName.Name = "cboFilmName";
            this.cboFilmName.Size = new System.Drawing.Size(200, 36);
            this.cboFilmName.TabIndex = 1;
            // 
            // lbl_Phim
            // 
            this.lbl_Phim.AutoSize = true;
            this.lbl_Phim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phim.Location = new System.Drawing.Point(8, 123);
            this.lbl_Phim.Name = "lbl_Phim";
            this.lbl_Phim.Size = new System.Drawing.Size(84, 25);
            this.lbl_Phim.TabIndex = 1;
            this.lbl_Phim.Text = "Phim 🎬";
            // 
            // lbl_Tgian
            // 
            this.lbl_Tgian.AutoSize = true;
            this.lbl_Tgian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tgian.Location = new System.Drawing.Point(8, 41);
            this.lbl_Tgian.Name = "lbl_Tgian";
            this.lbl_Tgian.Size = new System.Drawing.Size(91, 25);
            this.lbl_Tgian.TabIndex = 0;
            this.lbl_Tgian.Text = "Ngày 📅 ";
            // 
            // el_Backgr
            // 
            this.el_Backgr.BorderRadius = 20;
            this.el_Backgr.TargetControl = this.gn_Backgr;
            // 
            // Tinhtrangve
            // 
            this.Tinhtrangve.HeaderText = "🎟 Tình trạng vé";
            this.Tinhtrangve.MinimumWidth = 8;
            this.Tinhtrangve.Name = "Tinhtrangve";
            // 
            // Phim
            // 
            this.Phim.HeaderText = "🎬 Phim";
            this.Phim.MinimumWidth = 8;
            this.Phim.Name = "Phim";
            // 
            // Phòng
            // 
            this.Phòng.HeaderText = "🏢 Phòng";
            this.Phòng.MinimumWidth = 8;
            this.Phòng.Name = "Phòng";
            // 
            // SuatChieu
            // 
            this.SuatChieu.HeaderText = "⏰ Suất chiếu";
            this.SuatChieu.MinimumWidth = 8;
            this.SuatChieu.Name = "SuatChieu";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            // 
            // dtv_CaChieu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtv_CaChieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_CaChieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtv_CaChieu.ColumnHeadersHeight = 22;
            this.dtv_CaChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtv_CaChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phim,
            this.Phòng,
            this.SuatChieu,
            this.Tinhtrangve});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtv_CaChieu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtv_CaChieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtv_CaChieu.Location = new System.Drawing.Point(251, 60);
            this.dtv_CaChieu.Name = "dtv_CaChieu";
            this.dtv_CaChieu.RowHeadersVisible = false;
            this.dtv_CaChieu.RowHeadersWidth = 62;
            this.dtv_CaChieu.RowTemplate.Height = 28;
            this.dtv_CaChieu.Size = new System.Drawing.Size(647, 540);
            this.dtv_CaChieu.TabIndex = 8;
            this.dtv_CaChieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtv_CaChieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtv_CaChieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtv_CaChieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtv_CaChieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtv_CaChieu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtv_CaChieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtv_CaChieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtv_CaChieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtv_CaChieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtv_CaChieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtv_CaChieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtv_CaChieu.ThemeStyle.HeaderStyle.Height = 22;
            this.dtv_CaChieu.ThemeStyle.ReadOnly = false;
            this.dtv_CaChieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtv_CaChieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtv_CaChieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtv_CaChieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtv_CaChieu.ThemeStyle.RowsStyle.Height = 28;
            this.dtv_CaChieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtv_CaChieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 600);
            this.Controls.Add(this.gn_Sidebar);
            this.Controls.Add(this.pn_LichChieuPhim);
            this.Controls.Add(this.dtv_CaChieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.pn_LichChieuPhim.ResumeLayout(false);
            this.pn_LichChieuPhim.PerformLayout();
            this.gn_Sidebar.ResumeLayout(false);
            this.gn_Backgr.ResumeLayout(false);
            this.gn_Backgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_CaChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse el_TestLichChieu;
        private Guna.UI2.WinForms.Guna2Panel gn_Sidebar;
        private System.Windows.Forms.Button btn_ChonVe;
        private Guna.UI2.WinForms.Guna2Panel gn_Backgr;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhongChieu;
        private System.Windows.Forms.Label lbl_PhongChieu;
        private Guna.UI2.WinForms.Guna2ComboBox cboSuatChieu;
        private Guna.UI2.WinForms.Guna2ComboBox gn_boxxuatchieu;
        private System.Windows.Forms.Label lbl_SuatChieu;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilmName;
        private System.Windows.Forms.Label lbl_Phim;
        private System.Windows.Forms.Label lbl_Tgian;
        private Guna.UI2.WinForms.Guna2Panel pn_LichChieuPhim;
        private System.Windows.Forms.Label labelX;
        private Guna.UI2.WinForms.Guna2Elipse el_Backgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrangve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phòng;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuatChieu;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DataGridView dtv_CaChieu;
    }
}