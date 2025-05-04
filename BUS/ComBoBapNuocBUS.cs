using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
