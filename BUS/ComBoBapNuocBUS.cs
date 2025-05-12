using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.Windows.Forms;
>>>>>>> main
using static DTO.ComBoBapNuoc_Chon;

namespace BUS
{
    public class ComBoBapNuocBUS
    {
        private static ComBoBapNuocBUS instance;
        public static ComBoBapNuocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ComBoBapNuocBUS();
                return instance;
            }
            private set { instance = value; }
        }

        private ComBoBapNuocBUS() { }

        public List<ComBoBapNuoc> LayDanhSachCombo()
        {
            return ComBoBapNuocDAO.Instance.LayDanhSachCombo();
        }

        


        //public List<ComboChon> LayDanhSachComboChon()
        //{
        //    var danhSach = LayDanhSachCombo();
        //    return danhSach.Select(c => new ComboChon
        //    {
        //        MaCombo = c.MaCombo,
        //        TenCombo = c.TenCombo,
        //        Gia = c.Gia,
        //        SoLuong = 0
        //    }).ToList();
        //}

        public void HienThiDanhSachCombo(BindingSource source)
        {
            source.DataSource = ComBoBapNuocDAO.Instance.LayTatCaCombo();
        }

        public bool ThemCombo(string tenCombo, decimal gia)
        {
            return ComBoBapNuocDAO.Instance.ThemCombo(tenCombo, gia) > 0;
        }

        public bool XoaCombo(string maCombo)
        {
            return ComBoBapNuocDAO.Instance.XoaCombo(maCombo) > 0;
        }

        public bool SuaCombo(string maCombo, string tenCombo, decimal gia)
        {
            return ComBoBapNuocDAO.Instance.SuaCombo(maCombo, tenCombo, gia) > 0;
        }


    }
}
