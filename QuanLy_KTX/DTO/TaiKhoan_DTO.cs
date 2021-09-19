using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DAO
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO(string tendangnhap, string tenhienthi, int loaitk, string matkhau = null)
        {
            this.TENDANGNHAP = tendangnhap;
            this.TENHIENTHI = tenhienthi;
            this.LOAITK = loaitk;
            this.MATKHAU = matkhau;
        }
        public TaiKhoanDTO(DataRow row)
        {
            this.TENDANGNHAP = row["TENDANGNHAP"].ToString();
            this.TENHIENTHI = row["TENHIENTHI"].ToString();
            this.LOAITK = Convert.ToInt32(row["LOAITK"]);
            this.MATKHAU = row["MATKHAU"].ToString();
        }
        private string tENDANGNHAP;
        private string tENHIENTHI;
        private string mATKHAU;
        private int lOAITK;

        public string TENDANGNHAP
        {
            get
            {
                return tENDANGNHAP;
            }

            set
            {
                tENDANGNHAP = value;
            }
        }

        public string TENHIENTHI
        {
            get
            {
                return tENHIENTHI;
            }

            set
            {
                tENHIENTHI = value;
            }
        }

        public string MATKHAU
        {
            get
            {
                return mATKHAU;
            }

            set
            {
                mATKHAU = value;
            }
        }

        public int LOAITK
        {
            get
            {
                return lOAITK;
            }

            set
            {
                lOAITK = value;
            }
        }
    }
}