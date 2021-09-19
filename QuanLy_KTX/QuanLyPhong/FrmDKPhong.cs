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

namespace QuanLy_KTX.QuanLyPhong
{
    public partial class FrmDangKyPhong : Form
    {
        BindingSource nvList = new BindingSource();
        BindingSource khoaList = new BindingSource();
        public FrmDangKyPhong()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            loadSource();
            loadCBMANV(cbTenNV);
            loadCBKHOA(cbKhoa);
            //loadNamList();
        }

        void loadSource()
        {
            nvList.DataSource = DataBase.Instance.executeQuery("SELECT MANV FROM dbo.NHANVIEN WHERE MACV IN ('CV001', 'CV002','CV003','CV004') ORDER BY MANV");
            khoaList.DataSource = DataBase.Instance.executeQuery("SELECT MAKHOA FROM dbo.KHOA ORDER BY MAKHOA");
        }
        void loadCBMANV(ComboBox cb)
        {
            cb.DataSource = nvList.DataSource;
            cb.DisplayMember = "MANV";
        }
        void loadCBKHOA(ComboBox cb)
        {
            cb.DataSource = khoaList.DataSource;
            cb.DisplayMember = "MAKHOA"; cb.ValueMember = "MAKHOA";
        }

        bool check = true;
        async void loadNamList()
        {
            List<Phong_DTO> phongList = Phong_DAO.Instance.phongDKChoNam();
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
                    bt.Text = item.MAPHONG + Environment.NewLine + "Đang có: " + item.SONGUOIDANGO + "/" + item.SLTD;
                    bt.BackColor = Color.Aquamarine;
                }
                bt.Click += Bt_Click; bt.Tag = item;

                await Task.Delay(1);

