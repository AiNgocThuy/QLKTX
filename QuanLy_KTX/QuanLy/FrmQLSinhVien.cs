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
    public partial class FrmQuanLySV : Form
    {
        BindingSource nvList = new BindingSource();
        public FrmQuanLySV()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dGViewSinhVien.DataSource = nvList;

            loadSVList();

            svBinding();

        }
        void loadSVList()   //dgvNhanVien
        {
            nvList.DataSource = SinhVien_DAO.Instance.SinhVien_DTO();
        }

        void getTNList(string masv) // hiển thị List view Thân nhân
        {
            lvGiaDinh.Items.Clear();
            DataTable tn;
            tn = SinhVien_DAO.Instance.getTN(masv);
            for (int i = 0; i < tn.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem(tn.Rows[i][0].ToString());
                for (int j = 1; j < tn.Columns.Count; j++)
                    row.SubItems.Add(tn.Rows[i][j].ToString());
                lvGiaDinh.Items.Add(row);
            }
        }

        void getSVList(string masv)
        {

            txtHovaTen.Clear();
            txtLop.Clear();
            txtNgaySinh.Clear();
            txtQueQuan.Clear();
            txtCMND.Clear();
            txtSDT.Clear();
            txtDanToc.Clear();

            List<SinhVien_DTO> ttSVList = SinhVien_DAO.Instance.getSV(masv);
            foreach (SinhVien_DTO item in ttSVList)
            {
                txtHovaTen.Text = item.HOTENSV;
                txtLop.Text = item.MALOP;
                cbKhoa.SelectedItem = item.MAKHOA;
                txtNgaySinh.Text = Convert.ToString(item.NGAYSINH);
                //
                if (item.GIOITINH == "Nam") cbGioiTinh.SelectedIndex = 1;
                else cbGioiTinh.SelectedIndex = 0;
                txtQueQuan.Text = item.QUEQUAN;
                txtCMND.Text = item.CMND;
                txtSDT.Text = item.DTSV;
                txtDanToc.Text = item.DANTOC;
            }
        }

        //void loadKhoaIntoCombobox(ComboBox cb)
        //{
        //    DataTable khoalist = DataProvider.Instance.executeQuery("SELECT MAKHOA FROM KHOA");
        //    foreach (var v in khoalist.Rows)
        //    {
        //        cbKHOA.Items.Add(v.ToString());
        //    }
        //    //cb.DataSource = DataProvider.Instance.executeQuery("SELECT MAKHOA FROM KHOA");
        //    cb.DisplayMember = "MAKHOA";
        //}

        void svBinding()    //kỹ thuật Binding
        {
            txtMSSV.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "MASV", true, DataSourceUpdateMode.Never));
            txtHovaTen.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "HOTENSV", true, DataSourceUpdateMode.Never));
            txtLop.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "MALOP", true, DataSourceUpdateMode.Never));
            txtPhong.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "MAPHONG", true, DataSourceUpdateMode.Never));
            txtNgaySinh.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
            txtQueQuan.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "QUEQUAN", true, DataSourceUpdateMode.Never));
            // tbQUOCTIC.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "QUOCTICH", true, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "DTSV", true, DataSourceUpdateMode.Never));
            txtDanToc.DataBindings.Add(new Binding("Text", dGViewSinhVien.DataSource, "DANTOC", true, DataSourceUpdateMode.Never));
            //tbTONGIAO.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "TONGIAO", true, DataSourceUpdateMode.Never));
            //loadKhoaIntoCombobox(cbKHOA);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masv = txtMSSV.Text;
            if (SinhVien_DAO.Instance.deleteSinhVien(masv))
            {
                MessageBox.Show("Xóa thành công.");
                // pbSV.ImageLocation = null;
                //dgvSV.Refresh();
                loadSVList();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadSVList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtHovaTen.Text == "" || txtLop.Text == "" || cbKhoa.Text == "" || txtNgaySinh.Text == "")
                MessageBox.Show("Vui lòng nhập giá trị vào");
            else
            {
                string masv = txtMSSV.Text;
                string malop = txtLop.Text;
                string maphong = txtPhong.Text;
                string hosv = getHo(txtHovaTen.Text);
                string tensv = getTen(txtHovaTen.Text);
                DateTime ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
                //if ((string)dgvSV.SelectedCells[0].OwningRow.Cells["GIOITINH"].Value == "Nam")  //thay đổi giới tính  
                bool gtsv;
                if (cbGioiTinh.SelectedIndex == 1) gtsv = true; else gtsv = false;
                string quequan = txtQueQuan.Text;
                string cmnd = txtCMND.Text;
                string dtsv = txtSDT.Text;
                string dantoc = txtDanToc.Text;
                string makhoa = cbKhoa.Text;

                if (SinhVien_DAO.Instance.updateSinhVien(masv, hosv, tensv, malop, maphong, ngaysinh, gtsv, quequan, cmnd, dtsv, dantoc, makhoa))
                {
                    MessageBox.Show("Sửa thành công.");

                    loadSVList();
                }
                else MessageBox.Show("Vui lòng nhập giá trị khác vào!");

                //loadSVList();

            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            getSVList(txtMSSV.Text);
        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {
            cbKhoa.SelectedItem = (string)dGViewSinhVien.SelectedCells[0].OwningRow.Cells["MAKHOA"].Value;
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            getTNList(txtMSSV.Text);

            if ((string)dGViewSinhVien.SelectedCells[0].OwningRow.Cells["GIOITINH"].Value == "Nam")  //thay đổi giới tính
                cbGioiTinh.SelectedIndex = 1;
            else cbGioiTinh.SelectedIndex = 0;
        }
    }
}
