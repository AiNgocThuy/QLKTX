using QuanLy_KTX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DAO
{
    class Phong_DAO
    {
        private static Phong_DAO instance;

        public static Phong_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Phong_DAO();
                return Phong_DAO.instance;
            }

            private set
            {
                Phong_DAO.instance = value;
            }
        }

        public static int phongWidth = 150;
        public static int phongHeight = 150;

        private Phong_DAO() { }

        public DataTable getTS(string maphong)  //hiển thị TS trên listview, ko dùng DTO
        {
            return DataBase.Instance.executeQuery("SELECT PHONG.MAPHONG, TENTS, SOLUONGTS, DONGIATS, NGAYLAPDAT, NGAYSUA FROM PHONG JOIN TAISANPHONG ON TAISANPHONG.MAPHONG = PHONG.MAPHONG JOIN TAISAN ON TAISAN.MATS = TAISANPHONG.MATS WHERE dbo.TAISANPHONG.MAPHONG = '" + maphong + "'");
        }

        public List<Phong_DTO> getTTP(string maphong)   //hiển thị TTP trên textbox, dùng DTO
        {
            List<Phong_DTO> ttpList = new List<Phong_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT a.MAKHU,a.TINHTRANG,a.MAPHONG, a.SLTD, a.TIENPHONG, b.SONGUOIDANGO FROM (SELECT KHU.MAKHU, TINHTRANG, MAPHONG, SLTD, TIENPHONG FROM dbo.KHU RIGHT JOIN dbo.PHONG ON PHONG.MAKHU = KHU.MAKHU) AS a INNER JOIN (SELECT PHONG.MAPHONG, COUNT(MASV) AS 'SONGUOIDANGO' FROM dbo.PHONG LEFT JOIN dbo.SINHVIEN ON SINHVIEN.MAPHONG = PHONG.MAPHONG GROUP BY PHONG.MAPHONG) AS b ON a.MAPHONG = b.MAPHONG AND b.MAPHONG = '" + maphong + "'");

            foreach (DataRow item in data.Rows)
            {
                Phong_DTO ph = new Phong_DTO(item);
                ttpList.Add(ph);
            }
            return ttpList;
        }

        public List<Phong_DTO> Phong_DTO()  //sử dụng PROC Phòng (PROC nối Khu, Phòng, Sinh viên)
        {
            List<Phong_DTO> phongList = new List<Phong_DTO>();
            DataTable data = DataBase.Instance.executeQuery("USP_phong");
            foreach (DataRow item in data.Rows)
            {
                Phong_DTO ph = new Phong_DTO(item);
                phongList.Add(ph);
            }
            return phongList;
        }

        public List<Phong_DTO> phongTrong()  //sử dụng Query tìm phòng trống
        {
            List<Phong_DTO> phongTrongList = new List<Phong_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT b.MAKHU, b.TINHTRANG, a.MAPHONG, b.SLTD, b.TIENPHONG , a.SONGUOIDANGO FROM ( SELECT PHONG.MAPHONG, COUNT(MASV) AS 'SONGUOIDANGO' FROM dbo.PHONG LEFT JOIN dbo.SINHVIEN ON SINHVIEN.MAPHONG = PHONG.MAPHONG GROUP BY PHONG.MAPHONG ) AS a JOIN ( SELECT KHU.MAKHU, TINHTRANG, MAPHONG, SLTD, TIENPHONG  FROM dbo.PHONG LEFT JOIN dbo.KHU ON KHU.MAKHU = PHONG.MAKHU ) AS b ON b.MAPHONG = a.MAPHONG WHERE a.SONGUOIDANGO = 0");
            foreach (DataRow item in data.Rows)
            {
                Phong_DTO ph = new Phong_DTO(item);
                phongTrongList.Add(ph);
            }
            return phongTrongList;
        }

        public int tongSoPhong()
        {
            int tsp;
            return tsp = (int)DataBase.Instance.executeScalar("SELECT COUNT(*) FROM dbo.PHONG");
        }

        public int tongSoPhongTrong()
        {
            int tspt;
            return tspt = (int)DataBase.Instance.executeScalar("SELECT COUNT(a.SNDO) FROM ( SELECT COUNT(MASV) AS SNDO FROM dbo.SINHVIEN RIGHT JOIN dbo.PHONG ON PHONG.MAPHONG = SINHVIEN.MAPHONG GROUP BY PHONG.MAPHONG HAVING COUNT(MASV) = 0 ) AS a");
        }

        public List<Phong_DTO> phongCoSV()  //sử dụng Query tìm phòng trống
        {
            List<Phong_DTO> phongSVList = new List<Phong_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT b.MAKHU, b.TINHTRANG, a.MAPHONG, b.SLTD, b.TIENPHONG , a.SONGUOIDANGO FROM ( SELECT PHONG.MAPHONG, COUNT(MASV) AS 'SONGUOIDANGO' FROM dbo.PHONG LEFT JOIN dbo.SINHVIEN ON SINHVIEN.MAPHONG = PHONG.MAPHONG GROUP BY PHONG.MAPHONG ) AS a JOIN ( SELECT KHU.MAKHU, TINHTRANG, MAPHONG, SLTD, TIENPHONG FROM dbo.PHONG LEFT JOIN dbo.KHU ON KHU.MAKHU = PHONG.MAKHU ) AS b ON b.MAPHONG = a.MAPHONG WHERE a.SONGUOIDANGO > 0 AND A.SONGUOIDANGO <b.SLTD");
            foreach (DataRow item in data.Rows)
            {
                Phong_DTO ph = new Phong_DTO(item);
                phongSVList.Add(ph);
            }
            return phongSVList;
        }

        public List<Phong_DTO> phongDKChoNam()  //
        {
            List<Phong_DTO> dkNamList = new List<Phong_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT a.MAPHONG,a.MAKHU,a.SLTD,a.TIENPHONG ,b.SONGUOIDANGO,a.TINHTRANG FROM (SELECT KHU.MAKHU, TINHTRANG, MAPHONG, SLTD, TIENPHONG FROM dbo.KHU JOIN dbo.PHONG ON PHONG.MAKHU = KHU.MAKHU WHERE TINHTRANG= 0) AS a JOIN (SELECT COUNT(MASV) AS SONGUOIDANGO, PHONG.MAPHONG FROM dbo.SINHVIEN RIGHT JOIN dbo.PHONG ON PHONG.MAPHONG = SINHVIEN.MAPHONG GROUP BY PHONG.MAPHONG) AS b ON b.MAPHONG = a.MAPHONG WHERE a.MAKHU IN ('N1','N2','N3') AND b.SONGUOIDANGO < a.SLTD");
            foreach (DataRow item in data.Rows)
            {
                Phong_DTO ph = new Phong_DTO(item);
                dkNamList.Add(ph);
            }
            return dkNamList;
        }

        public List<Phong_DTO> phongDKChoNu()  //
        {
            List<Phong_DTO> dkNuList = new List<Phong_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT a.MAPHONG,a.MAKHU,a.SLTD,a.TIENPHONG ,b.SONGUOIDANGO,a.TINHTRANG FROM (SELECT KHU.MAKHU, TINHTRANG, MAPHONG, SLTD, TIENPHONG FROM dbo.KHU JOIN dbo.PHONG ON PHONG.MAKHU = KHU.MAKHU WHERE TINHTRANG = 0) AS a JOIN (SELECT COUNT(MASV) AS SONGUOIDANGO, PHONG.MAPHONG FROM dbo.SINHVIEN RIGHT JOIN dbo.PHONG ON PHONG.MAPHONG = SINHVIEN.MAPHONG GROUP BY PHONG.MAPHONG) AS b ON b.MAPHONG = a.MAPHONG WHERE a.MAKHU IN ('K1','K2','K3') AND b.SONGUOIDANGO < a.SLTD");
            foreach (DataRow item in data.Rows)
            {
                Phong_DTO ph = new Phong_DTO(item);
                dkNuList.Add(ph);
            }
            return dkNuList;
        }

        #region Chức_năng
        public bool insertPhong(string maphong, string makhu, int sltd, int tienphong)    //PROC thêm, fix lỗi trùng
        {
            int result = DataBase.Instance.executeNonQuery("USP_addPhong @maphong , @makhu , @sltd , @tienphong  ", new object[] { maphong, makhu, sltd, tienphong });
            return result > 0;
        }

        public bool updatePhong(string maphong, string makhu, int sltd, int tienphong)    //sửa
        {
            int result = DataBase.Instance.executeNonQuery("USP_updatePhong @maphong , @makhu , @sltd , @tienphong ", new object[] { maphong, makhu, sltd, tienphong });
            return result > 0;
        }

        public bool deletePhong(string maphong) //, string makhu, int sltd, int tienphong)    //delete
        {
            int result = DataBase.Instance.executeNonQuery("USP_deletePhong @maphong ", new object[] { maphong });
            return result > 0;
        }
        #endregion
    }
}
