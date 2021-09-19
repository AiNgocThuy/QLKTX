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
	public partial class FrmQLNhanVien : Form
	{
        BindingSource nvList = new BindingSource();
        public FrmQLNhanVien()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dataGridViewNV.DataSource = nvList;
            loadNV();
            nvBinding();
        }

        void loadNV()   //dataGridViewNV
        {
            nvList.DataSource = NhanVien_DAO.Instance.NhanVien_DTO();
        }

        void nvBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dataGridViewNV.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dataGridViewNV.DataSource, "HOTENNV", true, DataSourceUpdateMode.Never));
            txtSDTNV.DataBindings.Add(new Binding("Text", dataGridViewNV.DataSource, "SDTNV", true, DataSourceUpdateMode.Never));
            cbKhuLamViec.DataBindings.Add(new Binding("Text", dataGridViewNV.DataSource, "MAKHU", true, DataSourceUpdateMode.Never));
        }

        public string getHo(string tendaydu)    // hàm lấy họ
        {
            string ho = tendaydu.Substring(0, tendaydu.LastIndexOf(" "));
            return ho;
        }
        public string getTen(string tendaydu)   //hàm lấy tên
        {
            string ten = tendaydu.Substring(tendaydu.LastIndexOf(" ") + 1);
            return ten;
        }

        void loadNVList(string manv)
        {
            txtTenNV.Clear();
            txtSDTNV.Clear();
            cbGTNV.SelectedIndex = -1;
            cbMaCV.SelectedIndex = -1;

            List<NhanVien_DTO> ttSVList = NhanVien_DAO.Instance.getNV(manv);
            foreach (NhanVien_DTO item in ttSVList)
            {
                txtTenNV.Text = item.HOTENNV;
                if (item.GTNV == "Nam") cbGTNV.SelectedIndex = 1; else cbGTNV.SelectedIndex = 0;
                txtSDTNV.Text = item.SDTNV;
                cbMaCV.SelectedItem = item.MACV;

            }

        }



        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbKhuLamViec.SelectedIndex = -1;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "")//|| //tbCHUCVU.Text == "") //|| tbKHU.Text == "")
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
            else
            {
                string manv = txtMaNV.Text;
                string honv = getHo(txtTenNV.Text);
                string tennv = getTen(txtTenNV.Text);
                bool gtnv;
                if (cbGTNV.SelectedIndex == 1) gtnv = true; else gtnv = false;
                string sdtnv = txtSDTNV.Text;
                string macv = cbMaCV.Text;
                string makhu = cbKhuLamViec.Text;

                if (cbKhuLamViec.SelectedIndex != -1 && (bool)DataBase.Instance.executeScalar("SELECT TINHTRANG FROM dbo.KHU WHERE MAKHU = '" + cbKhuLamViec.Text + "'") == true)
                    MessageBox.Show("Khu hiện đang có vấn đề, hãy chọn khu khác để làm việc!");
                else
                if (NhanVien_DAO.Instance.insertNhanVien(manv, honv, tennv, gtnv, makhu, macv, sdtnv))
                {
                    MessageBox.Show("Thêm thành công.");
                    loadNV();

                    cbKhuLamViec.SelectedIndex = -1;

                }
                else MessageBox.Show("Nhân viên hoặc khu làm việc đã tồn tại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "")
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
            else
            {
                string manv = txtMaNV.Text;
                string honv = getHo(txtTenNV.Text);
                string tennv = getTen(txtTenNV.Text);
                bool gtnv;
                if (cbGTNV.SelectedIndex == 1) gtnv = true; else gtnv = false;
                string sdtnv = txtSDTNV.Text;
                string macv = cbMaCV.Text;
                string makhu = cbKhuLamViec.Text;


                if (cbKhuLamViec.SelectedIndex != -1 && (bool)DataBase.Instance.executeScalar("SELECT TINHTRANGKHU FROM dbo.KHU WHERE MAKHU = '" + cbKhuLamViec.Text + "'") == true)
                    MessageBox.Show("Khu hiện đang có vấn đề, hãy chọn khu khác để làm việc!");
                else if (NhanVien_DAO.Instance.updateNhanVien(manv, honv, tennv, gtnv, makhu, macv, sdtnv))
                {
                    MessageBox.Show("Sửa thành công.");
                    loadNV();

                }
                else MessageBox.Show("Nhân viên hoặc khu làm việc đã tồn tại!");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string manv = txtMaNV.Text;

            if (NhanVien_DAO.Instance.deleteNhanVien(manv))
            {
                MessageBox.Show("Xóa thành công.");
                loadNV();
                cbKhuLamViec.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Đã xảy ra lỗi!");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                MessageBox.Show("Vui lòng nhập vào 'Mã NV'");
            else
            {
                loadNVList(txtMaNV.Text);
            }
        }

        private void cbTenCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaCV.SelectedIndex = cbTenCV.SelectedIndex;
        }

        private void cbMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenCV.SelectedIndex = cbMaCV.SelectedIndex;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if ((string)dataGridViewNV.SelectedCells[0].OwningRow.Cells["GTNV"].Value == "Nam")  //thay đổi giới tính
                cbGTNV.SelectedIndex = 1;
            else cbGTNV.SelectedIndex = 0;

            cbMaCV.SelectedItem = (string)dataGridViewNV.SelectedCells[0].OwningRow.Cells["MACV"].Value;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }
    }
}

