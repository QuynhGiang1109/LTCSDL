using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ComBoBapNuocDAO
    {
        private static ComBoBapNuocDAO instance;
        public static ComBoBapNuocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ComBoBapNuocDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<ComBoBapNuoc> LayDanhSachCombo()
        {
            List<ComBoBapNuoc> list = new List<ComBoBapNuoc>();
            string query = "SELECT * FROM ComboBapNuoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new ComBoBapNuoc(row));
            }
            return list;
        }

    }
}
