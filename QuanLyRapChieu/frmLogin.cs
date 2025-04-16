using BUS;
using DTO;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text; //user qly: admin, nvien: NV02
            string password = txtPassword.Text; //pass ply: admin, nvien: admin

            TaiKhoan taiKhoan = TaiKhoanBUS.Instance.xuLyDangNhap(userName, password);

            if (taiKhoan != null)
            {
                // Đăng nhập thành công
                //frmDashboard dashboard = new frmDashboard(taiKhoan);
                //this.Hide();
                //dashboard.ShowDialog();
                //this.Show();

                // Xóa thông tin đăng nhập sau khi đóng Dashboard
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
               
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Có thể xóa mật khẩu để người dùng gõ lại
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}

