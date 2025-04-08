using System;
using System.Windows.Forms;
namespace QuanLyRapChieu.frmAdminUserControl
{
    partial class RevenueUC
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
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.cboSelectMovie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtmFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnShowRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.pnSelectMovie = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.pnSelectMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMovie.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSelectMovie.Location = new System.Drawing.Point(62, 19);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(131, 25);
            this.lblSelectMovie.TabIndex = 39;
            this.lblSelectMovie.Text = "Chọn phim:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(449, 565);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(181, 25);
            this.lblTongDoanhThu.TabIndex = 38;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDoanhThu.Location = new System.Drawing.Point(713, 555);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(235, 35);
            this.txtDoanhThu.TabIndex = 37;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDenNgay.Location = new System.Drawing.Point(387, 73);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(96, 23);
            this.lblDenNgay.TabIndex = 36;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(63, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Từ ngày:";
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.AllowUserToAddRows = false;
            this.dtgvRevenue.AllowUserToDeleteRows = false;
            this.dtgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(45, 156);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.ReadOnly = true;
            this.dtgvRevenue.RowHeadersWidth = 51;
            this.dtgvRevenue.Size = new System.Drawing.Size(903, 375);
            this.dtgvRevenue.TabIndex = 34;
            this.dtgvRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRevenue_CellContentClick);
            // 
            // cboSelectMovie
            // 
            this.cboSelectMovie.AutoRoundedCorners = true;
            this.cboSelectMovie.BackColor = System.Drawing.Color.Transparent;
            this.cboSelectMovie.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.cboSelectMovie.BorderThickness = 2;
            this.cboSelectMovie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectMovie.FillColor = System.Drawing.Color.AliceBlue;
            this.cboSelectMovie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSelectMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSelectMovie.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboSelectMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSelectMovie.ItemHeight = 30;
            this.cboSelectMovie.Location = new System.Drawing.Point(229, 8);
            this.cboSelectMovie.Name = "cboSelectMovie";
            this.cboSelectMovie.Size = new System.Drawing.Size(477, 36);
            this.cboSelectMovie.TabIndex = 40;
            // 
            // dtmFromDate
            // 
            this.dtmFromDate.AutoRoundedCorners = true;
            this.dtmFromDate.BorderThickness = 1;
            this.dtmFromDate.Checked = true;
            this.dtmFromDate.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtmFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmFromDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtmFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmFromDate.Location = new System.Drawing.Point(156, 68);
            this.dtmFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmFromDate.Name = "dtmFromDate";
            this.dtmFromDate.Size = new System.Drawing.Size(208, 34);
            this.dtmFromDate.TabIndex = 41;
            this.dtmFromDate.Value = new System.DateTime(2025, 4, 6, 18, 8, 18, 104);
            // 
            // dtmToDate
            // 
            this.dtmToDate.AutoRoundedCorners = true;
            this.dtmToDate.BorderThickness = 1;
            this.dtmToDate.Checked = true;
            this.dtmToDate.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtmToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmToDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtmToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmToDate.Location = new System.Drawing.Point(489, 68);
            this.dtmToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmToDate.Name = "dtmToDate";
            this.dtmToDate.Size = new System.Drawing.Size(217, 34);
            this.dtmToDate.TabIndex = 42;
            this.dtmToDate.Value = new System.DateTime(2025, 4, 6, 18, 24, 17, 282);
            // 
            // btnShowRevenue
            // 
            this.btnShowRevenue.AutoRoundedCorners = true;
            this.btnShowRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnShowRevenue.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnShowRevenue.BorderRadius = 20;
            this.btnShowRevenue.BorderThickness = 2;
            this.btnShowRevenue.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnShowRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowRevenue.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowRevenue.ForeColor = System.Drawing.Color.Black;
            this.btnShowRevenue.HoverState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShowRevenue.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnShowRevenue.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnShowRevenue.IndicateFocus = true;
            this.btnShowRevenue.Location = new System.Drawing.Point(749, 60);
            this.btnShowRevenue.Name = "btnShowRevenue";
            this.btnShowRevenue.PressedColor = System.Drawing.Color.Transparent;
            this.btnShowRevenue.PressedDepth = 10;
            this.btnShowRevenue.ShadowDecoration.BorderRadius = 14;
            this.btnShowRevenue.ShadowDecoration.Color = System.Drawing.Color.DarkSlateBlue;
            this.btnShowRevenue.ShadowDecoration.Depth = 10;
            this.btnShowRevenue.ShadowDecoration.Enabled = true;
            this.btnShowRevenue.Size = new System.Drawing.Size(151, 42);
            this.btnShowRevenue.TabIndex = 43;
            this.btnShowRevenue.Text = "Thống kê";
            this.btnShowRevenue.Click += new System.EventHandler(this.btnShowRevenue_Click);
            // 
            // pnSelectMovie
            // 
            this.pnSelectMovie.Controls.Add(this.btnShowRevenue);
            this.pnSelectMovie.Controls.Add(this.dtmToDate);
            this.pnSelectMovie.Controls.Add(this.dtmFromDate);
            this.pnSelectMovie.Controls.Add(this.label1);
            this.pnSelectMovie.Controls.Add(this.cboSelectMovie);
            this.pnSelectMovie.Controls.Add(this.lblSelectMovie);
            this.pnSelectMovie.Controls.Add(this.lblDenNgay);
            this.pnSelectMovie.Location = new System.Drawing.Point(45, 14);
            this.pnSelectMovie.Name = "pnSelectMovie";
            this.pnSelectMovie.Size = new System.Drawing.Size(903, 125);
            this.pnSelectMovie.TabIndex = 44;
            // 
            // RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.pnSelectMovie);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.dtgvRevenue);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RevenueUC";
            this.Size = new System.Drawing.Size(994, 611);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.pnSelectMovie.ResumeLayout(false);
            this.pnSelectMovie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private Guna.UI2.WinForms.Guna2ComboBox cboSelectMovie;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmFromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmToDate;
        private Guna.UI2.WinForms.Guna2Button btnShowRevenue;
        private Guna.UI2.WinForms.Guna2Panel pnSelectMovie;
    }
}
