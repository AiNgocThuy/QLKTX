using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DAO
{
    public class TaiKhoan_DAO
    {

        private static TaiKhoan_DAO instance;

        public static TaiKhoan_DAO Instance //Singleton
        {
            get
            {
                if (instance == null) instance = new TaiKhoan_DAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private TaiKhoan_DAO() { }
        public bool DangNhap(string taiKhoan, string matKhau)
        {
            String query = "SELECT*from dbo.TAIKHOAN Where TENTK=N'" + taiKhoan + "' and MATKHAU=N'" + matKhau + "'";

            DataTable result = DataBase.Instance.executeQuery(query, new object[] { taiKhoan, matKhau });
            return result.Rows.Count > 0;
        }
    }
}