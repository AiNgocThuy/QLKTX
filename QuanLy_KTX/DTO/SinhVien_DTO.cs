using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DTO
{
    class SinhVien_DTO
    {

        public SinhVien_DTO(string masv, string malop, string maphong, string hotensv, DateTime ngaysinh, string gtsv, string quequan, string cmnd, string dtsv, string dantoc, string bacdt, string makhoa)
        {
            this.MASV = masv;
            this.MALOP = malop;
            this.MAPHONG = maphong;
            this.HOTENSV = hotensv;

            this.NGAYSINH = ngaysinh;
            this.GIOITINH = gtsv;
            this.QUEQUAN = quequan;

            this.CMND = cmnd;
            this.DTSV = dtsv;
            this.DANTOC = dantoc;

            this.BACDT = bacdt;
            this.MAKHOA = makhoa;
        }
        public SinhVien_DTO(DataRow row)
        {
            this.MASV = (string)row["masv"];
            this.MALOP = (string)row["malop"];
            if (row["maphong"].ToString() != "")
                this.MAPHONG = (string)row["maphong"];
            this.HOTENSV = (string)row["HOTENSV"];
            this.NGAYSINH = (DateTime)row["ngaysinh"];
            this.GIOITINH = (string)row["GIOITINH"];
            this.QUEQUAN = (string)row["quequan"];

            if (row["cmnd"].ToString() != "")
                this.CMND = (string)row["cmnd"];
            if (row["dtsv"].ToString() != "")
                this.DTSV = (string)row["dtsv"];
            this.DANTOC = (string)row["dantoc"];
            this.BACDT = (string)row["bacdaotao"];
            this.MAKHOA = (string)row["makhoa"];
        }

        private string mASV;
        private string mALOP;
        private string mAPHONG;
        private string hOTENSV;

        private DateTime nGAYSINH;
        private string gIOITINH;
        private string qUEQUAN;
        private string cMND;
        private string dTSV;
        private string dANTOC;

        private string bACDT;
        private string mAKHOA;

        public string MASV
        {
            get
            {
                return mASV;
            }

            set
            {
                mASV = value;
            }
        }

        public string HOTENSV
        {
            get
            {
                return hOTENSV;
            }

            set
            {
                hOTENSV = value;
            }
        }

        public string MALOP
        {
            get
            {
                return mALOP;
            }

            set
            {
                mALOP = value;
            }
        }

        public string MAPHONG
        {
            get
            {
                return mAPHONG;
            }

            set
            {
                mAPHONG = value;
            }
        }

        public DateTime NGAYSINH
        {
            get
            {
                return nGAYSINH;
            }

            set
            {
                nGAYSINH = value;
            }
        }

        public string GIOITINH
        {
            get
            {
                return gIOITINH;
            }

            set
            {
                gIOITINH = value;
            }
        }

        public string QUEQUAN
        {
            get
            {
                return qUEQUAN;
            }

            set
            {
                qUEQUAN = value;
            }
        }


        public string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
            }
        }

        public string DTSV
        {
            get
            {
                return dTSV;
            }

            set
            {
                dTSV = value;
            }
        }

        public string DANTOC
        {
            get
            {
                return dANTOC;
            }

            set
            {
                dANTOC = value;
            }
        }



        public string BACDT
        {
            get
            {
                return bACDT;
            }

            set
            {
                bACDT = value;
            }
        }

        public string MAKHOA
        {
            get
            {
                return mAKHOA;
            }

            set
            {
                mAKHOA = value;
            }
        }

    }
}
