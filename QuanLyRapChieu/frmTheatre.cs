using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Mot so thay doi:
 txtPayment -> txtRefund

 */
namespace QuanLyRapChieu
{
    public partial class frmTheatre : Form
    {
        //private string maCaChieu;
        //private static List<Ve> maVe = new List<Ve>();
        //private static float totalPrice = 0;
        //private static float finalPrice = 0;
        //private static int bonus = 0;
        private int tongTien = 0;
        //private List<List<int>> loaiVe = new List<List<int>>();

        //public frmTheatre(string maCaChieu)
        //{          
        //    //this.maCaChieu = maCaChieu;
        //}

        public frmTheatre()
        {
            InitializeComponent();
            if (_instance == null)
            {
                _instance = this;
            }
        }

        private static frmTheatre _instance;
        public static frmTheatre Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new frmTheatre();
                return _instance;
            }
        }

        public int TongTien { get => tongTien; set => tongTien = value; }
        public static frmTheatre Instance1 { get => _instance; set => _instance = value; }

        private void txtDiscount_Click(object sender, EventArgs e)
        {

        }
        private void flpSeat_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmTheatre_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với rạp chiếu phim OMG!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData(); // Gọi hàm tải dữ liệu

        }

        //private void hienThiThongTinCaChieu(string maCaChieu)
        //{
        //    ChiTietCaChieu ct = CaChieuBUS.Instance.LayChiTietCaChieu(maCaChieu);
        //    if (ct == null)
        //        return;
        //    lblInformation.Text = string.Format("Ca chiếu : {0}, Phim : {1}, Phòng : {2}, Rạp : {3} ", ct.MaCaChieu, ct.TenPhim, ct.TenPhong, ct.TenRap);
        //    lblTime.Text = string.Format("Từ Giờ : {0:HH:mm}, đến Giờ : {1:HH:mm} ", ct.ThoiGianChieu, ct.ThoiGianKetThuc);
        //}
        private void LoadData()
        {
            // Code để tải danh sách phim, suất chiếu, ghế ngồi, v.v.
            hienThiDanhSachChoNgoiTheoMaCaChieu(10, 10);
            //hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            //hienThiThongTinCaChieu(maCaChieu);
        }
        public void hienThiDanhSachChoNgoiTheoMaCaChieu(int rows, int cols)
        {
            flpSeat.Controls.Clear(); // Xóa ghế cũ
            flpSeat.FlowDirection = FlowDirection.TopDown; // Sắp xếp từng hàng từ trên xuống
            flpSeat.WrapContents = false; // Ngăn ghế tự động xuống dòng sai quy tắc
            flpSeat.AutoScroll = true;
            flpSeat.AutoSize = false; //change size
            flpSeat.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            for (int i = 0; i < rows; i++)
            {
                char rowLabel = (char)('A' + i); // Chữ cái hàng ghế (A, B, C...)

                // Tạo một FlowLayoutPanel riêng cho từng hàng
                FlowLayoutPanel rowPanel = new FlowLayoutPanel();
                rowPanel.FlowDirection = FlowDirection.LeftToRight; // Ghế sắp xếp từ trái qua phải
                rowPanel.WrapContents = false;
                rowPanel.AutoSize = true;
                rowPanel.Margin = new Padding(0, 5, 0, 5); // Khoảng cách giữa các hàng

                for (int j = 0; j < cols; j++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Width = 80;
                    btnSeat.Height = 40;
                    btnSeat.Text = $"{rowLabel}{j + 1}"; // Ví dụ: A1, A2, ..., A10
                    btnSeat.Tag = false;
                    btnSeat.BackColor = Color.LightGray;
                    btnSeat.ForeColor = Color.Black;
                    btnSeat.Font = new Font("Montserrat", 9, FontStyle.Bold);
                    btnSeat.FlatStyle = FlatStyle.Flat;
                    btnSeat.FlatAppearance.BorderSize = 0;
                    btnSeat.Margin = new Padding(10);

                    // Bo tròn góc ghế
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    int radius = 15;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(btnSeat.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(btnSeat.Width - radius, btnSeat.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, btnSeat.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    btnSeat.Region = new Region(path);

                    btnSeat.Click += BtnSeat_Click;
                    rowPanel.Controls.Add(btnSeat); // Thêm ghế vào hàng ghế
                }

                flpSeat.Controls.Add(rowPanel); // Thêm hàng ghế vào flpSeat
            }
        }

        // Xử lý khi click vào ghế: Đổi màu ghế + Ktra loại vé + Tinh gia ve
        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Color mauGheDangChon = Color.CornflowerBlue;
            Color mauGheTrong = Color.LightGray;

            //nhay vao database de lay gia ve


            int giaVeNguoiLon = 100000;
            int giaVeTreEm = 60000;


            Button btn = sender as Button;
            if (btn != null)
            {
                bool isSelected = (bool)btn.Tag;
                btn.Tag = !isSelected;
                if ((bool)(btn.Tag)) //ghe dang chon
                {
                    btn.BackColor = mauGheDangChon;
                    tongTien += giaVeNguoiLon;
                }
                else//ghe dang trong
                {
                    btn.BackColor = mauGheTrong;
                    tongTien -= giaVeNguoiLon;
                    tongTien = tongTien < 0 ? 0 : tongTien;//dam bao tong tien khong the am
                }
            }

            //    Button btn = (sender as Button);
            //    Ve ve = (btn.Tag as Ve);

            //    if (ve.LoaiVe != 0)
            //    {
            //        ve.LoaiVe = 0;
            //    }
            //    else
            //    {
            //        if (rdoAdult.Checked)
            //        {
            //            ve.LoaiVe = 1;
            //            ve.TienBanVe = 1 * getSingleTicketPrice(this.maCaChieu);
            //        }
            //        else if (rdoChild.Checked)
            //        {
            //            ve.LoaiVe = 2;
            //            ve.TienBanVe = 0.5f * getSingleTicketPrice(this.maCaChieu);
            //        }
            //        else if (rdoStudent.Checked)
            //        {
            //            ve.LoaiVe = 3;
            //            ve.TienBanVe = 0.75f * getSingleTicketPrice(this.maCaChieu);
            //        }
            //        else if (rdoFree.Checked)
            //        {
            //            ve.LoaiVe = 4;
            //            ve.TienBanVe = 0 * getSingleTicketPrice(this.maCaChieu);
            //        }

            //    }


            //hien thi tong tien
            txtTotal.Text = tongTien.ToString();

            //    txtTotal.Text = totalPrice.ToString() + " VNĐ";
            //    finalPrice = totalPrice;
            //    txtRefund.Text = finalPrice.ToString() + " VNĐ";
            //    numBonusPoint.Value = bonus;

            //}

            //// lấy giá của một vé theo ca chiếu
            //private float getSingleTicketPrice(string maCaChieu)
            //{
            //    return VeBUS.Instance.getPriceOfTicketBUS(maCaChieu);
            //}

            //// thanh toán
            //private void BtnNext_Click(object sender, EventArgs e)
            //{

            //    if (maVe.Count == 0)
            //    {
            //        MessageBox.Show("Vui lòng chọn vé");
            //        return;
            //    }

            //    if (VeBUS.Instance.updateListTicket(maVe))
            //    {
            //        MessageBox.Show("Đặt vé thành công");
            //        if (txtCustomerName.Text != "" || txtCustomerName.Text != null)
            //        {
            //            updatePoint(frmCustomer.phoneNumber.Trim(), Convert.ToInt32(numBonusPoint.Value));
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đặt vé thất bại");
            //    }

            //    totalPrice = 0;
            //    finalPrice = 0;
            //    bonus = 0;
            //    maVe.Clear();
            //    flpSeat.Controls.Clear();
            //    hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            //    resetPanels();
        }

        //XAC NHAN TRC KHI THOAT 
        private void frmTheatre_FormClosing(object sender, FormClosingEventArgs e)
        {
            //resetPanels();
            //maVe.Clear();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn không cho form đóng
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            //1. Events: Sau khi click Tiếp tục, vô hiệu hóa các ghế đã được mua
            List<string> selectedSeats = new List<string>(); // Lưu danh sách ghế đã chọn

            foreach (Control row in flpSeat.Controls)
            {
                if (row is FlowLayoutPanel rowPanel) // Duyệt qua từng hàng ghế
                {
                    foreach (Control seat in rowPanel.Controls)
                    {
                        if (seat is Button btnSeat && btnSeat.BackColor == Color.CornflowerBlue)
                        {
                            selectedSeats.Add(btnSeat.Text); // Thêm ghế vào danh sách
                            //btnSeat.BackColor = Color.Gray; // Chuyển màu xám (đã mua)
                            //btnSeat.Enabled = false; // Vô hiệu hóa ghế đã chọn
                            //btnSeat.Tag = null; // Reset trạng thái
                        }
                    }
                }
            }
            // Kiểm tra nếu có ghế nào được chọn
            if (selectedSeats.Count > 0)
            {
                string seatList = string.Join(", ", selectedSeats); // Ghép tên ghế lại
                MessageBox.Show($"Đặt vé thành công!\nVị trí ghế: {seatList}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //2. Tiep tuc qua Form order Combo bắp nước
            //frmComboCorn.Open();
            //frmBapNuoc frm = new frmBapNuoc();
            //frmBapNuoc.Instance;
            //frm.Show();//hien thi them cua so thu 2, cho phep nguoi dung quay ve trang chu
            //frm.ShowDialog(); //hien thi them cua so thu 2, khong cho phep nguoi dung quay ve trang chu
            //frmBapNuoc.Instance.Show();
            //this.Hide();
        }
        private bool CheckTicketDetails()
        {
            // Kiểm tra điều kiện cần thiết để thanh toán (ví dụ: ghế đã chọn, phương thức thanh toán hợp lệ)
            return true; // Giả sử đã hợp lệ
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (txtPoint.Text != "" && txtPoint.Text != null)
            //{
            //    CustomerBUS.Instance.rollbackPoint(Int32.Parse(txtPoint.Text), frmCustomer.phoneNumber);
            //}

            //flpSeat.Controls.Clear();
            //hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            //maVe.Clear();
            //totalPrice = 0;
            //finalPrice = 0;
            //bonus = 0;
            //resetPanels();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy vé không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Vé đã được hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void resetPanels()
        {
            txtTotal.ResetText();
            txtCustomerName.ResetText();
            txtPoint.ResetText();
            numBonusPoint.Value = numBonusPoint.Minimum;
            txtDiscount.ResetText();
            txtRefund.ResetText();
            btnUsePoint.Enabled = true;
        }

        //B1.KTRA IN4 KH VIP

        //public void loadDataCustomer()
        //{
        //    if (frmCustomer.phoneNumber != "")
        //    {
        //        DataTable customer = CustomerBUS.Instance.getCustomer(frmCustomer.phoneNumber.Trim());
        //        if (customer != null)
        //        {
        //            DataRow row = customer.Rows[0];
        //            txtCustomerName.Text = row["TenKhachHang"].ToString();
        //            txtPoint.Text = row["DiemTichLuy"].ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không tìm thấy khách hàng");
        //        }
        //    }
        //}

        //B2: Neu thuoc list KH VIP --> Show hop thoai frmCustomer
        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //frmCustomer frmCustomer = new frmCustomer(this);
            //frmCustomer.ShowDialog();
            if (chkCustomer.Checked)
            {
                MessageBox.Show("Khách hàng thành viên được giảm giá 10%!", "Ưu đãi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void updatePoint(string phoneNumber, int bonus) //*
        {

            //if (!CustomerBUS.Instance.updatePointBUS(phoneNumber, bonus))
            //{
            //    MessageBox.Show("Cập nhật điểm không thành công");
            //}
        }
        private void btnUsePoint_Click(object sender, EventArgs e) //*
        {
            //if (txtPoint.Text == "" || txtPoint.Text == null)
            //{
            //    MessageBox.Show("Vui lòng điền thông tin khách hàng");
            //    return;
            //}


            //if (CustomerBUS.Instance.usePointBUS(frmCustomer.phoneNumber))
            //{
            //    MessageBox.Show("Sử dụng vé thành công, nhân viên tiến hành đổi vé");
            //}
            //else
            //{
            //    Debug.WriteLine("result is false");
            //}

            int points = GetCustomerPoints();
            if (points > 0)
            {
                MessageBox.Show($"Bạn đã sử dụng {points} điểm để giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn không có điểm thưởng nào.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetCustomerPoints()
        {
            // Giả lập lấy điểm từ database hoặc hệ thống khách hàng
            return 100; // Giả sử khách có 100 điểm
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("Bạn đang nhập vào khu vực thông tin chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackColor = System.Drawing.Color.DarkSlateBlue;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            //txtCustomerName.Text = "Leave";
            btnNext.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
