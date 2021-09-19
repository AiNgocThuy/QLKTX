using QuanLy_KTX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DAO
{
    public class Khoa_DAO
    {
        private static Khoa_DAO instance;

        public static Khoa_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Khoa_DAO();
                return Khoa_DAO.instance;
            }

            set
            {
                Khoa_DAO.instance = value;
            }
        }

        private Khoa_DAO() { }

        public List<Khoa_DTO> getTENKHOA(string makhoa)
        {
            List<Khoa_DTO> tenkhoaList = new List<Khoa_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT MAKHOA, TENKHOA FROM dbo.KHOA WHERE MAKHOA = '" + makhoa + "'");

            foreach (DataRow item in data.Rows)
            {
                Khoa_DTO k = new Khoa_DTO(item);
                tenkhoaList.Add(k);
            }
            return tenkhoaList;
        }
    }
}