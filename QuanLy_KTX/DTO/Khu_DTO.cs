using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DTO
{
    public class Khu_DTO
    {
        public Khu_DTO(string makhu, bool tinhtrang, string vitri, string mota, string hinh)
        {
            this.MAKHU = makhu;
            this.TINHTRANG = tinhtrang;
            this.VITRI = vitri;
            this.MOTA = mota;
            this.HINH = hinh;
        }
        public Khu_DTO(DataRow row)
        {
            this.MAKHU = (string)row["makhu"];
            this.TINHTRANG = (bool)row["tinhtrang"];
            this.VITRI = (string)row["vitri"];
            this.MOTA = (string)row["mota"];
            if (row["hinh"].ToString() != "")
                this.HINH = (string)row["hinh"];
        }
        private string mAKHU;
        private bool tINHTRANG;
        private string vITRI;
        private string mOTA;
        private string hINH;
        public string MAKHU
        {
            get
            { return mAKHU; }


            set { mAKHU = value; }

        }

        public bool TINHTRANG
        {
            get
            {
                return tINHTRANG;
            }

            set
            {
                tINHTRANG = value;
            }
        }

        public string VITRI
        {
            get
            {
                return vITRI;
            }

            set
            {
                vITRI = value;
            }
        }

        public string MOTA
        {
            get
            {
                return mOTA;
            }

            set
            {
                mOTA = value;
            }
        }

        public string HINH
        {
            get
            {
                return hINH;
            }
            set

            { hINH = value; }
        }
    }
}