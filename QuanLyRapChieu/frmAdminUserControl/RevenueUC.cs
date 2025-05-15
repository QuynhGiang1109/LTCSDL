using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BUS;
using DAO;
using System.IO;
using DTO;

namespace QuanLyRapChieu.frmAdminUserControl
{
    public partial class RevenueUC : UserControl
    {
        private ThongKeBUS thongKeBLL = new ThongKeBUS();
        BindingSource thongkeList = new BindingSource();

        public RevenueUC()
        {
            InitializeComponent(); //mo lai trong frmAdmin
            LoadRevenue();
            // Thêm điều khiển nếu chưa có
            if (cboExportFormat.Items.Count == 0)
            {
                cboExportFormat.Items.AddRange(new string[] { "Excel", "PDF" });
                cboExportFormat.SelectedIndex = 0;
            }
            if (btnExportReport.Text == "")
            {
                btnExportReport.Text = "Xuất Báo Cáo";
            }
        }

        void LoadRevenue()
        {
            LoadMovieIntoCombobox(cboSelectMovie);
            LoadDateTimePickerRevenue();
            LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }

        void LoadMovieIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = PhimDAO.Instance.hienThiPhim();
            comboBox.DisplayMember = "TenPhim";
            comboBox.ValueMember = "MaPhim";
        }

        void LoadDateTimePickerRevenue()
        {
            dtmFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtmToDate.Value = dtmFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dtgvRevenue.DataSource = ThongKeDAO.Instance.GetRevenue(idMovie, fromDate, toDate);
            txtDoanhThu.Text = GetSumRevenue().ToString("N3");
        }

        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value ?? 0);
            }
            return sum;
        }

        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            string idMovie = cboSelectMovie.SelectedValue?.ToString() ?? "";
            DateTime fromDate = dtmFromDate.Value;
            DateTime toDate = dtmToDate.Value;
            string format = cboExportFormat.SelectedItem?.ToString() ?? "Excel";

            List<ThongKeDTO> reports = thongKeBLL.GetRevenueData(idMovie, fromDate, toDate);

            if (reports.Any())
            {
                byte[] fileBytes;
                string fileName = $"RevenueReport_{DateTime.Now:yyyyMMddHHmmss}";
                string contentType;

                if (format == "Excel")
                {
                    fileBytes = thongKeBLL.ExportToExcel(reports);
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    fileName += ".xlsx";
                }
                else // PDF
                {
                    fileBytes = thongKeBLL.ExportToPDF(reports);
                    contentType = "application/pdf";
                    fileName += ".pdf";
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = fileName,
                    Filter = format == "Excel" ? "Excel Files|*.xlsx" : "PDF Files|*.pdf",
                    Title = "Lưu báo cáo"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, fileBytes);
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}