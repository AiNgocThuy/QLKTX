using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DTO
{
    public class Khoa_DTO
    {
        public Khoa_DTO(string makhoa, string tenkhoa)
        {
            this.MAKHOA = makhoa;
            this.TENKHOA = tenkhoa;
        }
        public Khoa_DTO(DataRow row)
        {
            this.MAKHOA = (string)row["makhoa"];
            this.TENKHOA = (string)row["tenkhoa"];
        }
        private string mAKHOA;
        private string tENKHOA;

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

        public string TENKHOA
        {
            get
            {
                return tENKHOA;
            }

            set
            {
                tENKHOA = value;
            }
        }
    }
}