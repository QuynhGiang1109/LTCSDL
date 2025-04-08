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
        const int Y = 110;
        public FeatureViewUC()
        {
            InitializeComponent();
            //SidePanel.Hide();
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {

        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            GenreUC genreUC = new GenreUC();
            pnData.Controls.Clear();
            pnData.Controls.Add(genreUC);
        }
    }
}
