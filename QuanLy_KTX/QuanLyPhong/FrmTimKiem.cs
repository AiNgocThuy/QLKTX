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
	public partial class FrmTimKiem : Form
	{
        public FrmTimKiem()
        {
            InitializeComponent();

            bindingComboBox();
        }

        void bindingComboBox()
        {
            //cbTimKiem.DataSource = DataBase.Instance.executeQuery("");
            cbTimKiem.Items.Add("Sinh viên"); //0
            cbTimKiem.Items.Add("Gia Đình"); // 1
            cbTimKiem.Items.Add("Phòng"); // 2
            cbTimKiem.Items.Add("Khu");// 3
            cbTimKiem.Items.Add("Thông tin điện");// 4
            cbTimKiem.Items.Add("Thông tin nước");// 5
            cbTimKiem.Items.Add("Nhân Viên");//6
            cbTimKiem.SelectedIndex = 0;


        }

        void loadTimKiem()
        {
            string thaythe = "";
            if (cbTimKiem.Text == "") MessageBox.Show("Vui lòng chọn mục tìm kiếm");
            else
            {
                if (cbTimKiem.SelectedIndex == 0)//cbTimKiem.Text == "Sinh viên"
                {
                    thaythe = "SINHVIEN";
                    dGTimKiem.DataSource = DataBase.Instance.executeQuery("SELECT MASV AS 'Mã sinh viên', MALOP AS N'Lớp', MAPHONG AS N'Mã Phòng', HOSV +' '+ TENSV AS N'Họ tên', NGAYSINH as N'Ngày Sinh', CASE WHEN GTSV = 1 THEN N'Nữ' else N'Nam' END AS N'Giới tính', QUEQUAN AS N'Quê Quán', CMND, DTSV AS N'Điện thoại', DANTOC AS N'Dân tộc' FROM dbo." + thaythe + " WHERE dbo.fuConvertToUnsign1(MASV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(MALOP) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(MAPHONG) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(HOSV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(TENSV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(NGAYSINH) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(GTSV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(QUEQUAN) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(CMND) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(DTSV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(DANTOC) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%'");

                }
                else
                {
                    if (cbTimKiem.SelectedIndex == 1)
                    {
                        thaythe = "GIADINH";
                        dGTimKiem.DataSource = DataBase.Instance.executeQuery("SELECT MAGD AS N'Mã Gia Đình',TENNGUOITHAN AS N'Tên Người Thân',CASE WHEN GTNT = 1 THEN N'Nữ' else N'Nam' END AS N'Giới tính',DIACHINT AS N'Địa Chỉ',SDTNT AS 'Điện Thoại' FROM dbo." + thaythe + " WHERE dbo.fuConvertToUnsign1(MAGD) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(TENNGUOITHAN) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(GTNT) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(DIACHINT) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(SDTNT) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%'");
                    }
                    else
                    {
                        if (cbTimKiem.SelectedIndex == 2)
                        {
                            thaythe = "PHONG";
                            dGTimKiem.DataSource = DataBase.Instance.executeQuery("SELECT MAPHONG AS N'Mã Phòng',MAKHU AS N'Mã Khu',SLTD AS N'SLTối Đa',TIENPHONG AS N'Tiền Phòng' FROM dbo." + thaythe + " WHERE dbo.fuConvertToUnsign1(MAPHONG) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(MAKHU) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(SLTD) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(TIENPHONG) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%'");
                        }
                        else
                        {
                            if (cbTimKiem.SelectedIndex == 3)
                            {
                                thaythe = "KHU";
                                dGTimKiem.DataSource = DataBase.Instance.executeQuery("SELECT MAKHU AS N'Mã Khu', CASE WHEN TINHTRANG = 1 THEN N'Không ở được' else N'Có thể ở' END N'Tình trạng',VITRI AS N'Vị Trí',MOTA AS N'Mô Tả' FROM dbo." + thaythe + " WHERE dbo.fuConvertToUnsign1(MAKHU) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(TINHTRANG) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(VITRI) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(MOTA) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%'");
                            }
                            else
                            {
                                if (cbTimKiem.SelectedIndex == 4)
                                {
                                    thaythe = "DIEN";
                                    dGTimKiem.DataSource = DataBase.Instance.executeQuery("SELECT MADIEN AS N'Mã Điện', MAPHONG AS N'Mã phòng',THANG AS N'Tháng', NAM AS N'Năm',CSDK,CSCK FROM dbo." + thaythe + " WHERE dbo.fuConvertToUnsign1(MADIEN) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(THANG) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(NAM) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(MAPHONG) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(CSDK) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(CSCK) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%'");
                                }
                                else
                                {
                                    if (cbTimKiem.SelectedIndex == 5)
                                    {
                                        thaythe = "NUOC";
                                        dGTimKiem.DataSource = DataBase.Instance.executeQuery("SELECT * FROM dbo." + thaythe + " WHERE dbo.fuConvertToUnsign1(MANUOC) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(THANGN) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(NAMN) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(MAPHONG) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(CSDKN) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(CSCKN) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%'");
                                    }
                                    else
                                    {
                                        if (cbTimKiem.SelectedIndex == 6)
                                        {
                                            thaythe = "NHANVIEN";
                                            dGTimKiem.DataSource = DataBase.Instance.executeQuery("SELECT * FROM dbo." + thaythe + " WHERE dbo.fuConvertToUnsign1(MANV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(MACV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(HONV+' '+TENNV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(GTNV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%' OR dbo.fuConvertToUnsign1(SDTNV) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTuKhoa.Text + "') + '%'");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            loadTimKiem();
            //if (dgvTimKiem.InvokeRequired)
            //{
            //dgvTimKiem.Invoke(new MethodInvoker(delegate { loadTimKiem(); }));
            //}
        }
    }
}