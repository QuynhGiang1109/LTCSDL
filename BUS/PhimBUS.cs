using DAO;
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

public class PhimBUS
{
    private static PhimBUS instance;
    public static PhimBUS Instance
    {
        get { if (instance == null) instance = new PhimBUS(); return PhimBUS.instance; }
        private set { PhimBUS.instance = value; }
    }

    public void hienThiPhim(BindingSource source)
    {
        source.DataSource = PhimDAO.Instance.hienThiPhim();
    }

    public void hienThiPhimTheoNgay(ComboBox cbb, DateTime date)
    {
        List<Phim> danhSachPhim = PhimDAO.Instance.hienThiPhimTheoNgay(date);
        List<string> danhSachTenPhim = new List<string>();

        foreach (Phim tenPhim in danhSachPhim)
        {
            if (!danhSachTenPhim.Contains(tenPhim.TenPhim))
            {
                danhSachTenPhim.Add(tenPhim.TenPhim);
            }
        }

        cbb.DataSource = null;
        cbb.DataSource = danhSachTenPhim;
    }

    public bool suaDanhSachPhim(string MaPhim, string TenPhim, string MoTa, double ThoiLuong,
        DateTime NgayBatDau, DateTime NgayKetThuc, string QuocGia, string DienVien, int NamSX, int GioiHanTuoi)
    {
        return PhimDAO.Instance.suaDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau,
            NgayKetThuc, QuocGia, DienVien, NamSX, GioiHanTuoi) > 0;
    }

    public bool themDanhSachPhim(string MaPhim, string TenPhim, string MoTa, double ThoiLuong,
        DateTime NgayBatDau, DateTime NgayKetThuc, string QuocGia, string DienVien, int NamSX, int GioiHanTuoi)
    {
        return PhimDAO.Instance.themDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau,
            NgayKetThuc, QuocGia, DienVien, NamSX, GioiHanTuoi) > 0;
    }

    public bool xoaDanhSachPhim(string MaPhim)
    {
        return PhimDAO.Instance.xoaDanhSachPhim(MaPhim) > 0;
    }
}
