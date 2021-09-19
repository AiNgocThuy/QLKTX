using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_KTX.DTO;

namespace QuanLy_KTX.DAO
{
    public class Khu_DAO
    {
        private static Khu_DAO instance;

        public static Khu_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Khu_DAO();
                return Khu_DAO.instance;
            }

            set
            {
                Khu_DAO.instance = value;
            }
        }

        private Khu_DAO() { }

        public List<Khu_DTO> getKHU(string makhu)
        {
            List<Khu_DTO> khuList = new List<Khu_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT * FROM dbo.KHU WHERE MAKHU = '" + makhu + "'");
            foreach (DataRow item in data.Rows)
            {
                Khu_DTO kh = new Khu_DTO(item);
                khuList.Add(kh);
            }
            return khuList;
        }
    }
}