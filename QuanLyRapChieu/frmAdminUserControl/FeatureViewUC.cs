using QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl;
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
    public partial class FeatureViewUC : UserControl
    {
        public FeatureViewUC()
        {
            InitializeComponent();
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {
            //SidePanel.Height = btnShowTimesUC.Height;
            //SidePanel.Top = btnShowTimesUC.Top;
            pnData.Controls.Clear();
            ShowTimesUC showTimesUc = new ShowTimesUC();
            showTimesUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(showTimesUc);
        }
    }
}
