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
using DTO;
using BUS;

/*Mot so thay doi:
 txtPayment -> txtRefund
 */
namespace QuanLyRapChieu
{
    public partial class frmTheatre : Form
    {
        private string maCaChieu;
        private static List<Ve> maVe = new List<Ve>();
        private static float totalPrice = 0;
        private static float finalPrice = 0;
        private static int bonus = 0;
        private int tongTien = 0;
        private List<List<int>> loaiVe = new List<List<int>>();

        public frmTheatre(string maCaChieu)
        {
            InitializeComponent();
            this.maCaChieu = maCaChieu;
        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(this);
            frmCustomer.ShowDialog();
        }

        public void hienThiDanhSachChoNgoiTheoMaCaChieu(string maCaChieu)
        {
            flpSeat.Controls.Clear();
            flpSeat.Visible = true;
            flpSeat.BringToFront();
            flpSeat.FlowDirection = FlowDirection.TopDown; // Sắp xếp từng hàng từ trên xuống
            flpSeat.AutoSize = false;
            flpSeat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpSeat.WrapContents = false;

            int count = 0;
            List<Ve> danhSachVe = VeBUS.Instance.hienthiVe(maCaChieu);

            if (danhSachVe != null)
            {
                // Tạo các hàng ghế
                for (int i = 0; i < danhSachVe.Count; i++)
                {
                    // Tính toán hàng và cột từ chỉ số
                    int row = i / 10; // Xác định hàng, mỗi hàng có 10 ghế
                    int col = i % 10; // Xác định cột (1-10)

                    // Đặt tên hàng (A, B, C,...)
                    char rowLabel = (char)('A' + row);

                    // Tạo Button cho ghế
                    Button btn = new Button() { Width = 80, Height = 30 };
                    btn.Text = $"{rowLabel}{col + 1}"; // Ghế có dạng A1, A2, ..., A10, B1, B2, ...
                    btn.Font = new Font("Arial", 10.5f);
                    btn.Click += btnSeat_Click;
                    btn.Tag = danhSachVe[i];

                    // Thiết lập màu sắc ghế
                    Ve ve = danhSachVe[i];
                    if (ve.TrangThai == 0) // Ghế có thể chọn
                    {
                        btn.BackColor = Color.LightGray; //ghế trống 
                    }
                    else // Ghế đã có người ngồi (đã đặt)
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray; //ghế được đặt: xám đậm
                        btn.ForeColor = Color.White;
                    }

                    // Tạo một FlowLayoutPanel cho mỗi hàng
                    if (col == 0) // Nếu là cột đầu tiên (tạo panel mới cho mỗi hàng)
                    {
                        FlowLayoutPanel rowPanel = new FlowLayoutPanel();
                        rowPanel.FlowDirection = FlowDirection.LeftToRight;
                        rowPanel.WrapContents = false;
                        rowPanel.AutoSize = true;
                        rowPanel.Margin = new Padding(0, 5, 0, 5);

                        // Thêm ghế vào hàng hiện tại
                        rowPanel.Controls.Add(btn);

                        // Thêm hàng vào flpSeat
                        flpSeat.Controls.Add(rowPanel);
                    }
                    else
                    {
                        // Nếu không phải cột đầu tiên, thêm ghế vào hàng hiện tại
                        ((FlowLayoutPanel)flpSeat.Controls[flpSeat.Controls.Count - 1]).Controls.Add(btn);
                    }
                    count++;
                }
            }

        }

        // Xử lý khi click vào ghế: Đổi màu ghế + Ktra loại vé + Tinh gia ve
        private void btnSeat_Click(object sender, EventArgs e)
        {
            Color mauGheDangChon = Color.CornflowerBlue;
            Color mauGheTrong = Color.LightGray;

            Button btn = (sender as Button);
            Ve ve = (btn.Tag as Ve);


            if (ve.LoaiVe != 0)
            {
                ve.LoaiVe = 0;
            }
            else
            {
                if (rdoAdult.Checked)
                {
                    ve.LoaiVe = 1;
                    ve.TienBanVe = 1 * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoChild.Checked)
                {
                    ve.LoaiVe = 2;
                    ve.TienBanVe = 0.5f * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoStudent.Checked)
                {
                    ve.LoaiVe = 3;
                    ve.TienBanVe = 0.75f * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoFree.Checked)
                {
                    ve.LoaiVe = 4;
                    ve.TienBanVe = 0 * getSingleTicketPrice(this.maCaChieu);
                }

            }

            if (btn.BackColor == mauGheDangChon) //neu ghe dang duoc chon
            {
                btn.BackColor = mauGheTrong; //tra lai ghe trang thai mau ghe trong
                maVe.Remove(ve);//chuyen lai mau ghe trong
                totalPrice -= ve.TienBanVe; //xoa ve khoi dsach da chon
                bonus--; //giam tong tien do bỏ chọn ghế
            }
            else //neu ghe chua duoc chon
            {
                btn.BackColor = mauGheDangChon;  //tra lai ghe trang thai GHE DANG CHON
                maVe.Add(ve);
                totalPrice += ve.TienBanVe;
                bonus++;
            }
            // Cập nhật giá vé vào giao diện người dùng (ví dụ: cập nhật vào một TextBox)
            txtTotal.Text = totalPrice.ToString("C");
        }



