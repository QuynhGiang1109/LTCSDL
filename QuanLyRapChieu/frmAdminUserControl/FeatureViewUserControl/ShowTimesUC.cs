using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

using BUS;
using DTO;
using DAO;

namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    public partial class ShowTimesUC : UserControl
    {
        BindingSource showtimeList = new BindingSource();

        public ShowTimesUC()
        {
            InitializeComponent();
        }
        void LoadCaChieu()
        {
            CaChieuBUS.Instance.GetCaChieu(showtimeList);
            LoadmovieNameIntoComboBox();
            AddShowtimeBinding();

        }
        void ClearShowtimeBinding()
        {
            // Xóa các liên kết cũ trước khi thêm mới
            txtShowtimeID.DataBindings.Clear();
            dtmShowtimeDate.DataBindings.Clear();
            dateTimetimes.DataBindings.Clear();
            txtTicketPrice_Showtime.DataBindings.Clear();
            cboCinemaID_Showtime.DataBindings.Clear();
            cboRap.DataBindings.Clear();
        }

        //add Binding
        void AddShowtimeBinding()

        {
            ClearShowtimeBinding();

            txtShowtimeID.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "MaCaChieu", true, DataSourceUpdateMode.Never));
            dtmShowtimeDate.DataBindings.Add(new Binding("Value", dtgvShowtime.DataSource, "ThoiGianChieu", true, DataSourceUpdateMode.Never));
            dateTimetimes.DataBindings.Add(new Binding("Value", dtgvShowtime.DataSource, "ThoiGianKetThuc", true, DataSourceUpdateMode.Never));
            txtTicketPrice_Showtime.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "GiaVe", true, DataSourceUpdateMode.Never));
            cboCinemaID_Showtime.DataBindings.Add(new Binding("SelectedValue", dtgvShowtime.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            cboRap.DataBindings.Add(new Binding("SelectedValue", dtgvShowtime.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
        }
        void LoadmovieNameIntoComboBox()
        {
            cboMovieName_Showtime.DataSource = PhimDAO.GetPhim();
            cboMovieName_Showtime.DisplayMember = "MaPhim";
        }
        //Khi click 1 datarow thì các control bên phải hiển thị đầy đủ đúng t.tin datarow đang chọn
        private void dtgvShowtime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dtgvShowtime.Rows[e.RowIndex];

                // Cập nhật các control với thông tin từ dòng được chọn
                txtShowtimeID.Text = selectedRow.Cells["MaCaChieu"].Value.ToString(); // Mã lịch chiếu

                // Cập nhật tên phim
                string movieName = selectedRow.Cells["TenPhim"].Value.ToString();
                cboMovieName_Showtime.SelectedItem = movieName; // Chọn tên phim trong combo box
                txtMovieName_Showtime.Text = movieName; // Hiển thị tên phim

                // Cập nhật mã rạp
                string cinemaID = selectedRow.Cells["MaRap"].Value.ToString();
                cboCinemaID_Showtime.SelectedItem = cinemaID; // Chọn mã rạp trong combo box
                cboRap.SelectedItem = cinemaID; // Chọn rạp trong combo box

                // Cập nhật thời gian chiếu
                DateTime showtimeDateTime = DateTime.Parse(selectedRow.Cells["ThoiGianChieu"].Value.ToString());
                dtmShowtimeDate.Value = showtimeDateTime.Date; // Ngày chiếu
                dtmShowtimeTime.Value = showtimeDateTime; // Giờ chiếu

                // Cập nhật thời gian kết thúc
                DateTime endTime = DateTime.Parse(selectedRow.Cells["ThoiGianKetThuc"].Value.ToString());
                dateTimeDay.Value = endTime.Date; // Ngày kết thúc
                dateTimetimes.Value = endTime; // Giờ kết thúc

                // Cập nhật giá vé
                txtTicketPrice_Showtime.Text = selectedRow.Cells["GiaVe"].Value.ToString(); // Giá vé
            }
        }

        private void cboMovieName_Showtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovieName_Showtime.SelectedIndex != -1)
            {
                Phim MovieSelecting = (Phim)cboMovieName_Showtime.SelectedItem;
                txtMovieName_Showtime.Text = MovieSelecting.TenPhim;
                cboCinemaID_Showtime.DataSource = null;
                cboCinemaID_Showtime.DataSource = PhongChieuDAO.Instance.hienThiPhongChieu();
                cboCinemaID_Showtime.DisplayMember = "TenPhong";
                cboCinemaID_Showtime.ValueMember = "MaPhong";
                cboRap.DataSource = null;
                cboRap.DataSource = RapDAO.Instance.hienThiRapPhim();
                cboRap.DisplayMember = "TenRap";
                cboRap.ValueMember = "MaRap";
            }
        }

        private void btnInsertShowtime_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra dữ liệu đầu vào có đầy đủ không
            if (string.IsNullOrEmpty(txtShowtimeID.Text) || txtShowtimeID.Text == "0" || 
                string.IsNullOrEmpty(cboCinemaID_Showtime.Text) || 
                string.IsNullOrEmpty(cboRap.Text) || 
                string.IsNullOrEmpty(cboMovieName_Showtime.Text) || 
                dtmShowtimeDate == null || dateTimeDay == null )
                //txtTicketPrice_Showtime.Text <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn phim hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi phương thức
            }
            //lay dlieu dtgv
            string maCaChieu = txtShowtimeID.Text;
            string maPhongChieu = ((PhongChieu)cboCinemaID_Showtime.SelectedItem).MaPhong;
            string maRapChieu = (cboRap.SelectedItem as Rap).MaRap;
            string maPhim = ((Phim)cboMovieName_Showtime.SelectedItem).MaPhim;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            DateTime time2 = new DateTime(dateTimeDay.Value.Year, dateTimeDay.Value.Month, dateTimeDay.Value.Day, dateTimetimes.Value.Hour, dateTimetimes.Value.Minute, dateTimetimes.Value.Second);
            float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            
            int result = CaChieuBUS.Instance.themCaChieu(maCaChieu, time, time2, maPhongChieu, maPhim, ticketPrice, maRapChieu);

                if (result > 0)
                {
                    MessageBox.Show("Thêm ca chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Nếu thêm ca chiếu thành công, thì:
                    CaChieuBUS.Instance.GetCaChieu(showtimeList); // Load lại danh sách
                    LoadCaChieu();
                    ClearShowtimeBinding();
                }
                else
                {
                    MessageBox.Show("Thêm ca chiếu thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }

        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {
            //ktra xem đã chọn dòng xóa chưa?
            if (dtgvShowtime.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string showtimeID = txtShowtimeID.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ca chiếu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int kq = CaChieuBUS.Instance.xoaCaChieu(showtimeID);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa ca chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CaChieuBUS.Instance.GetCaChieu(showtimeList); // Cập nhật danh sách
                        LoadCaChieu(); // Cập nhật lại giao diện nếu cần
                    }
                    else
                    {
                        MessageBox.Show("Xóa ca chiếu thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa ca chiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnUpdateShowtime_Click(object sender, EventArgs e) //edited genreUC
        {
            //// Ktra xem có dòng nào được chọn chưa
            if (dtgvShowtime.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ca chiếu cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Lấy thông tin từ các control
                string maCaChieu = txtShowtimeID.Text;
                string maPhongChieu = ((PhongChieu)cboCinemaID_Showtime.SelectedItem).MaPhong;
                string maRapChieu = (cboRap.SelectedItem as Rap).MaRap;
                string maPhim = ((Phim)cboMovieName_Showtime.SelectedItem).MaPhim;
                DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
                DateTime time2 = new DateTime(dateTimeDay.Value.Year, dateTimeDay.Value.Month, dateTimeDay.Value.Day, dateTimetimes.Value.Hour, dateTimetimes.Value.Minute, dateTimetimes.Value.Second);
                float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);

                //// Ktra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maCaChieu) || string.IsNullOrEmpty(maPhongChieu) || string.IsNullOrEmpty(maRapChieu) || string.IsNullOrEmpty(maPhim))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //// confirm user
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin ca chiếu này?",
                                                        "Xác nhận cập nhật",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                
                if (confirm == DialogResult.Yes)
                {
                    
                        int result = CaChieuBUS.Instance.suaCaChieu(maCaChieu, time, time2, maPhongChieu, maPhim, ticketPrice, maRapChieu);

                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật ca chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CaChieuBUS.Instance.GetCaChieu(showtimeList);
                            LoadCaChieu();
                            ClearShowtimeBinding();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật ca chiếu thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
     
                    
            }
            catch (Exception ex)
            {

                 MessageBox.Show("Đã xảy ra lỗi khi cập nhật ca chiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void ShowTimesUC_Load(object sender, EventArgs e)
        {
            dtgvShowtime.DataSource = showtimeList;
            LoadCaChieu();
        }
    }
}
