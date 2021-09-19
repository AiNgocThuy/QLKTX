using QuanLy_KTX.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DAO
{
    public class DienNuoc_DAO
    {
        private static DienNuoc_DAO instance;

        public static DienNuoc_DAO Instance
        {
            get
            {
                if (instance == null) instance = new DienNuoc_DAO();
                return DienNuoc_DAO.instance;
            }

            set
            {
                DienNuoc_DAO.instance = value;
            }
        }

        private DienNuoc_DAO() { }

        public List<DienNuoc_DTO> DNList()
        {
            List<DienNuoc_DTO> dnList = new List<DienNuoc_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT a.MAPHONG, a.THANG, a.NAM, a.CSDK, a.CSCK,a.SDSD,a.TIENDIEN,a.CSDKN,a.CSCKN,a.SND,a.TIENNUOC, a.TIENDIEN+a.TIENNUOC AS TONGTIEN FROM dbo.PHONG JOIN (SELECT DIEN.MAPHONG, THANG, NAM, CSDK, CSCK, CSCK - CSDK AS SDSD,CASE WHEN((CSCK - CSDK) < 100) THEN ROUND(((CSCK - CSDK) * 1671), -3) WHEN((CSCK - CSDK) <= 150) THEN ROUND((100 * 1671 + (CSCK - CSDK - 100) * 1921), -3)  WHEN((CSCK - CSDK) <= 200) THEN ROUND((100 * 1671 + 50 * 1921 + (CSCK - CSDK - 150) * 2242), -3)  ELSE ROUND((100 * 1671 + 50 * 1921 + 50 * 2242 + (CSCK - CSDK - 200) * 2503), -3) END AS TIENDIEN, CSDKN, CSCKN, CSCKN - CSDKN AS SND, CASE WHEN((CSCKN - CSDKN) < 50) THEN ROUND(((CSCKN - CSDKN) * 8450), -3) ELSE ROUND((50 * 8450 + (CSCKN - CSDKN - 50) * 9950), -3)END AS TIENNUOC FROM DIEN JOIN NUOC ON NUOC.MAPHONG = DIEN.MAPHONG AND THANG =THANGN AND NAM = NAMN) AS a ON a.MAPHONG = PHONG.MAPHONG ORDER BY PHONG.MAPHONG, a.THANG, a.NAM");
            foreach (DataRow item in data.Rows)
            {
                DienNuoc_DTO dn = new DienNuoc_DTO(item);
                dnList.Add(dn);
            }
            return dnList;
        }

        public List<DienNuoc_DTO> getDNList(string maphong, int thang, int nam)
        {
            List<DienNuoc_DTO> dnList = new List<DienNuoc_DTO>();
            DataTable data = DataBase.Instance.executeQuery("SELECT a.MAPHONG, a.THANG, a.NAM, a.CSDK, a.CSCK,a.SDSD,a.TIENDIEN,a.CSDKN,a.CSCKN,a.SND,a.TIENNUOC, a.TIENDIEN+a.TIENNUOC AS TONGTIEN FROM dbo.PHONG JOIN (SELECT DIEN.MAPHONG, THANG, NAM, CSDK, CSCK, CSCK - CSDK AS SDSD,CASE WHEN((CSCK - CSDK) < 100) THEN ROUND(((CSCK - CSDK) * 1671), -3) WHEN((CSCK - CSDK) <= 150) THEN ROUND((100 * 1671 + (CSCK - CSDK - 100) * 1921), -3)  WHEN((CSCK - CSDK) <= 200) THEN ROUND((100 * 1671 + 50 * 1921 + (CSCK - CSDK - 150) * 2242), -3)  ELSE ROUND((100 * 1671 + 50 * 1921 + 50 * 2242 + (CSCK - CSDK - 200) * 2503), -3) END AS TIENDIEN, CSDKN, CSCKN, CSCKN - CSDKN AS SND, CASE WHEN((CSCKN - CSDKN) < 50) THEN ROUND(((CSCKN - CSDKN) * 8450), -3) ELSE ROUND((50 * 8450 + (CSCKN - CSDKN - 50) * 9950), -3)END AS TIENNUOC FROM DIEN JOIN NUOC ON NUOC.MAPHONG = DIEN.MAPHONG AND THANG =THANGN AND NAM = NAMN) AS a ON a.MAPHONG = PHONG.MAPHONG  WHERE a.MAPHONG = '" + maphong + "' AND a.THANG = " + thang + " AND a.NAM = " + nam + "");
            foreach (DataRow item in data.Rows)
            {
                DienNuoc_DTO dn = new DienNuoc_DTO(item);
                dnList.Add(dn);
            }
            return dnList;
        }

        public bool insertDN(string maphong, int thang, int nam, int csdk, int csck, int csdkn, int csckn)
        {
            int result = DataBase.Instance.executeNonQuery("USP_insertDT @maphong , @thang , @nam , @csdk , @csck , @csdkn , @csckn ", new object[] { maphong, thang, nam, csdk, csck, csdkn, csckn });
            return result > 0;
        }

        public bool deleteDN(string maphong, int thang, int nam)
        {
            int result = DataBase.Instance.executeNonQuery("DELETE DIEN WHERE MAPHONG = '" + maphong + "' AND THANG = " + thang + " AND NAM = " + nam + " DELETE NUOC WHERE MAPHONG = '" + maphong + "' AND THANGN = " + thang + " AND NAMN = " + nam);
            return result > 0;
        }

        public bool updateDN(string maphong, int thang, int nam, int csdk, int csck, int csdkn, int csckn)
        {
            int result = DataBase.Instance.executeNonQuery("UPDATE DIEN SET CSDK = " + csdk + ", CSCK = " + csck + " WHERE THANG =" + thang + " AND NAM =" + nam + "AND MAPHONG ='" + maphong + "' UPDATE NUOC SET CSDKN = " + csdkn + ", CSCKN = " + csckn + " WHERE THANGN =" + thang + " AND NAMN = " + nam + " AND MAPHONG ='" + maphong + "'");
            return result > 0;
        }
    }
}