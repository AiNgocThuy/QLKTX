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

namespace QuanLy_KTX.QuanLyPhong
{
    public partial class FrmChuyenPhong : Form
    {
        BindingSource svList = new BindingSource();
        public FrmChuyenPhong()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dGVSinhVien.DataSource = svList;
            loadSVList();
            svBinding();
        }

        void loadSVList()
        {
            //svList.DataSource = sinhvienDAO.Instance.sinhvien();  //khi thay đổi datasource thì nó thay đổi theo    
            svList.DataSource = DataBase.Instance.executeQuery("SELECT MASV,HOSV+' '+TENSV AS N'Tên Sinh Viên', MAPHONG,CASE WHEN GTSV = 1 THEN N'Nam' ELSE N'Nữ' END AS GIOITINH FROM dbo.SINHVIEN WHERE MAPHONG IS NOT NULL ORDER BY MAPHONG,TENSV");
        }

        void svBinding()
        {
            txtMaSV.DataBindings.Add(new Binding("Text", dGVSinhVien.DataSource, "MASV", true, DataSourceUpdateMode.Never));
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if ((int)DataBase.Instance.executeScalar("SELECT COUNT(*) FROM dbo.SINHVIEN WHERE MASV = '" + txtMaSV.Text + "' AND MAPHONG = '" + txtMaPM.Text + "'") == 1)
                MessageBox.Show("Vui lòng chọn phòng mới");
            else
            {
                if (txtMaSV.Text != (string)DataBase.Instance.executeScalar("SELECT MASV FROM dbo.SINHVIEN WHERE MASV = '" + txtMaSV.Text + "'"))
                    MessageBox.Show("Sinh viên không tồn tại!");
                else
                if (txtMaPM.Text != (string)DataBase.Instance.executeScalar("SELECT MAPHONG FROM dbo.PHONG WHERE MAPHONG ='" + txtMaPM.Text + "'"))
                    MessageBox.Show("Phòng không tồn tại!");
                else
                {
                    if ((bool)DataBase.Instance.executeScalar("SELECT GTSV FROM dbo.SINHVIEN WHERE MASV = '" + txtMaSV.Text + "'") == false && ((string)DataBase.Instance.executeScalar("SELECT SUBSTRING(MAPHONG,1, 2) FROM dbo.PHONG WHERE MAPHONG = '" + txtMaPM.Text + "'") == "K1" || (string)DataBase.Instance.executeScalar("SELECT SUBSTRING(MAPHONG,1, 2) FROM dbo.PHONG WHERE MAPHONG = '" + txtMaPM.Text + "'") == "K2" || (string)DataBase.Instance.executeScalar("SELECT SUBSTRING(MAPHONG,1, 2)FROM dbo.PHONG WHERE MAPHONG = '" + txtMaPM.Text + "'") == "K3"))
                        MessageBox.Show("Sinh viên nữ nên vào khu nữ!");
                    else
                    if ((bool)DataBase.Instance.executeScalar("SELECT GTSV FROM dbo.SINHVIEN WHERE MASV = '" + txtMaSV.Text + "'") == true && ((string)DataBase.Instance.executeScalar("SELECT SUBSTRING(MAPHONG,1, 2) FROM dbo.PHONG WHERE MAPHONG = '" + txtMaPM.Text + "'") == "N1" || (string)DataBase.Instance.executeScalar("SELECT SUBSTRING(MAPHONG,1, 2) FROM dbo.PHONG WHERE MAPHONG = '" + txtMaPM.Text + "'") == "N2" || (string)DataBase.Instance.executeScalar("SELECT SUBSTRING(MAPHONG,1, 2) FROM dbo.PHONG WHERE MAPHONG = '" + txtMaPM.Text + "'") == "N3"))
                        MessageBox.Show("Sinh viên nam nên vào khu nam!");
                    else
                        if (SinhVien_DAO.Instance.chuyenPhong(txtMaSV.Text, txtMaPM.Text))
                    {
                        MessageBox.Show("Chuyển phòng thành công.");
                        loadSVList();
                        txtMaSV.Clear(); txtMaPM.Clear();
                    }
                    else MessageBox.Show("Phòng đã đầy!");
                }
            }
        }
    }
}
