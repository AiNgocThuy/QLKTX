using QuanLy_KTX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DAO
{
    class NhanVien_DAO
    {
        private static NhanVien_DAO instance;

        public static NhanVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVien_DAO();
                return NhanVien_DAO.instance;
            }

            set
            {
                NhanVien_DAO.instance = value;
            }
        }

        private NhanVien_DAO() { }
        public List<NhanVien_DTO> NhanVien_DTO()
        {
            List<NhanVien_DTO> nhanvienList = new List<NhanVien_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT MANV,MAKHU, HONV+' '+TENNV AS HOTENNV,CASE WHEN GTNV = 1 THEN N'Nam' ELSE N'Nữ' END AS[GTNV], NHANVIEN.MACV, TENCV, CHUCNANG,SDTNV FROM dbo.NHANVIEN JOIN dbo.CHUCVU ON CHUCVU.MACV = NHANVIEN.MACV");
            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO ph = new NhanVien_DTO(item);
                nhanvienList.Add(ph);
            }
            return nhanvienList;
        }

        public bool insertNhanVien(string manv, string honv, string tennv, bool gtnv, string makhu, string macv, string sdtnv)    //PROC thêm
        {
            string query = string.Format("USP_addNhanVien '{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}'", new object[] { manv, honv, tennv, gtnv, makhu, macv, sdtnv });
            int result = DataBase.Instance.executeNonQuery(query);
            return result > 0;
        }
        public bool deleteNhanVien(string manv) // xóa
        {
            int result = DataBase.Instance.executeNonQuery(" DELETE dbo.NHANVIEN WHERE MANV ='" + manv + "'");
            return result > 0;
        }
        public bool updateNhanVien(string manv, string honv, string tennv, bool gtnv, string makhu, string macv, string sdtnv)    //PROC thêm
        {
            string query = string.Format("USP_updateNhanVien '{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}'", new object[] { manv, honv, tennv, gtnv, makhu, macv, sdtnv });
            int result = DataBase.Instance.executeNonQuery(query);
            return result > 0;
        }


        public List<NhanVien_DTO> getNV(string manv)
        {
            List<NhanVien_DTO> ttNVList = new List<NhanVien_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT MANV,MAKHU, HONV+' '+TENCV AS HOTENNV, CASE WHEN GTNV = 1 THEN N'Nam' ELSE N'Nữ' END AS [GTNV] ,CHUCVU.MACV, TENCV, SDTNV FROM dbo.NHANVIEN JOIN dbo.CHUCVU ON CHUCVU.MACV = NHANVIEN.MACV WHERE MANV = '" + manv + "'");

            foreach (DataRow item in data.Rows)
            {
                NhanVien_DTO nv = new NhanVien_DTO(item);
                ttNVList.Add(nv);
            }
            return ttNVList;
        }
    }
}