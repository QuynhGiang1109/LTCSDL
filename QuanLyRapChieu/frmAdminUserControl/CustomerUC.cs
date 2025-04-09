using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieu.frmAdminUserControl
{
    public partial class CustomerUC : UserControl
    {
        public CustomerUC()
        {
            InitializeComponent();
            //LoadCustomer();
        }

        //void LoadCustomer()
        //{

        //    DataTable dt = CustomerBUS.Instance.getListCustomer();
        //    if (dt == null)
        //    {
        //        MessageBox.Show("Error when load data");
        //    }
        //    else
        //    {
        //        dtgvCustomer.DataSource = dt;
        //    }

        //}

        private void dtgvCustomer_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dtgvCustomer.SelectedRows)
            {
                txtCusId.Text = row.Cells[0].Value.ToString();
                txtCusName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                numericUpDownNamSinh.Text = row.Cells[3].Value.ToString();
                txtCusPhone.Text = row.Cells[4].Value.ToString();
                nudPoint.Value = (int)row.Cells[5].Value;
            }
        }
    }
}
