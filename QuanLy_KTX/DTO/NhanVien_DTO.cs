using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX.DTO
{
	public class NhanVien_DTO
	{
		public NhanVien_DTO(string manv, string makhu, string hotennv, string macv, string tencv, string gtnv, string sdtnv)
		{
			this.MANV = manv;
			this.MAKHU = makhu;
			this.HOTENNV = hotennv;
			this.GTNV = gtnv;
			this.MACV = macv;
			this.TENCV = tencv;
			this.SDTNV = sdtnv;
		}
		public NhanVien_DTO(DataRow row)
		{
			this.MANV = (string)row["manv"];
			this.HOTENNV = (string)row["hotennv"];
			this.GTNV = (string)row["GTNV"];
			this.MACV = (string)row["macv"];
			this.TENCV = (string)row["tencv"];
			this.MAKHU = (string)row["makhu"];
			if (row["sdtnv"].ToString() != "")
				this.SDTNV = (string)row["sdtnv"];

		}


		private string mANV;
		private string mAKHU;
		private string hOTENNV;
		private string gTNV;
		private string mACV;
		private string tENCV;
		private string sDTNV;

		public string MANV { get => mANV; set => mANV = value; }
		public string MAKHU { get => mAKHU; set => mAKHU = value; }
		public string HOTENNV { get => hOTENNV; set => hOTENNV = value; }
		public string GTNV { get => gTNV; set => gTNV = value; }
		public string MACV { get => mACV; set => mACV = value; }
		public string SDTNV { get => sDTNV; set => sDTNV = value; }
		public string TENCV { get => tENCV; set => tENCV = value; }
	}
}