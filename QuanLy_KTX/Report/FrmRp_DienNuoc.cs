using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_KTX.Report
{
	public partial class FrmRp_DienNuoc : Form
	{
		System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FrmQLDienNuoc"];
		public FrmRp_DienNuoc()
		{
			InitializeComponent();
		}

		private void FrmRp_DienNuoc_Load(object sender, EventArgs e)
		{

			string maphong = ((QuanLy.FrmQLDienNuoc)f).txtMaPhong.Text;
			txtMaKhu.Text = maphong.Substring(0, 2);
		txtThang.Text = ((QuanLy.FrmQLDienNuoc)f).txtThang.Text;
			txtNam.Text = ((QuanLy.FrmQLDienNuoc)f).txtNam.Text;
		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			if (txtMaKhu.Text != "" && txtThang.Text != "" && txtNam.Text != "")
            {
                this.usP_getDIENNUOCFromKHUTableAdapter1.Fill(this.ktxDataSet1.USP_getDIENNUOCFromKHU, txtMaKhu.Text, Convert.ToByte(txtThang.Text), Convert.ToInt16(txtNam.Text));
                this.reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ giá trị vào!");
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
	}

