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

namespace QuanLy_KTX
{
	public partial class FrmKhu : Form
	{
		public FrmKhu()
		{
			InitializeComponent();
			load();
		}
		void load()
		{
			loadCBMAKHU(cbKhu);
			cbKhu.SelectedIndex = -1;
			cbKhu.Text = "--Lựa chọn khu--";
		}

		void loadCBMAKHU(ComboBox cb)
		{
			cb.DataSource = DataBase.Instance.executeQuery("SELECT MAKHU FROM dbo.KHU");
			cb.DisplayMember = "MAKHU";
		}
		void getKHU(string makhu)
		{
			List<Khu_DTO> khulist = Khu_DAO.Instance.getKHU(makhu);
			foreach (Khu_DTO item in khulist)
			{
				if (item.TINHTRANG == false)
					cbTTKhu.SelectedIndex = 0;
				else if (item.TINHTRANG == true)
					cbTTKhu.SelectedIndex = 1;
				txtViTri.Text = item.VITRI;
				txtMoTa.Text = item.MOTA;
				txtHinh.Text = item.HINH;
			}
		}
		private void cbKhu_TextChanged(object sender, EventArgs e)
		{

			if (cbKhu.Text == (string)DataBase.Instance.executeScalar("SELECT MAKHU FROM dbo.KHU WHERE MAKHU = '" + cbKhu.Text + "'"))
			{
				getKHU(cbKhu.Text);
				pictureBoxKhu.ImageLocation = txtHinh.Text;
			}
			else
			{
				cbTTKhu.SelectedIndex = -1;
				txtViTri.Clear();
				txtViTri.Clear();
				txtHinh.Clear();
				pictureBoxKhu.ImageLocation = null;
				panel1.Visible = false;
			}
			//if (cbKhu.SelectedIndex ==1  )
			//{

			//}
			//pictureBoxKhu.Image.FromFile("C:\Users\ADMIN\Pictures\Saved Pictures\k2.png")

		}

		private void btnSua_Click_1(object sender, EventArgs e)
		{
			if ((cbKhu.SelectedIndex == -1))
				MessageBox.Show("Vui lòng chọn khu để xem chi tiết!");
			else
			if ((int)DataBase.Instance.executeScalar("SELECT COUNT(*) FROM dbo.KHU WHERE MAKHU = '" + cbKhu.Text + "' AND TINHTRANG = N'" + cbTTKhu.SelectedIndex + "' AND VITRI=N'" + txtViTri.Text + "' AND MOTA = N'" + txtMoTa.Text + "' AND HINH ='" + txtHinh.Text + "'") == 1)
				MessageBox.Show("Vui lòng nhập giá trị mới vào!");
			else
			if (cbKhu.Text == (string)DataBase.Instance.executeScalar("SELECT MAKHU FROM dbo.KHU WHERE MAKHU = '" + cbKhu.Text + "'") && cbTTKhu.SelectedIndex != -1)
				if (DataBase.Instance.executeNonQuery("UPDATE dbo.KHU SET TINHTRANG = " + cbTTKhu.SelectedIndex + ",VITRI =N'" + txtViTri.Text + "',MOTA=N'" + txtMoTa.Text + "',HINH= '" + txtHinh.Text + "' WHERE MAKHU ='" + cbKhu.Text + "'") > 0)
				{
					MessageBox.Show("Sửa thành công.");
					//cbKhu.SelectedIndex = -1;

				}
				else MessageBox.Show("Đã xảy ra lỗi!");

		}


	}
}