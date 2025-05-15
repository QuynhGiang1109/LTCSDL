using BUS;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder; // thêm ở đầu file
using System.Drawing;

namespace QuanLyRapChieu
{
    public partial class frmPayment : Form
    {

        private decimal tienTong;
        private decimal tienVe;
        private decimal tienCombo;
        private decimal diemDaDung;
        private List<string> selectedSeats;
        private frmPopcorn_Drinks previousForm;

        public frmPayment(decimal tienTong, decimal tienVe, decimal tienCombo, decimal diemDaDung, List<string> selectedSeats, frmPopcorn_Drinks prevForm)
        {
            InitializeComponent();
            this.tienTong = tienTong;
            this.tienVe = tienVe;
            this.tienCombo = tienCombo;
            this.diemDaDung = diemDaDung;
            this.selectedSeats = selectedSeats;
            this.previousForm = prevForm;

            // Hiển thị tổng tiền
            txtTongTien.Text = tienTong.ToString("N3", CultureInfo.InvariantCulture);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Tạo nội dung QR code
            string noiDungQR = $"Thanh toán vé phim\nTổng tiền: {tienTong:N0} VND\nTiền vé: {tienVe:N0}\nTiền combo: {tienCombo:N0}\nĐiểm đã dùng: {diemDaDung:N0}\nGhế: {(selectedSeats.Any() ? string.Join(", ", selectedSeats) : "Không có ghế")}";

            // Gọi hàm tạo QR
            GenerateQRCode(noiDungQR);

            // Hiện thông báo
            string thongBao = "Đặt vé thành công!\n\n";
            thongBao += $"💰 Tổng tiền: {tienTong.ToString("N3", CultureInfo.InvariantCulture)}\n";
            thongBao += $"💰 Tiền vé: {tienVe.ToString("N3", CultureInfo.InvariantCulture)}\n";
            thongBao += $"💰 Tiền combo: {tienCombo.ToString("N3", CultureInfo.InvariantCulture)}\n";
            thongBao += $"🎁 Điểm đã dùng: {diemDaDung.ToString("N0", CultureInfo.InvariantCulture)}\n";
            thongBao += "💺 Mã ghế: " + (selectedSeats.Any() ? string.Join(", ", selectedSeats) : "Không có ghế nào được chọn");

            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng form sau thanh toán
            if (previousForm != null)
            {
                if (previousForm.previousForm != null)
                {
                    previousForm.previousForm.Close();
                }
                previousForm.Close();
            }
            this.Close();

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }


        //Tạo QRCode


        public void GenerateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20); // số 20 là mức độ zoom

            picQRCode.Image = qrCodeImage; // Hiển thị lên PictureBox
        }




    }
}