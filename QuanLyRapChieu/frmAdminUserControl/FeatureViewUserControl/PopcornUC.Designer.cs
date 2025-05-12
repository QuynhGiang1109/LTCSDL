namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    partial class PopcornUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvPopcorn = new System.Windows.Forms.DataGridView();
            this.txtGiaCbo = new System.Windows.Forms.TextBox();
            this.txtTenCbo = new System.Windows.Forms.TextBox();
            this.txtMaCbo = new System.Windows.Forms.TextBox();
            this.lblGiaCbo = new System.Windows.Forms.Label();
            this.lblTenCbo = new System.Windows.Forms.Label();
            this.lblMaCbo = new System.Windows.Forms.Label();
            this.btnUpdatePopcorn = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeletePopcorn = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertPopcorn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPopcorn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 108);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDeletePopcorn);
            this.panel2.Controls.Add(this.btnInsertPopcorn);
            this.panel2.Controls.Add(this.dtgvPopcorn);
            this.panel2.Controls.Add(this.btnUpdatePopcorn);
            this.panel2.Controls.Add(this.txtGiaCbo);
            this.panel2.Controls.Add(this.txtTenCbo);
            this.panel2.Controls.Add(this.txtMaCbo);
            this.panel2.Controls.Add(this.lblGiaCbo);
            this.panel2.Controls.Add(this.lblTenCbo);
            this.panel2.Controls.Add(this.lblMaCbo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1491, 832);
            this.panel2.TabIndex = 1;
            // 
            // dtgvPopcorn
            // 
            this.dtgvPopcorn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPopcorn.Location = new System.Drawing.Point(647, 6);
            this.dtgvPopcorn.Name = "dtgvPopcorn";
            this.dtgvPopcorn.RowHeadersWidth = 62;
            this.dtgvPopcorn.RowTemplate.Height = 28;
            this.dtgvPopcorn.Size = new System.Drawing.Size(834, 812);
            this.dtgvPopcorn.TabIndex = 22;
            // 
            // txtGiaCbo
            // 
            this.txtGiaCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaCbo.Location = new System.Drawing.Point(227, 181);
            this.txtGiaCbo.Name = "txtGiaCbo";
            this.txtGiaCbo.Size = new System.Drawing.Size(382, 35);
            this.txtGiaCbo.TabIndex = 21;
            // 
            // txtTenCbo
            // 
            this.txtTenCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCbo.Location = new System.Drawing.Point(227, 109);
            this.txtTenCbo.Name = "txtTenCbo";
            this.txtTenCbo.Size = new System.Drawing.Size(382, 35);
            this.txtTenCbo.TabIndex = 20;
            // 
            // txtMaCbo
            // 
            this.txtMaCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCbo.Location = new System.Drawing.Point(227, 52);
            this.txtMaCbo.Name = "txtMaCbo";
            this.txtMaCbo.Size = new System.Drawing.Size(382, 35);
            this.txtMaCbo.TabIndex = 19;
            // 
            // lblGiaCbo
            // 
            this.lblGiaCbo.AutoSize = true;
            this.lblGiaCbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaCbo.Location = new System.Drawing.Point(36, 186);
            this.lblGiaCbo.Name = "lblGiaCbo";
            this.lblGiaCbo.Size = new System.Drawing.Size(49, 26);
            this.lblGiaCbo.TabIndex = 18;
            this.lblGiaCbo.Text = "Giá";
            // 
            // lblTenCbo
            // 
            this.lblTenCbo.AutoSize = true;
            this.lblTenCbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCbo.Location = new System.Drawing.Point(32, 118);
            this.lblTenCbo.Name = "lblTenCbo";
            this.lblTenCbo.Size = new System.Drawing.Size(124, 26);
            this.lblTenCbo.TabIndex = 17;
            this.lblTenCbo.Text = "Tên combo";
            // 
            // lblMaCbo
            // 
            this.lblMaCbo.AutoSize = true;
            this.lblMaCbo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCbo.Location = new System.Drawing.Point(36, 57);
            this.lblMaCbo.Name = "lblMaCbo";
            this.lblMaCbo.Size = new System.Drawing.Size(120, 26);
            this.lblMaCbo.TabIndex = 16;
            this.lblMaCbo.Text = "Mã combo";
            // 
            // btnUpdatePopcorn
            // 
            this.btnUpdatePopcorn.AutoRoundedCorners = true;
            this.btnUpdatePopcorn.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdatePopcorn.BorderRadius = 25;
            this.btnUpdatePopcorn.BorderThickness = 2;
            this.btnUpdatePopcorn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePopcorn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePopcorn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePopcorn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdatePopcorn.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdatePopcorn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePopcorn.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePopcorn.IndicateFocus = true;
            this.btnUpdatePopcorn.Location = new System.Drawing.Point(246, 271);
            this.btnUpdatePopcorn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatePopcorn.Name = "btnUpdatePopcorn";
            this.btnUpdatePopcorn.Size = new System.Drawing.Size(124, 52);
            this.btnUpdatePopcorn.TabIndex = 15;
            this.btnUpdatePopcorn.Text = "Sửa";
            // 
            // btnDeletePopcorn
            // 
            this.btnDeletePopcorn.AutoRoundedCorners = true;
            this.btnDeletePopcorn.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeletePopcorn.BorderRadius = 25;
            this.btnDeletePopcorn.BorderThickness = 2;
            this.btnDeletePopcorn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePopcorn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletePopcorn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeletePopcorn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeletePopcorn.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeletePopcorn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePopcorn.ForeColor = System.Drawing.Color.Black;
            this.btnDeletePopcorn.IndicateFocus = true;
            this.btnDeletePopcorn.Location = new System.Drawing.Point(447, 271);
            this.btnDeletePopcorn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePopcorn.Name = "btnDeletePopcorn";
            this.btnDeletePopcorn.Size = new System.Drawing.Size(124, 52);
            this.btnDeletePopcorn.TabIndex = 14;
            this.btnDeletePopcorn.Text = "Xóa";
            // 
            // btnInsertPopcorn
            // 
            this.btnInsertPopcorn.AutoRoundedCorners = true;
            this.btnInsertPopcorn.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnInsertPopcorn.BorderRadius = 25;
            this.btnInsertPopcorn.BorderThickness = 2;
            this.btnInsertPopcorn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertPopcorn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertPopcorn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertPopcorn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertPopcorn.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnInsertPopcorn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPopcorn.ForeColor = System.Drawing.Color.Black;
            this.btnInsertPopcorn.IndicateFocus = true;
            this.btnInsertPopcorn.Location = new System.Drawing.Point(56, 271);
            this.btnInsertPopcorn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertPopcorn.Name = "btnInsertPopcorn";
            this.btnInsertPopcorn.Size = new System.Drawing.Size(124, 52);
            this.btnInsertPopcorn.TabIndex = 13;
            this.btnInsertPopcorn.Text = "Thêm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "🎞️🍿🥤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "🎞️🍿🥤";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "🎞️🍿🥤";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1336, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 36);
            this.label4.TabIndex = 28;
            this.label4.Text = "🎞️🍿🥤";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1070, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 36);
            this.label5.TabIndex = 27;
            this.label5.Text = "🎞️🍿🥤";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(799, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 36);
            this.label6.TabIndex = 26;
            this.label6.Text = "🎞️🍿🥤";
            // 
            // Popcorn_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Popcorn_UC";
            this.Size = new System.Drawing.Size(1491, 940);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPopcorn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnDeletePopcorn;
        private Guna.UI2.WinForms.Guna2Button btnInsertPopcorn;
        private System.Windows.Forms.DataGridView dtgvPopcorn;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePopcorn;
        private System.Windows.Forms.TextBox txtGiaCbo;
        private System.Windows.Forms.TextBox txtTenCbo;
        private System.Windows.Forms.TextBox txtMaCbo;
        private System.Windows.Forms.Label lblGiaCbo;
        private System.Windows.Forms.Label lblTenCbo;
        private System.Windows.Forms.Label lblMaCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}
