using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_KTX
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void DKPhongToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuanLyPhong.FrmDangKyPhong frmDangKyPhong = new QuanLyPhong.FrmDangKyPhong();
			frmDangKyPhong.ShowDialog();
		}

		private void QLSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuanLy.FrmQuanLySV frmQuanLySV = new QuanLy.FrmQuanLySV();
			frmQuanLySV.ShowDialog();
		}

		private void QLPhongToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuanLy.FrmQLPhong frmQLPhong = new QuanLy.FrmQLPhong();
			frmQLPhong.ShowDialog();
		}

		private void QLDienNuocToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuanLy.FrmQLDienNuoc frmQLDienNuoc = new QuanLy.FrmQLDienNuoc();
			frmQLDienNuoc.ShowDialog();
		}

		private void QLNVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuanLy.FrmQLNhanVien frmQLNhanVien = new QuanLy.FrmQLNhanVien();
			frmQLNhanVien.ShowDialog();
		}

		private void ChuyenPhongToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuanLyPhong.FrmChuyenPhong frmChuyenPhong = new QuanLyPhong.FrmChuyenPhong();
			frmChuyenPhong.ShowDialog();
		}

		private void ThongTinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmKhu frmKhu = new FrmKhu();
			frmKhu.ShowDialog();
		}

		private void TimKiemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QuanLyPhong.FrmTimKiem frmTimKiem = new QuanLyPhong.FrmTimKiem();
			frmTimKiem.ShowDialog();
		}
	}
}