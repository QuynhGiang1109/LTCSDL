using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieu
{
    public partial class frmPayment : Form
    {

        private decimal tienTong;

        public frmPayment()
        {
            InitializeComponent();
        }

        private frmPopcorn_Drinks previousForm;


        public frmPayment(decimal tienTongTruyenVao, frmPopcorn_Drinks prevForm) : this() // Gọi constructor mặc định
        {

            var culture = System.Globalization.CultureInfo.InvariantCulture;
            tienTong = tienTongTruyenVao;
            previousForm = prevForm;
            txtTongTien.Text = tienTong.ToString("N3", culture);
            
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show(); // Hiện lại frmPopcorn_Drinks
            }
            this.Close(); // Đóng frmPayment
        }
    }
}
