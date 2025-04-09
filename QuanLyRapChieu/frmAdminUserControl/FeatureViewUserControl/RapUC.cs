using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    public partial class RapUC : UserControl
    {
        BindingSource _src = new BindingSource();
        public RapUC()
        {
            InitializeComponent();
        }

        //private void RapUC_Load(object sender, EventArgs e)
        //{
        //    dtgvRap.DataSource = _src;
        //    LoadGrid();
        //}

        //private void LoadGrid()
        //{
        //    RapBUS.Instance.hienThiRapPhim(_src);
        //    AddBinding();
        //}

        private void AddBinding()
        {
            txtMaRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
            txtTenRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "TenRap", true, DataSourceUpdateMode.Never));
        }

        

        //private void btnInsertRap_Click(object sender, EventArgs e)
        //{
        //    string maRap = txtMaRap.Text;
        //    string tenRap = txtTenRap.Text;
        //    RapBUS.Instance.themRap(maRap, tenRap);
        //    RapBUS.Instance.hienThiRapPhim(_src);
        //}

        //private void btnDeleteRap_Click(object sender, EventArgs e)
        //{
        //    string maRap = dtgvRap.SelectedCells[0].OwningRow.Cells["MaRap"].Value.ToString();
        //    RapBUS.Instance.xoaRap(maRap);
        //    RapBUS.Instance.hienThiRapPhim(_src);
        //}

        //private void btnUpdateRap_Click(object sender, EventArgs e)
        //{
        //    string maRap = dtgvRap.SelectedCells[0].OwningRow.Cells["MaRap"].Value.ToString();
        //    string tenRap = txtTenRap.Text;
        //    RapBUS.Instance.suaRap(maRap, tenRap);
        //    RapBUS.Instance.hienThiRapPhim(_src);
        //}
    }
}
