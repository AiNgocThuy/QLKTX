using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DTO
{
    public class DienNuoc_DTO
    {
        public DienNuoc_DTO(string maphong, int thang, int nam, int csdk, int csck, int sdsd, float tiendien, int csdkn, int csckn, int snd, float tiennuoc, float tongtien)
        {
            //this.MADIEN = madien;
            //this.MANUOC = manuoc;
            this.MAPHONG = maphong;
            this.THANG = thang;
            this.NAM = nam;
            this.CSDK = csdk;
            this.CSCK = csck;
            this.SDSD = sdsd;
            this.TIENDIEN = tiendien;
            this.CSDKN = csdkn;
            this.CSCKN = csckn;
            this.SND = snd;
            this.TIENNUOC = tiennuoc;
            this.TONGTIEN = tongtien;
        }

        public DienNuoc_DTO(DataRow row)
        {
            //this.MADIEN = (string)row["MADIEN"];
            //this.MANUOC = (string)row["MANUOC"];
            this.MAPHONG = (string)row["maphong"];
            this.THANG = Convert.ToInt16(row["thang"]);
            this.NAM = Convert.ToInt16(row["nam"]);
            try
            {
                this.CSDK = (int)row["CSDK"];
                this.CSCK = (int)row["CSCK"];

                this.CSDKN = (int)row["CSDKN"];
                this.CSCKN = (int)row["CSCKN"];
            }
            catch { }

            this.SDSD = (int)row["sdsd"];
            this.TIENDIEN = (int)row["tiendien"];

            this.SND = (int)row["snd"];
            this.TIENNUOC = (int)row["tiennuoc"];
            this.TONGTIEN = (int)row["tongtien"];
        }
        //private string mADIEN;
        private string mAPHONG;
        //private string mANUOC;
        private int tHANG;
        private int nAM;
        private int cSDK;
        private int cSCK;
        private float tIENDIEN;
        private float cSDKN;
        private int cSCKN;
        private int sDSD;
        private int sND;
        private float tIENNUOC;
        private float tONGTIEN;

        //public string MADIEN { get => mADIEN; set => mADIEN = value; }
        //public string MANUOC { get => mANUOC; set => mANUOC = value; }
        public int THANG { get => tHANG; set => tHANG = value; }
        public int CSDK { get => cSDK; set => cSDK = value; }
        public int CSCK { get => cSCK; set => cSCK = value; }
        public float TIENDIEN { get => tIENDIEN; set => tIENDIEN = value; }
        public float CSDKN { get => cSDKN; set => cSDKN = value; }
        public int CSCKN { get => cSCKN; set => cSCKN = value; }
        public int SND { get => sND; set => sND = value; }
        public float TIENNUOC { get => tIENNUOC; set => tIENNUOC = value; }
        public float TONGTIEN { get => tONGTIEN; set => tONGTIEN = value; }
        public string MAPHONG { get => mAPHONG; set => mAPHONG = value; }
        public int NAM { get => nAM; set => nAM = value; }
        public int SDSD { get => sDSD; set => sDSD = value; }
    }
}
