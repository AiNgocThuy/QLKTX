using QuanLy_KTX.DAO;
using QuanLy_KTX.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_KTX.QuanLy
{
    public partial class FrmQLPhong : Form
    {
        public FrmQLPhong()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            Thread thr = new Thread(loadPhongList);
            thr.IsBackground = true;
            thr.Start();
        }

        void loadPhongList()
        {
            List<Phong_DTO> phongList = Phong_DAO.Instance.Phong_DTO();

            foreach (Phong_DTO item in phongList)
            {
                Button bt = new Button() { Width = Phong_DAO.phongWidth, Height = Phong_DAO.phongHeight };
                if (item.SONGUOIDANGO == 0)
                {
                    bt.Text = item.MAPHONG + Environment.NewLine + "Trống";
                    bt.BackColor = Color.AliceBlue;
                }
                else
                    if (item.SONGUOIDANGO > 0 && item.SONGUOIDANGO < item.SLTD)
                {
                    bt.Text = item.MAPHONG + Environment.NewLine + "Có người";
                    bt.BackColor = Color.Aquamarine;
                }
                else
                {
                    bt.Text = item.MAPHONG + Environment.NewLine + "Đầy";
                    bt.BackColor = Color.Red;
                }
                bt.Click += Bt_Click;
                bt.Tag = item;

                Thread.Sleep(5);
                if (flowLayoutPanelQLP.InvokeRequired)
                {
                    flowLayoutPanelQLP.Invoke(new MethodInvoker(delegate () { flowLayoutPanelQLP.Controls.Add(bt); }));
                }
            }
        }
        void loadTT(string maphong)
        {
            lvTaiSan.Items.Clear();
            DataTable t;
            t = Phong_DAO.Instance.getTS(maphong);
            txtMaKhu.Clear();
            txtTTKhu.Clear();
            txtMaPhong.Clear();
            txtSLTD.Clear();
            txtTienPhong.Clear();
            txtSLDO.Clear();
            List<Phong_DTO> ttpList = Phong_DAO.Instance.getTTP(maphong);

            for (int i = 0; i < t.Rows.Count; i++)  //add list view
            {
                ListViewItem row = new ListViewItem(t.Rows[i][0].ToString());
                for (int j = 1; j < t.Columns.Count; j++)
                    row.SubItems.Add(t.Rows[i][j].ToString());
                lvTaiSan.Items.Add(row);
            }

            foreach (Phong_DTO item in ttpList)  //add text in button
            {
                txtMaKhu.Text = item.MAKHU;
                if (item.TINHTRANG == 1)
                {
                    txtTTKhu.Text = "Chưa thể ở được khu này";
                }
                else txtTTKhu.Text = "Có thể ở được";

                txtMaPhong.Text = item.MAPHONG;
                txtSLTD.Text = item.SLTD.ToString();
                txtTienPhong.Text = item.TIENPHONG.ToString();   //ToString("c");                     
                txtSLDO.Text = item.SONGUOIDANGO.ToString();
            }
        }
        void Bt_Click(object sender, EventArgs e)
        {
            string maphong = ((sender as Button).Tag as Phong_DTO).MAPHONG;
            loadTT(maphong);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            flowLayoutPanelQLP.SuspendLayout();
            flowLayoutPanelQLP.Controls.Clear();

            // Thread.Sleep(10);
            Thread thr1 = new Thread(loadPhongList);
            thr1.IsBackground = false;
            thr1.Start();

            flowLayoutPanelQLP.ResumeLayout();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || txtMaKhu.Text == "" || txtSLTD.Text == "" || txtTienPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
            }
            else
            {
                string maphong = txtMaPhong.Text;
                string makhu = txtMaKhu.Text;
                int sltd = Convert.ToSByte(txtSLTD.Text);
                int tienphong = Convert.ToInt32(txtTienPhong.Text);

                if (txtMaKhu.Text != txtMaPhong.Text.Substring(0, 2)) //|| tbMAPHONG.Text.Substring(0, 1) != "K")
                    MessageBox.Show("Mã phòng và mã khu khác nhau, vui lòng nhập lại!");
                else
                if (Phong_DAO.Instance.insertPhong(maphong, makhu, sltd, tienphong))
                {
                    MessageBox.Show("Thêm thành công.");
                    flowLayoutPanelQLP.Controls.Clear();

                    Thread.Sleep(1);
                    Thread thr2 = new Thread(loadPhongList);
                    thr2.IsBackground = true;
                    thr2.Start();
                }
                else
                    MessageBox.Show("Phòng đã tồn tại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || txtMaKhu.Text == "" || txtSLTD.Text == "" || txtTienPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào");
            }
            else
            {
                string maphong = txtMaPhong.Text;
                string makhu = txtMaKhu.Text;
                int sltd = Convert.ToSByte(txtSLTD.Text);
                int tienphong = Convert.ToInt32(txtTienPhong.Text);
                if (txtMaKhu.Text != txtMaPhong.Text.Substring(0, 2))
                    MessageBox.Show("Mã phòng và mã khu khác nhau, vui lòng nhập lại!");
                else
                    if (Phong_DAO.Instance.updatePhong(maphong, makhu, sltd, tienphong))
                {
                    MessageBox.Show("Sửa thành công.");
                }
                else
                    MessageBox.Show("Vui lòng nhập giá trị khác vào!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || txtMaKhu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào Khu và Phòng");
            }
            else
            {
                string maphong = txtMaPhong.Text;
                string makhu = txtMaKhu.Text;

                if (Phong_DAO.Instance.deletePhong(maphong))
                {
                    MessageBox.Show("Xóa thành công.");
                    flowLayoutPanelQLP.Controls.Clear();
                    Thread thr3 = new Thread(loadPhongList);
                    thr3.IsBackground = true;
                    thr3.Start();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "") MessageBox.Show("Vui lòng nhập giá trị vào 'Mã phòng'");
            else
                loadTT(txtMaPhong.Text);
        }

        private void FrmQLPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }
    }
}
