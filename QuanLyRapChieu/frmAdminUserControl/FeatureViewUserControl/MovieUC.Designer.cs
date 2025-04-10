namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    partial class MovieUC
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
            this.components = new System.ComponentModel.Container();
            this.panel47 = new System.Windows.Forms.Panel();
            this.UpdateMovie = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteMovie = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMovie = new Guna.UI2.WinForms.Guna2Button();
            this.numericUpDownPhim = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.clbMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.dtmMovieEnd = new System.Windows.Forms.DateTimePicker();
            this.dtmMovieStart = new System.Windows.Forms.DateTimePicker();
            this.txtMovieYearLimit = new System.Windows.Forms.TextBox();
            this.txtMovieActor = new System.Windows.Forms.TextBox();
            this.txtMovieCountry = new System.Windows.Forms.TextBox();
            this.txtMovieLength = new System.Windows.Forms.TextBox();
            this.lblMovieEndDate = new System.Windows.Forms.Label();
            this.lblMovieStartDate = new System.Windows.Forms.Label();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMovieDesc = new System.Windows.Forms.TextBox();
            this.lblMovieYearLimit = new System.Windows.Forms.Label();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMovieCountry = new System.Windows.Forms.Label();
            this.lblMovieDesc = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMovie = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMovieActor = new System.Windows.Forms.Label();
            this.panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhim)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel47
            // 
            this.panel47.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel47.Controls.Add(this.UpdateMovie);
            this.panel47.Controls.Add(this.btnDeleteMovie);
            this.panel47.Controls.Add(this.btnAddMovie);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel47.Location = new System.Drawing.Point(0, 250);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(994, 52);
            this.panel47.TabIndex = 10;
            // 
            // UpdateMovie
            // 
            this.UpdateMovie.AutoRoundedCorners = true;
            this.UpdateMovie.BorderColor = System.Drawing.Color.MidnightBlue;
            this.UpdateMovie.BorderRadius = 16;
            this.UpdateMovie.BorderThickness = 2;
            this.UpdateMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateMovie.FillColor = System.Drawing.Color.LightSteelBlue;
            this.UpdateMovie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.UpdateMovie.ForeColor = System.Drawing.Color.Black;
            this.UpdateMovie.IndicateFocus = true;
            this.UpdateMovie.Location = new System.Drawing.Point(223, 8);
            this.UpdateMovie.Name = "UpdateMovie";
            this.UpdateMovie.Size = new System.Drawing.Size(83, 34);
            this.UpdateMovie.TabIndex = 39;
            this.UpdateMovie.Text = "Sửa";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.AutoRoundedCorners = true;
            this.btnDeleteMovie.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteMovie.BorderRadius = 16;
            this.btnDeleteMovie.BorderThickness = 2;
            this.btnDeleteMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteMovie.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMovie.IndicateFocus = true;
            this.btnDeleteMovie.Location = new System.Drawing.Point(117, 8);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteMovie.TabIndex = 38;
            this.btnDeleteMovie.Text = "Xóa";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.AutoRoundedCorners = true;
            this.btnAddMovie.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAddMovie.BorderRadius = 16;
            this.btnAddMovie.BorderThickness = 2;
            this.btnAddMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMovie.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddMovie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovie.IndicateFocus = true;
            this.btnAddMovie.Location = new System.Drawing.Point(9, 8);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(83, 34);
            this.btnAddMovie.TabIndex = 37;
            this.btnAddMovie.Text = "Thêm";
            // 
            // numericUpDownPhim
            // 
            this.numericUpDownPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPhim.Location = new System.Drawing.Point(706, 192);
            this.numericUpDownPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPhim.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownPhim.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownPhim.Name = "numericUpDownPhim";
            this.numericUpDownPhim.Size = new System.Drawing.Size(184, 26);
            this.numericUpDownPhim.TabIndex = 3;
            this.numericUpDownPhim.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "Năm SX:";
            // 
            // clbMovieGenre
            // 
            this.clbMovieGenre.CheckOnClick = true;
            this.clbMovieGenre.FormattingEnabled = true;
            this.clbMovieGenre.Location = new System.Drawing.Point(33, 138);
            this.clbMovieGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbMovieGenre.MultiColumn = true;
            this.clbMovieGenre.Name = "clbMovieGenre";
            this.clbMovieGenre.Size = new System.Drawing.Size(244, 109);
            this.clbMovieGenre.TabIndex = 54;
            // 
            // dtmMovieEnd
            // 
            this.dtmMovieEnd.CustomFormat = "yyyy/MM/dd";
            this.dtmMovieEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieEnd.Location = new System.Drawing.Point(706, 98);
            this.dtmMovieEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmMovieEnd.Name = "dtmMovieEnd";
            this.dtmMovieEnd.Size = new System.Drawing.Size(185, 26);
            this.dtmMovieEnd.TabIndex = 53;
            // 
            // dtmMovieStart
            // 
            this.dtmMovieStart.CustomFormat = "yyyy/MM/dd";
            this.dtmMovieStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieStart.Location = new System.Drawing.Point(706, 70);
            this.dtmMovieStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmMovieStart.Name = "dtmMovieStart";
            this.dtmMovieStart.Size = new System.Drawing.Size(185, 26);
            this.dtmMovieStart.TabIndex = 52;
            // 
            // txtMovieYearLimit
            // 
            this.txtMovieYearLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieYearLimit.Location = new System.Drawing.Point(706, 223);
            this.txtMovieYearLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieYearLimit.Name = "txtMovieYearLimit";
            this.txtMovieYearLimit.Size = new System.Drawing.Size(185, 26);
            this.txtMovieYearLimit.TabIndex = 50;
            // 
            // txtMovieActor
            // 
            this.txtMovieActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieActor.Location = new System.Drawing.Point(706, 161);
            this.txtMovieActor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieActor.Name = "txtMovieActor";
            this.txtMovieActor.Size = new System.Drawing.Size(185, 26);
            this.txtMovieActor.TabIndex = 49;
            // 
            // txtMovieCountry
            // 
            this.txtMovieCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieCountry.Location = new System.Drawing.Point(706, 132);
            this.txtMovieCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieCountry.Name = "txtMovieCountry";
            this.txtMovieCountry.Size = new System.Drawing.Size(185, 26);
            this.txtMovieCountry.TabIndex = 48;
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieLength.Location = new System.Drawing.Point(706, 41);
            this.txtMovieLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(185, 26);
            this.txtMovieLength.TabIndex = 47;
            // 
            // lblMovieEndDate
            // 
            this.lblMovieEndDate.AutoSize = true;
            this.lblMovieEndDate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieEndDate.Location = new System.Drawing.Point(561, 99);
            this.lblMovieEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieEndDate.Name = "lblMovieEndDate";
            this.lblMovieEndDate.Size = new System.Drawing.Size(89, 22);
            this.lblMovieEndDate.TabIndex = 44;
            this.lblMovieEndDate.Text = "Ngày KT:";
            // 
            // lblMovieStartDate
            // 
            this.lblMovieStartDate.AutoSize = true;
            this.lblMovieStartDate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieStartDate.Location = new System.Drawing.Point(561, 72);
            this.lblMovieStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieStartDate.Name = "lblMovieStartDate";
            this.lblMovieStartDate.Size = new System.Drawing.Size(91, 22);
            this.lblMovieStartDate.TabIndex = 42;
            this.lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieLength.Location = new System.Drawing.Point(561, 43);
            this.lblMovieLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(106, 22);
            this.lblMovieLength.TabIndex = 35;
            this.lblMovieLength.Text = "Thời lượng:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMovieDesc
            // 
            this.txtMovieDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieDesc.Location = new System.Drawing.Point(125, 79);
            this.txtMovieDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieDesc.Multiline = true;
            this.txtMovieDesc.Name = "txtMovieDesc";
            this.txtMovieDesc.Size = new System.Drawing.Size(152, 25);
            this.txtMovieDesc.TabIndex = 46;
            // 
            // lblMovieYearLimit
            // 
            this.lblMovieYearLimit.AutoSize = true;
            this.lblMovieYearLimit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYearLimit.Location = new System.Drawing.Point(561, 223);
            this.lblMovieYearLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieYearLimit.Name = "lblMovieYearLimit";
            this.lblMovieYearLimit.Size = new System.Drawing.Size(131, 22);
            this.lblMovieYearLimit.TabIndex = 41;
            this.lblMovieYearLimit.Text = "Giới Hạn Tuổi:";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenre.Location = new System.Drawing.Point(30, 109);
            this.lblMovieGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(82, 22);
            this.lblMovieGenre.TabIndex = 40;
            this.lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieCountry
            // 
            this.lblMovieCountry.AutoSize = true;
            this.lblMovieCountry.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieCountry.Location = new System.Drawing.Point(561, 132);
            this.lblMovieCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieCountry.Name = "lblMovieCountry";
            this.lblMovieCountry.Size = new System.Drawing.Size(94, 22);
            this.lblMovieCountry.TabIndex = 38;
            this.lblMovieCountry.Text = "Quốc Gia:";
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.AutoSize = true;
            this.lblMovieDesc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDesc.Location = new System.Drawing.Point(30, 79);
            this.lblMovieDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(64, 22);
            this.lblMovieDesc.TabIndex = 37;
            this.lblMovieDesc.Text = "Mô tả:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(125, 50);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(152, 26);
            this.txtMovieName.TabIndex = 51;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(30, 50);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(92, 22);
            this.lblMovieName.TabIndex = 36;
            this.lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.Location = new System.Drawing.Point(125, 19);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(152, 26);
            this.txtMovieID.TabIndex = 45;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(30, 19);
            this.lblMovieID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(88, 22);
            this.lblMovieID.TabIndex = 43;
            this.lblMovieID.Text = "Mã phim:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvMovie);
            this.panel1.Controls.Add(this.panel47);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 611);
            this.panel1.TabIndex = 13;
            // 
            // dtgvMovie
            // 
            this.dtgvMovie.AllowUserToAddRows = false;
            this.dtgvMovie.AllowUserToDeleteRows = false;
            this.dtgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMovie.Location = new System.Drawing.Point(0, 302);
            this.dtgvMovie.Name = "dtgvMovie";
            this.dtgvMovie.ReadOnly = true;
            this.dtgvMovie.RowHeadersWidth = 51;
            this.dtgvMovie.Size = new System.Drawing.Size(994, 309);
            this.dtgvMovie.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.numericUpDownPhim);
            this.panel2.Controls.Add(this.clbMovieGenre);
            this.panel2.Controls.Add(this.txtMovieDesc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMovieGenre);
            this.panel2.Controls.Add(this.lblMovieDesc);
            this.panel2.Controls.Add(this.txtMovieYearLimit);
            this.panel2.Controls.Add(this.txtMovieName);
            this.panel2.Controls.Add(this.lblMovieYearLimit);
            this.panel2.Controls.Add(this.lblMovieName);
            this.panel2.Controls.Add(this.lblMovieCountry);
            this.panel2.Controls.Add(this.txtMovieID);
            this.panel2.Controls.Add(this.dtmMovieEnd);
            this.panel2.Controls.Add(this.lblMovieID);
            this.panel2.Controls.Add(this.lblMovieActor);
            this.panel2.Controls.Add(this.txtMovieLength);
            this.panel2.Controls.Add(this.dtmMovieStart);
            this.panel2.Controls.Add(this.lblMovieEndDate);
            this.panel2.Controls.Add(this.lblMovieLength);
            this.panel2.Controls.Add(this.txtMovieCountry);
            this.panel2.Controls.Add(this.txtMovieActor);
            this.panel2.Controls.Add(this.lblMovieStartDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 250);
            this.panel2.TabIndex = 0;
            // 
            // lblMovieActor
            // 
            this.lblMovieActor.AutoSize = true;
            this.lblMovieActor.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieActor.Location = new System.Drawing.Point(561, 163);
            this.lblMovieActor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieActor.Name = "lblMovieActor";
            this.lblMovieActor.Size = new System.Drawing.Size(92, 22);
            this.lblMovieActor.TabIndex = 39;
            this.lblMovieActor.Text = "Đạo Diễn:";
            // 
            // MovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovieUC";
            this.Size = new System.Drawing.Size(994, 611);
            this.panel47.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhim)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.NumericUpDown numericUpDownPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbMovieGenre;
        private System.Windows.Forms.DateTimePicker dtmMovieEnd;
        private System.Windows.Forms.DateTimePicker dtmMovieStart;
        private System.Windows.Forms.TextBox txtMovieYearLimit;
        private System.Windows.Forms.TextBox txtMovieActor;
        private System.Windows.Forms.TextBox txtMovieCountry;
        private System.Windows.Forms.TextBox txtMovieLength;
        private System.Windows.Forms.Label lblMovieEndDate;
        private System.Windows.Forms.Label lblMovieStartDate;
        private System.Windows.Forms.Label lblMovieLength;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtMovieDesc;
        private System.Windows.Forms.Label lblMovieYearLimit;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMovieCountry;
        private System.Windows.Forms.Label lblMovieDesc;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvMovie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMovieActor;
        private Guna.UI2.WinForms.Guna2Button UpdateMovie;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMovie;
        private Guna.UI2.WinForms.Guna2Button btnAddMovie;
    }
}