                if (check == false)
                    break;
                else
                    flowLayoutPanelPhong.Controls.Add(bt);

            }
            check = false;
        }
        public void btnDung_Click(object sender, EventArgs e)
        {
            check = false;
            flowLayoutPanelPhong.Controls.Clear();
        }
        private void btnNam_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                flowLayoutPanelPhong.SuspendLayout();
                flowLayoutPanelPhong.Controls.Clear();
                flowLayoutPanelPhong.ResumeLayout();
                check = true;
                loadNamList();
            }
            else
            {
                check = false;
                btnDung.PerformClick();
                btnNam_Click(this, null);
            }
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            string maphong = ((sender as Button).Tag as Phong_DTO).MAPHONG;
            loadTT(maphong);
        }   //bt của khu nam


        async void loadNuList()
        {

            List<Phong_DTO> phongList = Phong_DAO.Instance.phongDKChoNu();
            foreach (Phong_DTO item in phongList)
            {
                if (check == false)
                    break;
                else
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
                        bt.Text = item.MAPHONG + Environment.NewLine + "Đang có: " + item.SONGUOIDANGO + "/" + item.SLTD;
                        bt.BackColor = Color.Aquamarine;
                    }
                    bt.Click += Bt_Click1; bt.Tag = item;
                    await Task.Delay(2);
                    flowLayoutPanelPhong.Controls.Add(bt);

                }
            }
            check = false;
        }

        private void Bt_Click1(object sender, EventArgs e)
        {
            string maphong = ((sender as Button).Tag as Phong_DTO).MAPHONG;
            loadTT(maphong);
        }   //bt của khu nữ

        private void btnNu_Click(object sender, EventArgs e)
        {


            if (check == false)
            {
                flowLayoutPanelPhong.SuspendLayout();
                flowLayoutPanelPhong.Controls.Clear();
                flowLayoutPanelPhong.ResumeLayout();
                check = true;
                loadNuList();
            }
            else
            {
                check = false;
                btnNu_Click(this, null);
            }
        }

        void loadTT(string maphong)
        {
            txtMaKhu.Clear();
            txtMaPhong.Clear();
            txtSLTD.Clear();
            txtTienPhong.Clear();
            List<Phong_DTO> ttpList = Phong_DAO.Instance.getTTP(maphong);
            foreach (Phong_DTO item in ttpList)
            {
                txtMaKhu.Text = item.MAKHU;
                txtMaPhong.Text = item.MAPHONG;
                txtSLTD.Text = item.SLTD.ToString();
                txtTienPhong.Text = item.TIENPHONG.ToString();   //ToString("c");           
                //tbSNDO.Text = item.SONGUOIDANGO.ToString();
            }
        }
        void loadTENKHOA(string makhoa)
        {
            txtTenKhoa.Clear();
            List<Khoa_DTO> tenkhoaList = Khoa_DAO.Instance.getTENKHOA(makhoa);
            foreach (Khoa_DTO item in tenkhoaList)
            {
                txtTenKhoa.Text = item.TENKHOA;
            }

        }
        private void cbKhoa_TextChanged_1(object sender, EventArgs e)
        {
            loadTENKHOA(cbKhoa.Text);
        }

        void getSVList(string masv)
        {
            List<SinhVien_DTO> ttSVList = SinhVien_DAO.Instance.getSV(masv);
            foreach (SinhVien_DTO item in ttSVList)
            {
                if (txtMSSV.Text == item.MASV)
                {
                    MessageBox.Show("Sinh viên đã tồn tại");
                    txtMSSV.Clear();
                    return;
                }
            }
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            getSVList(txtMSSV.Text);
        }

        public string getHo(string tendaydu)
        {
            string ho = tendaydu.Substring(0, tendaydu.LastIndexOf(" "));
            return ho;
            //string ten = tam.Substring(tam.LastIndexOf(" ") + 1);
            //textBox1.Text = ho;
            //textBox2.Text = ten;
        }
        public string getTen(string tendaydu)
        {
            string ten = tendaydu.Substring(tendaydu.LastIndexOf(" ") + 1);
            return ten;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtHovaTen.Text == "" || txtLop.Text == "" || cbKhoa.Text == "" || txtNgaySinh.Text == "" || cbGioiTinh.Text == "" || txtQueQuan.Text == "" | txtTenGD.Text == "" || cbGioiTinhGD.Text == "" || txtDiaChiGD.Text == "" || txtMaPhong.Text == "" || cbTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin vào");
            }
            else
            {
                string masv = txtMSSV.Text;
                string hosv = getHo(txtHovaTen.Text);
                string tensv = getTen(txtHovaTen.Text);
                string malop = txtLop.Text; string tennganh = txtTenNganh.Text;
                string makhoa = cbKhoa.Text; string tenkhoa = txtTenKhoa.Text;
                //DateTime ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
                DateTime ngaysinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null);
                bool gtsv;
                if (cbGioiTinh.SelectedIndex == 1) gtsv = true; else gtsv = false;
                string quequan = txtQueQuan.Text;
                string cmnd = txtCMND.Text;
                string dtsv = txtSDT.Text;
                string dantoc = txtDanToc.Text;

                string tennt = txtTenGD.Text;
                bool gtnt; if (cbGioiTinhGD.SelectedIndex == 1) gtnt = true; else gtnt = false;
                string diachitn = txtDiaChiGD.Text;
                string dttn = txtSDTGD.Text;
                string mqh = txtQuanHeGD.Text;

                string maphong = txtMaPhong.Text;

                DateTime ngaylap = dateTimePicker1.Value;
                string manv = cbTenNV.Text;

                if (SinhVien_DAO.Instance.insertSinhVien(masv, hosv, tensv, malop, tennganh, makhoa, maphong, tenkhoa, ngaysinh, gtsv, quequan, cmnd, dtsv, dantoc, tennt, gtnt, diachitn, dttn, mqh, ngaylap, manv))
                {
                    MessageBox.Show("Đăng ký thành công.");
                    //tbMASV.Clear();
                    txtHovaTen.Clear(); txtLop.Clear(); txtTenNganh.Clear(); cbKhoa.SelectedIndex = -1; txtNgaySinh.Clear(); cbGioiTinh.SelectedIndex = -1; txtQueQuan.Clear(); txtCMND.Clear(); txtSDT.Clear(); txtDanToc.Clear(); txtTenGD.Clear(); cbGioiTinhGD.SelectedIndex = -1; txtDiaChiGD.Clear(); txtSDTGD.Clear(); txtQuanHeGD.Clear(); txtMaKhu.Clear(); txtMaPhong.Clear(); txtSLTD.Clear(); txtTienPhong.Clear(); cbTenNV.SelectedIndex = -1;
                    flowLayoutPanelPhong.Controls.Clear();
                }
                else MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGioiTinh.SelectedIndex == 1)
            {
                btnNam.Enabled = true;
                btnNu.Enabled = false;
                flowLayoutPanelPhong.Controls.Clear();
                btnNam_Click(this, null);
            }
            else
            if (cbGioiTinh.SelectedIndex == 0)
            {
                btnNam.Enabled = false;
                btnNu.Enabled = true;
                flowLayoutPanelPhong.Controls.Clear();
                btnNu_Click(this, null);
            }
            else
            {
                btnNam.Enabled = true;
                btnNu.Enabled = true;
                flowLayoutPanelPhong.Controls.Clear();
            }
        }

        private void FrmDangKyPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            check = false;
        }


    }
}