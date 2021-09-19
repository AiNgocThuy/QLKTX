using QuanLy_KTX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DAO
{
    class SinhVien_DAO
    {
        private static SinhVien_DAO instance;

        public static SinhVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new SinhVien_DAO();
                return SinhVien_DAO.instance;
            }

            set
            {
                SinhVien_DAO.instance = value;
            }
        }

        private SinhVien_DAO() { }

        public List<SinhVien_DTO> SinhVien_DTO()  //dgv sinh viên
        {
            List<SinhVien_DTO> sinhvienList = new List<SinhVien_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT MASV, LOP.MALOP, MAPHONG, HOSV + ' ' + TENSV AS HOTENSV, NGAYSINH, CASE WHEN GTSV = 1 THEN N'Nam' ELSE N'Nữ' END AS [GIOITINH], QUEQUAN , CMND, DTSV, DANTOC,BACDAOTAO, KHOA.MAKHOA FROM dbo.SINHVIEN LEFT JOIN dbo.LOP ON LOP.MALOP = SINHVIEN.MALOP LEFT JOIN dbo.KHOA ON KHOA.MAKHOA = LOP.MAKHOA ORDER BY MAPHONG,HOTENSV,SINHVIEN.MALOP");
            foreach (DataRow item in data.Rows)
            {
                SinhVien_DTO ph = new SinhVien_DTO(item);
                sinhvienList.Add(ph);
            }
            return sinhvienList;
        }

        //public List<sinhvien> sinhvienCoMaPhong()  //dgv sinh viên
        //{
        //    List<sinhvien> sinhvienList = new List<sinhvien>();
        //    DataTable data = DataProvider.Instance.executeQuery("SELECT HOPDONG.MASV, HOSV+' '+TENSV AS HOTENSV,CASE WHEN GT = 1 THEN N'Nam'	ELSE N'Nữ'	END AS GIOITINH ,HOPDONG.MAPHONG,NGAYLAP,NGAYHETHAN FROM dbo.HOPDONG JOIN dbo.SINHVIEN ON SINHVIEN.MASV = HOPDONG.MASV ORDER BY HOPDONG.MAPHONG,TENSV,HOPDONG.MASV");
        //    foreach (DataRow item in data.Rows)
        //    {
        //        sinhvien ph = new sinhvien(item);
        //        sinhvienList.Add(ph);
        //    }
        //    return sinhvienList;
        //}

        public List<SinhVien_DTO> getSVTuMAPHONG(string maphong)  //dgv sinh viên
        {
            List<SinhVien_DTO> sinhvienList = new List<SinhVien_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT MASV, LOP.MALOP, MAPHONG, HOSV + ' ' + TENSV AS HOTENSV, NGAYSINH, CASE WHEN GTSV = 1 THEN N'Nam' ELSE N'Nữ' END AS [GIOITINH], QUEQUAN , CMND, DTSV, DANTOC ,BACDAOTAO, KHOA.MAKHOA FROM dbo.SINHVIEN LEFT JOIN dbo.LOP ON LOP.MALOP = SINHVIEN.MALOP LEFT JOIN dbo.KHOA ON KHOA.MAKHOA = LOP.MAKHOA WHERE MAPHONG ='" + maphong + "'");
            foreach (DataRow item in data.Rows)
            {
                SinhVien_DTO ph = new SinhVien_DTO(item);
                sinhvienList.Add(ph);
            }
            return sinhvienList;
        }

        public DataTable getTN(string masv) //bảng thân nhân
        {
            return DataBase.Instance.executeQuery("SELECT MASV, TENNGUOITHAN, MQH, DIACHINT, SDTNT FROM GD_SV JOIN GIADINH ON GIADINH.MAGD = GD_SV.MAGD WHERE MASV='" + masv + "'");
        }

        public List<SinhVien_DTO> getSV(string masv)   //
        {
            List<SinhVien_DTO> ttSVList = new List<SinhVien_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT MASV, a.MALOP, MAPHONG, HOSV +' '+ TENSV AS HOTENSV, NGAYSINH, CASE WHEN GTSV = 1 THEN N'Nam' ELSE N'Nữ' END AS [GIOITINH], QUEQUAN, CMND,DANTOC, DTSV, a.BACDAOTAO, a.MAKHOA FROM dbo.SINHVIEN  JOIN (SELECT MALOP, BACDAOTAO, KHOA.MAKHOA FROM dbo.LOP JOIN dbo.KHOA ON KHOA.MAKHOA = LOP.MAKHOA) AS a ON a.MALOP = SINHVIEN.MALOP WHERE MASV='" + masv + "'");

            foreach (DataRow item in data.Rows)
            {
                SinhVien_DTO sv = new SinhVien_DTO(item);
                ttSVList.Add(sv);
            }
            return ttSVList;
        }

        public bool updateSinhVien(string masv, string hosv, string tensv, string malop, string maphong, DateTime ngaysinh, bool gtsv, string quequan, string cmnd, string dtsv, string dantoc, string makhoa)   //nút Sửa
        {
            int result = DataBase.Instance.executeNonQuery("USP_updateSinhVien @masv , @hosv , @tensv , @malop , @maphong , @ngaysinh , @gtsv , @quequan , @cmnd , @dtsv , @dantoc , @makhoa ", new object[] { masv, hosv, tensv, malop, maphong, ngaysinh, gtsv, quequan, cmnd, dtsv, dantoc, makhoa });
            return result > 0;
        }

        public bool deleteSinhVien(string masv) //, string makhu, int sltd, int tienphong, int tienthuechap)    //delete
        {
            int result = DataBase.Instance.executeNonQuery("USP_deleteSinhVien @masv ", new object[] { masv });
            return result > 0;
        }

        public bool insertSinhVien(string masv, string hosv, string tensv, string malop, string tennganh, string makhoa, string maphong, string tenkhoa, DateTime ngaysinh, bool gtsv, string quequan, string cmnd, string dtsv, string dantoc, string tennt, bool gttn, string diachitn, string dttn, string mqh, DateTime ngaylap, string manv)
        {
            // DateTime ngaysinh = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy", null);
            string ngaysinh1 = ngaysinh.ToString("yyyy-MM-dd");
            int result = DataBase.Instance.executeNonQuery("USP_insertSinhVien @masv , @hosv , @tensv , @malop , @tennganh , @makhoa , @maphong , @tenkhoa , @ngaysinh , @gtsv , @quequan , @cmnd , @dtsv , @dantoc , @tennt , @gttn , @diachitn , @dttn , @mqh , @ngaylap , @manv  ", new object[] { masv, hosv, tensv, malop, tennganh, makhoa, maphong, tenkhoa, ngaysinh1, gtsv, quequan, cmnd, dtsv, dantoc, tennt, gttn, diachitn, dttn, mqh, ngaylap, manv });
            return result > 0;
        }

        public bool chuyenPhong(string masv, string maphong)
        {
            int result = DataBase.Instance.executeNonQuery("USP_chuyenPhong @masv , @maphong ", new object[] { masv, maphong });
            return result > 0;
        }
    }
}