        // lấy giá của một vé theo ca chiếu
        private float getSingleTicketPrice(string maCaChieu)
        {
            return VeBUS.Instance.getPriceOfTicketBUS(maCaChieu);
        }

        // chưa có btn THANH TOÁN -> btnNext :private void btnPayment_Click(object sender, EventArgs e)


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtPoint.Text != "" && txtPoint.Text != null)
            {
                CustomerBUS.Instance.rollbackPoint(Int32.Parse(txtPoint.Text), frmCustomer.phoneNumber);
            }

            flpSeat.Controls.Clear();
            hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            maVe.Clear();
            totalPrice = 0;
            finalPrice = 0;
            bonus = 0;
            resetPanels();

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


        public void loadDataCustomer()
        {
            if (frmCustomer.phoneNumber != "")
            {
                DataTable customer = CustomerBUS.Instance.getCustomer(frmCustomer.phoneNumber.Trim());
                if (customer != null)
                {
                    DataRow row = customer.Rows[0];
                    txtCustomerName.Text = row["TenKhachHang"].ToString();
                    txtPoint.Text = row["DiemTichLuy"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void frmTheatre_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetPanels();
            maVe.Clear();  
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn không cho form đóng
            }
        }

        private void updatePoint(string phoneNumber, int bonus)
        {

            if (!CustomerBUS.Instance.updatePointBUS(phoneNumber, bonus))
            {
                MessageBox.Show("Cập nhật điểm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUsePoint_Click(object sender, EventArgs e)
        {
            if (txtPoint.Text == "" || txtPoint.Text == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (CustomerBUS.Instance.usePointBUS(frmCustomer.phoneNumber))
            {
                MessageBox.Show("Sử dụng vé thành công! Nhân viên vui lòng tiến hành đổi vé cho khách.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Debug.WriteLine("Result is false");
                MessageBox.Show("Không thể sử dụng vé. Vui lòng kiểm tra lại thông tin khách hàng hoặc trạng thái điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void frmTheatre_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(flpSeat.Parent.Name); // Xem flpSeat nằm trong đâu
            hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            hienThiThongTinCaChieu(maCaChieu);
        }

        private void hienThiThongTinCaChieu(string maCaChieu)
        {
            ChiTietCaChieu ct = CaChieuBUS.Instance.LayChiTietCaChieu(maCaChieu);
            if (ct == null)
                return;
            lblInformation.Text = string.Format("Ca chiếu : {0}, Phim : {1}, Phòng : {2}, Rạp : {3} ", ct.MaCaChieu, ct.TenPhim, ct.TenPhong, ct.TenRap);
            lblTime.Text = string.Format("Từ Giờ : {0:HH:mm}, đến Giờ : {1:HH:mm} ", ct.ThoiGianChieu, ct.ThoiGianKetThuc);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
         
            if (maVe.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi tiếp tục thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (VeBUS.Instance.updateListTicket(maVe))
            {
                MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (!string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    updatePoint(frmCustomer.phoneNumber.Trim(), Convert.ToInt32(numBonusPoint.Value));
                }

                // ⭐ LẤY GIÁ TIỀN VÉ từ txtRefund và truyền sang frmPopcorn_Drinks ⭐






                //CHƯA FIX CHỖ NÀY
                decimal tienVe = decimal.Parse(txtRefund.Text.Replace(".", "").Replace(" đ", "").Trim());

                frmPopcorn_Drinks frm = new frmPopcorn_Drinks(tienVe);
                frm.Show();
                ///






                // Reset chỉ khi đặt vé thành công
                totalPrice = 0;
                finalPrice = 0;
                bonus = 0;
                maVe.Clear();
                flpSeat.Controls.Clear();
                hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
                resetPanels();
            }
            else
            {
                MessageBox.Show("Đặt vé thất bại. Vui lòng kiểm tra lại thông tin và thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Không reset để user còn sửa lại
            }
            
        }
    }
}
