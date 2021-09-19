using QuanLy_KTX.DAO;
using QuanLy_KTX.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_KTX.QuanLy
{
	public partial class FrmQLDienNuoc : Form
	{
		BindingSource diennuocList = new BindingSource();
		public FrmQLDienNuoc()
		{
			InitializeComponent();
			load();
		}
		void load()
		{
			dataGridViewQLDN.DataSource = diennuocList;
			loadDienNuoc();
			dnBinding();
		}
		void loadDienNuoc()
		{
			diennuocList.DataSource = DienNuoc_DAO.Instance.DNList();
		}
		void dnBinding()
		{
			//txtMaCTD.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "MADIEN", true, DataSourceUpdateMode.Never));
			//txtMaCTN.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "MANUOC", true, DataSourceUpdateMode.Never));
			txtMaPhong.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "MAPHONG", true, DataSourceUpdateMode.Never));
			txtThang.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "THANG", true, DataSourceUpdateMode.Never));
			txtNam.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "NAM", true, DataSourceUpdateMode.Never));
			txtSoDien.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "SDSD", true, DataSourceUpdateMode.Never));
			txtTienDien.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "TIENDIEN", true, DataSourceUpdateMode.Never));
			txtSoNuoc.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "SND", true, DataSourceUpdateMode.Never));
			txtTienNuoc.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "TIENNUOC", true, DataSourceUpdateMode.Never));
			txtTongTien.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "TONGTIEN", true, DataSourceUpdateMode.Never));
			txtCSDKD.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "CSDK", true, DataSourceUpdateMode.Never));
			txtCSCKD.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "CSCK", true, DataSourceUpdateMode.Never));
			txtCSDKN.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "CSDKN", true, DataSourceUpdateMode.Never));
			txtCSCKN.DataBindings.Add(new Binding("Text", dataGridViewQLDN.DataSource, "CSCKN", true, DataSourceUpdateMode.Never));

		}

		private void btnLamMoiDN_Click(object sender, EventArgs e)
		{
			loadDienNuoc();
		}
		void getDN(string maphong, int thang, int nam)
		{
			List<DienNuoc_DTO> ttDN = DienNuoc_DAO.Instance.getDNList(maphong, thang, nam);
			foreach (DienNuoc_DTO item in ttDN)
			{
				//txtMaCTD.Text = item.MADIEN;
				//txtMaCTN.Text = item.MANUOC;
				txtCSDKD.Text = Convert.ToString(item.CSDK);
				txtCSCKD.Text = Convert.ToString(item.CSCK);
				txtSoDien.Text = Convert.ToString(item.SDSD);
				txtTienDien.Text = Convert.ToString(item.TIENDIEN);
				txtTongTien.Text = Convert.ToString(item.TONGTIEN); ;
				txtCSDKN.Text = Convert.ToString(item.CSDKN);
				txtCSCKN.Text = Convert.ToString(item.CSCKN);

			}
		}   //hàm getDN cho nút tìm kiếm

		private void btnThemDN_Click(object sender, EventArgs e)
		{
			if (txtMaPhong.Text != "" || txtThang.Text != "" || txtNam.Text != "" || txtCSDKD.Text != "" || txtCSCKD.Text != "" || txtCSDKN.Text != "" || txtCSCKN.Text != "")
			{
				//string madien = txtMaCTD.Text; string manuoc = txtMaCTN.Text;
				string maphong = txtMaPhong.Text;
				int thang = Convert.ToInt32(txtThang.Text);
				int nam = Convert.ToInt32(txtNam.Text);
				int csdk = Convert.ToInt32(txtCSDKD.Text);
				int csck = Convert.ToInt32(txtCSCKD.Text);
				int csdkn = Convert.ToInt32(txtCSDKN.Text);
				int csckn = Convert.ToInt32(txtCSCKN.Text);

				if (csdk > csck) MessageBox.Show("Chỉ số Điện đầu kỳ không nên lớn hơn chỉ số cuối kỳ");
				else
				if (csdkn > csckn) MessageBox.Show("Chỉ số Nước đầu kỳ không nên lớn hơn chỉ số cuối kỳ");
				else
				//if ((int)DataProvider.Instance.executeScalar("")!=1) MessageBox.Show("");
				//else
				if ((int)DataBase.Instance.executeScalar("SELECT COUNT (*) FROM DIEN JOIN NUOC ON NUOC.MAPHONG = DIEN.MAPHONG AND THANG = THANGN AND NAM = NAMN WHERE DIEN.MAPHONG = '" + txtMaPhong.Text + "' AND THANG =" + txtThang.Text + "  AND NAM =" + txtNam.Text + " ") == 1) MessageBox.Show("Phòng đã nhập thông tin điện nước của tháng này vào rồi!");
				else
				if (DienNuoc_DAO.Instance.insertDN(maphong, thang, nam, csdk, csck, csdkn, csckn))
				{
					MessageBox.Show("Thêm thành công");
					loadDienNuoc();
				}
				else MessageBox.Show("Vui lòng nhập giá trị khác!");
			}
			else MessageBox.Show("Vui lòng điền thông tin vào!");
		}

		private void btnXoaDN_Click(object sender, EventArgs e)
		{
			if (txtMaPhong.Text != "" || txtThang.Text != "" || txtNam.Text != "")
			{
				string maphong = txtMaPhong.Text;
				int thang = Convert.ToInt32(txtThang.Text);
				int nam = Convert.ToInt32(txtNam.Text);

				if (DienNuoc_DAO.Instance.deleteDN(maphong, thang, nam))
				{
					MessageBox.Show("Xóa thành công.");
					loadDienNuoc();
				}
				else MessageBox.Show("Kiểm tra lại Mã phòng hoặc Tháng, Năm!");
			}
			else MessageBox.Show("Vui lòng điền thông tin vào!");
		}

		private void btnSuaDN_Click(object sender, EventArgs e)
		{
			if (txtMaPhong.Text != "" || txtThang.Text != "" || txtNam.Text != "" || txtCSDKD.Text != "" || txtCSCKD.Text != "" || txtCSDKN.Text != "" || txtCSCKN.Text != "")
			{
				//string madien = txtMaCTD.Text; string manuoc = txtMaCTN.Text;
				string maphong = txtMaPhong.Text;
				int thang = Convert.ToInt32(txtThang.Text);
				int nam = Convert.ToInt32(txtNam.Text);
				int csdk = Convert.ToInt32(txtCSDKD.Text);
				int csck = Convert.ToInt32(txtCSCKD.Text);
				int csdkn = Convert.ToInt32(txtCSDKN.Text);
				int csckn = Convert.ToInt32(txtCSCKN.Text);
				if (csdk < csck && csdkn < csckn)

					if (DienNuoc_DAO.Instance.updateDN(maphong, thang, nam, csdk, csck, csdkn, csckn))
					{
						MessageBox.Show("Sửa thành công");
						loadDienNuoc();
					}
					else MessageBox.Show("Vui lòng nhập giá trị khác!");
				else MessageBox.Show("Chỉ số đầu kì quá lớn!");
			}
			else MessageBox.Show("Vui lòng điền thông tin vào!");
		}

		private void txtMaPhong_TextChanged(object sender, EventArgs e)
		{
			if (txtMaPhong.Text.Length == 10 && txtThang.Text != "" && txtNam.Text != "")
				getDN(txtMaPhong.Text, Convert.ToInt16(txtThang.Text), Convert.ToInt16(txtNam.Text));
			else
			{
				txtCSDKD.Clear(); txtCSCKD.Clear(); txtCSDKN.Clear(); txtCSCKN.Clear();
				txtSoDien.Clear(); txtSoNuoc.Clear();
				txtTienDien.Clear(); txtTienNuoc.Clear(); txtTongTien.Clear();
			}
		}
		private Report.FrmRp_DienNuoc frmRp_DienNuoc; //phiếu báo điện nước
		private void btnIn_Click(object sender, EventArgs e)
		{
			if(frmRp_DienNuoc == null || (frmRp_DienNuoc != null && frmRp_DienNuoc.IsDisposed))
			{
				frmRp_DienNuoc = new Report.FrmRp_DienNuoc();
			}
			if (!frmRp_DienNuoc.Visible)
			{
				frmRp_DienNuoc.Show();
				frmRp_DienNuoc.StartPosition = FormStartPosition.Manual;
				frmRp_DienNuoc.Left = 50; frmRp_DienNuoc.Top = 50;
			}
			else frmRp_DienNuoc.BringToFront();
		}
		
		 
	}
}
