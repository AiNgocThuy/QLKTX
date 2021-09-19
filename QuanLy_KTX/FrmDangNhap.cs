using QuanLy_KTX.DAO;
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
	public partial class FrmDangNhap : Form
	{
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }




        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (Dangnhap(taiKhoan, matKhau))
            {
                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool Dangnhap(string taiKhoan, string matKhau)
        {
            return TaiKhoan_DAO.Instance.DangNhap(taiKhoan, matKhau);
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
