using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DTO
{
    class Phong_DTO
    {
        public Phong_DTO(string maphong, string makhu, int sltd, int tienphong, int songuoidango, int tinhtrang) //đưa vào tham số
        {
            this.MAPHONG = maphong;
            this.MAKHU = makhu;
            this.SLTD = sltd;
            this.TIENPHONG = tienphong;
            this.SONGUOIDANGO = songuoidango;
            this.TINHTRANG = tinhtrang;
        }

        public Phong_DTO(DataRow row)   //đưa vào DataTable
        {
            this.MAPHONG = (string)row["MAPHONG"];
            this.MAKHU = (string)row["MAKHU"];
            this.SLTD = Convert.ToInt32(row["SLTD"]);
            this.TIENPHONG = (int)row["TIENPHONG"];
            this.SONGUOIDANGO = (int)row["SONGUOIDANGO"];
            this.TINHTRANG = Convert.ToInt32(row["TINHTRANG"]);
        }

        private int tINHTRANG;
        private string mAPHONG;
        private string mAKHU;
        private int sLTD;
        private int tIENPHONG;
        private int sONGUOIDANGO;

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

        public string MAKHU
        {
            get
            {
                return mAKHU;
            }

            set
            {
                mAKHU = value;
            }
        }

        public int SLTD
        {
            get
            {
                return sLTD;
            }

            set
            {
                sLTD = value;
            }
        }

        public int TIENPHONG
        {
            get
            {
                return tIENPHONG;
            }

            set
            {
                tIENPHONG = value;
            }
        }


        public int SONGUOIDANGO
        {
            get
            {
                return sONGUOIDANGO;
            }

            set
            {
                sONGUOIDANGO = value;
            }
        }

        public int TINHTRANG
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
    }
}
