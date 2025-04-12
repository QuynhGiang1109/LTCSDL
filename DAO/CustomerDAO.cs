using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { 
                if (instance == null) 
                    instance = new CustomerDAO(); // nếu chưa có thì tạo mới
                return CustomerDAO.instance; // trả về instance đã tạo
            }
            private set { CustomerDAO.instance = value; } //Không cho bên ngoài gán lại
        }

        public DataTable ReadAllCustomer() //lấy toàn bộ danh sách khách hàng từ database
                                           //bằng cách gọi stored procedure (thủ tục lưu trữ)
        {
            String query = @"USP_layTatCaKhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return dt;
        }

        public bool addCustomerDAO(String name, int birth, String phoneNumber, int point, String address)
        {

            String query = "dbo.USP_themKhachHang @TenKhachHang ,  @DiaChi , @NamSinh , @SoDienThoai ,  @Diem ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, address, birth, phoneNumber, point });
                return true;
            }
            catch
            {
                return false;
            }

        }


    }
}
