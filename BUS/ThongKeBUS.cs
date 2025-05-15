// ThongKeBLL.cs (trong thư mục BLL)
using DAO;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using DTO;

namespace BUS
{
    public class ThongKeBUS
    {
        private ThongKeDAO thongKeDAO = ThongKeDAO.Instance;

        public List<ThongKeDTO> GetRevenueData(string idMovie, DateTime fromDate, DateTime toDate)
        {
            List<ThongKeDTO> revenueList = new List<ThongKeDTO>();
            DataTable dataTable = thongKeDAO.GetRevenue(idMovie, fromDate, toDate);

            foreach (DataRow row in dataTable.Rows)
            {
                revenueList.Add(new ThongKeDTO
                {
                    TenPhim = row["Tên phim"].ToString(),
                    NgayChieu = Convert.ToDateTime(row["Ngày chiếu"]),
                    GioChieu = TimeSpan.Parse(row["Giờ chiếu"].ToString()),
                    SoVeDaBan = Convert.ToInt32(row["Số vé đã bán"]),
                    TienVe = Convert.ToDecimal(row["Tiền vé"])
                });
            }

            return revenueList;
        }

        public byte[] ExportToExcel(List<ThongKeDTO> reports)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Revenue Report");
                worksheet.Cell(1, 1).Value = "Báo cáo Doanh thu";
                worksheet.Cell(1, 1).Style.Font.Bold = true;
                worksheet.Cell(1, 1).Style.Font.FontSize = 16;

                // Tiêu đề cột
                worksheet.Cell(3, 1).Value = "Tên phim";
                worksheet.Cell(3, 2).Value = "Ngày chiếu";
                worksheet.Cell(3, 3).Value = "Giờ chiếu";
                worksheet.Cell(3, 4).Value = "Số vé đã bán";
                worksheet.Cell(3, 5).Value = "Tiền vé (VNĐ)";
                worksheet.Range(3, 1, 3, 5).Style.Font.Bold = true;

                // Dữ liệu
                for (int i = 0; i < reports.Count; i++)
                {
                    var row = i + 4;
                    worksheet.Cell(row, 1).Value = reports[i].TenPhim;
                    worksheet.Cell(row, 2).Value = reports[i].NgayChieu.ToString("dd/MM/yyyy");
                    worksheet.Cell(row, 3).Value = reports[i].GioChieu.ToString(@"hh\:mm");
                    worksheet.Cell(row, 4).Value = reports[i].SoVeDaBan;
                    worksheet.Cell(row, 5).Value = reports[i].TienVe;
                }

                // Tổng doanh thu
                decimal totalRevenue = reports.Sum(r => r.TienVe);
                worksheet.Cell(reports.Count + 5, 4).Value = "Tổng doanh thu:";
                worksheet.Cell(reports.Count + 5, 5).Value = totalRevenue;
                worksheet.Range(reports.Count + 5, 4, reports.Count + 5, 5).Style.Font.Bold = true;

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }

        public byte[] ExportToPDF(List<ThongKeDTO> reports)
        {
            using (var stream = new MemoryStream())
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, stream);
                document.Open();

                document.Add(new Paragraph("Báo cáo Doanh thu", FontFactory.GetFont("Arial", 16, Font.BOLD)));
                document.Add(new Paragraph(" "));

                PdfPTable table = new PdfPTable(5);
                table.AddCell("Tên phim");
                table.AddCell("Ngày chiếu");
                table.AddCell("Giờ chiếu");
                table.AddCell("Số vé đã bán");
                table.AddCell("Tiền vé (VNĐ)");

                foreach (var report in reports)
                {
                    table.AddCell(report.TenPhim);
                    table.AddCell(report.NgayChieu.ToString("dd/MM/yyyy"));
                    table.AddCell(report.GioChieu.ToString(@"hh\:mm"));
                    table.AddCell(report.SoVeDaBan.ToString());
                    table.AddCell(report.TienVe.ToString("N0"));
                }

                document.Add(table);

                decimal totalRevenue = reports.Sum(r => r.TienVe);
                document.Add(new Paragraph($"Tổng doanh thu: {totalRevenue:N0} VNĐ", FontFactory.GetFont("Arial", 12, Font.BOLD)));

                document.Close();
                return stream.ToArray();
            }
        }
    }
}