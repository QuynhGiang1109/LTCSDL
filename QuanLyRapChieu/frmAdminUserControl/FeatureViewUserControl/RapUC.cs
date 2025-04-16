using System;
using System.Windows.Forms;
using BUS;

namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    public partial class RapUC : UserControl
    {
        BindingSource rapList = new BindingSource();

        public RapUC()
        {
            InitializeComponent();
        }

        private void RapUC_Load(object sender, EventArgs e)
        {
            dtgvRap.DataSource = rapList;
            LoadGrid();
        }

        private void LoadGrid()
        {
            RapBUS.Instance.hienThiRapPhim(rapList);
            dtgvRap.DataSource = rapList; // gán lại đảm bảo
            ClearAndAddBinding();
        }

        private void AddBinding()
        {
            txtMaRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
            txtTenRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "TenRap", true, DataSourceUpdateMode.Never));
        }

        private void ClearAndAddBinding()
        {
            txtMaRap.DataBindings.Clear();
            txtTenRap.DataBindings.Clear();

            txtMaRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
            txtTenRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "TenRap", true, DataSourceUpdateMode.Never));
        }


        private void btnInsertRap_Click(object sender, EventArgs e)
        {
            string maRap = txtMaRap.Text.Trim();
            string tenRap = txtTenRap.Text.Trim();

            if (string.IsNullOrEmpty(maRap) || string.IsNullOrEmpty(tenRap))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BUS để thêm rạp
            bool success = RapBUS.Instance.themRap(maRap, tenRap);

            if (success)
            {
                MessageBox.Show("Thêm rạp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm rạp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cập nhật lại danh sách hiển thị
            RapBUS.Instance.hienThiRapPhim(rapList);
            LoadGrid(); // reload data
        }

        private void btnDeleteRap_Click(object sender, EventArgs e)
        {
            if (dtgvRap.SelectedCells.Count > 0)
            {
                string maRap = dtgvRap.SelectedCells[0].OwningRow.Cells["MaRap"].Value.ToString();

                // Gọi BUS để xóa và kiểm tra kết quả
                bool success = RapBUS.Instance.xoaRap(maRap);

                if (success)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                RapBUS.Instance.hienThiRapPhim(rapList);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateRap_Click(object sender, EventArgs e)
        {
            string maRap = dtgvRap.SelectedCells[0].OwningRow.Cells["MaRap"].Value.ToString();
            string tenRap = txtTenRap.Text;

            if (maRap == "" || tenRap == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm sửa và kiểm tra kết quả
            bool success = RapBUS.Instance.suaRap(maRap, tenRap);

            if (success)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

            RapBUS.Instance.hienThiRapPhim(rapList);
            LoadGrid();
        }
    }
}
