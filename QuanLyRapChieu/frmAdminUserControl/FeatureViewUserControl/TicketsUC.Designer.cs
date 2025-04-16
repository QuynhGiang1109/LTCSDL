namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    partial class TicketsUC
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
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel61 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteTicketsByShowTime = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllListShowTimes = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.panel61.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Location = new System.Drawing.Point(23, 91);
            this.dtgvTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.RowHeadersWidth = 51;
            this.dtgvTicket.Size = new System.Drawing.Size(667, 698);
            this.dtgvTicket.TabIndex = 21;
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAllListShowTimes.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = false;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(0, 0);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(774, 701);
            this.lsvAllListShowTimes.TabIndex = 22;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Ca Chiếu";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phòng Chiếu";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái Chiếu";
            this.columnHeader4.Width = 410;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.btnAllListShowTimes);
            this.panel61.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.panel61.Location = new System.Drawing.Point(23, 3);
            this.panel61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(431, 80);
            this.panel61.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel61);
            this.panel1.Controls.Add(this.dtgvTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 940);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvAllListShowTimes);
            this.panel2.Location = new System.Drawing.Point(697, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 701);
            this.panel2.TabIndex = 24;
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.AutoRoundedCorners = true;
            this.btnDeleteTicketsByShowTime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteTicketsByShowTime.BorderRadius = 32;
            this.btnDeleteTicketsByShowTime.BorderThickness = 2;
            this.btnDeleteTicketsByShowTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTicketsByShowTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTicketsByShowTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteTicketsByShowTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteTicketsByShowTime.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteTicketsByShowTime.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicketsByShowTime.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTicketsByShowTime.IndicateFocus = true;
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(7, 8);
            this.btnDeleteTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(199, 67);
            this.btnDeleteTicketsByShowTime.TabIndex = 40;
            this.btnDeleteTicketsByShowTime.TabStop = false;
            this.btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.AutoRoundedCorners = true;
            this.btnAllListShowTimes.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAllListShowTimes.BorderRadius = 32;
            this.btnAllListShowTimes.BorderThickness = 2;
            this.btnAllListShowTimes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllListShowTimes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllListShowTimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllListShowTimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllListShowTimes.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnAllListShowTimes.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllListShowTimes.ForeColor = System.Drawing.Color.Black;
            this.btnAllListShowTimes.IndicateFocus = true;
            this.btnAllListShowTimes.Location = new System.Drawing.Point(229, 8);
            this.btnAllListShowTimes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(192, 67);
            this.btnAllListShowTimes.TabIndex = 41;
            this.btnAllListShowTimes.TabStop = false;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu";
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(1491, 940);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.panel61.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.ListView lsvAllListShowTimes;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAllListShowTimes;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTicketsByShowTime;
    }
}
