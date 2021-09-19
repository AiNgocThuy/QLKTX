
namespace QuanLy_KTX.QuanLy
{
	partial class FrmQLNhanVien
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewNV = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GTNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbTenCV = new System.Windows.Forms.ComboBox();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtSDTNV = new System.Windows.Forms.TextBox();
			this.cbKhuLamViec = new System.Windows.Forms.ComboBox();
			this.cbMaCV = new System.Windows.Forms.ComboBox();
			this.cbGTNV = new System.Windows.Forms.ComboBox();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNV = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewNV
			// 
			this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.TenNhanVien,
			this.GTNV,
			this.Column3,
			this.Column5,
			this.dt});
			this.dataGridViewNV.Location = new System.Drawing.Point(12, 263);
			this.dataGridViewNV.Name = "dataGridViewNV";
			this.dataGridViewNV.ReadOnly = true;
			this.dataGridViewNV.RowHeadersWidth = 51;
			this.dataGridViewNV.RowTemplate.Height = 29;
			this.dataGridViewNV.Size = new System.Drawing.Size(1180, 388);
			this.dataGridViewNV.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MANV";
			this.Column1.HeaderText = "Mã Nhân Viên";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 150;
			// 
			// TenNhanVien
			// 
			this.TenNhanVien.DataPropertyName = "HOTENNV";
			this.TenNhanVien.HeaderText = "Tên Nhân Viên";
			this.TenNhanVien.MinimumWidth = 6;
			this.TenNhanVien.Name = "TenNhanVien";
			this.TenNhanVien.ReadOnly = true;
			this.TenNhanVien.Width = 200;
			// 
			// GTNV
			// 
			this.GTNV.DataPropertyName = "GTNV";
			this.GTNV.HeaderText = "Giới Tính";
			this.GTNV.MinimumWidth = 6;
			this.GTNV.Name = "GTNV";
			this.GTNV.ReadOnly = true;
			this.GTNV.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "MAKHU";
			this.Column3.HeaderText = "Khu Làm Việc";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "TENCV";
			this.Column5.HeaderText = "Tên Chức Vụ";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 200;
			// 
			// dt
			// 
			this.dt.DataPropertyName = "SDTNV";
			this.dt.HeaderText = "Điện Thoại";
			this.dt.MinimumWidth = 6;
			this.dt.Name = "dt";
			this.dt.ReadOnly = true;
			this.dt.Width = 125;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(485, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Khu Làm Việc";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Giới Tính";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên Nhân Viên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Mã Nhân Viên";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbTenCV);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnLamMoi);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Controls.Add(this.txtSDTNV);
			this.panel1.Controls.Add(this.cbKhuLamViec);
			this.panel1.Controls.Add(this.cbMaCV);
			this.panel1.Controls.Add(this.cbGTNV);
			this.panel1.Controls.Add(this.txtTenNV);
			this.panel1.Controls.Add(this.txtMaNV);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(12, 91);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1180, 166);
			this.panel1.TabIndex = 6;
			// 
			// cbTenCV
			// 
			this.cbTenCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTenCV.FormattingEnabled = true;
			this.cbTenCV.Items.AddRange(new object[] {
			"Phó giám đốc",
			"Quản lý KTX",
			"Nhân viên vệ sinh",
			"Quản lý"});
			this.cbTenCV.Location = new System.Drawing.Point(667, 125);
			this.cbTenCV.Name = "cbTenCV";
			this.cbTenCV.Size = new System.Drawing.Size(151, 28);
			this.cbTenCV.TabIndex = 18;
			this.cbTenCV.SelectedIndexChanged += new System.EventHandler(this.cbTenCV_SelectedIndexChanged);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnSua.Location = new System.Drawing.Point(853, 106);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(110, 46);
			this.btnSua.TabIndex = 17;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnLamMoi.Location = new System.Drawing.Point(853, 11);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(110, 46);
			this.btnLamMoi.TabIndex = 16;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnXoa.Location = new System.Drawing.Point(1006, 106);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(110, 46);
			this.btnXoa.TabIndex = 15;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnThem.Location = new System.Drawing.Point(1006, 11);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(110, 46);
			this.btnThem.TabIndex = 14;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtSDTNV
			// 
			this.txtSDTNV.Location = new System.Drawing.Point(606, 0);
			this.txtSDTNV.Name = "txtSDTNV";
			this.txtSDTNV.Size = new System.Drawing.Size(151, 27);
			this.txtSDTNV.TabIndex = 13;
			// 
			// cbKhuLamViec
			// 
			this.cbKhuLamViec.FormattingEnabled = true;
			this.cbKhuLamViec.Items.AddRange(new object[] {
			"K1",
			"K2",
			"K3",
			"N1",
			"N2",
			"N3"});
			this.cbKhuLamViec.Location = new System.Drawing.Point(606, 63);
			this.cbKhuLamViec.Name = "cbKhuLamViec";
			this.cbKhuLamViec.Size = new System.Drawing.Size(151, 28);
			this.cbKhuLamViec.TabIndex = 12;
			// 
			// cbMaCV
			// 
			this.cbMaCV.FormattingEnabled = true;
			this.cbMaCV.Items.AddRange(new object[] {
			"CV001",
			"CV002",
			"CV003",
			"CV004"});
			this.cbMaCV.Location = new System.Drawing.Point(492, 125);
			this.cbMaCV.Name = "cbMaCV";
			this.cbMaCV.Size = new System.Drawing.Size(151, 28);
			this.cbMaCV.TabIndex = 11;
			this.cbMaCV.SelectedIndexChanged += new System.EventHandler(this.cbMaCV_SelectedIndexChanged);
			// 
			// cbGTNV
			// 
			this.cbGTNV.FormattingEnabled = true;
			this.cbGTNV.Items.AddRange(new object[] {
			"Nữ ",
			"Nam"});
			this.cbGTNV.Location = new System.Drawing.Point(125, 133);
			this.cbGTNV.Name = "cbGTNV";
			this.cbGTNV.Size = new System.Drawing.Size(151, 28);
			this.cbGTNV.TabIndex = 10;
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(125, 71);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(307, 27);
			this.txtTenNV.TabIndex = 9;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(125, 4);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(159, 27);
			this.txtMaNV.TabIndex = 8;
			this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(398, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Mã Chức Vụ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(492, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Điện Thoại";
			// 
			// lblNV
			// 
			this.lblNV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblNV.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNV.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblNV.Location = new System.Drawing.Point(0, 0);
			this.lblNV.Name = "lblNV";
			this.lblNV.Size = new System.Drawing.Size(1196, 88);
			this.lblNV.TabIndex = 7;
			this.lblNV.Text = "QUẢN LÝ NHÂN VIÊN";
			this.lblNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmQuanLyNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1196, 653);
			this.Controls.Add(this.lblNV);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridViewNV);
			this.Name = "FrmQLNhanVien";
			this.Text = "Quản lý nhân viên";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewNV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSDTNV;
		private System.Windows.Forms.ComboBox cbKhuLamViec;
		private System.Windows.Forms.ComboBox cbMaCV;
		private System.Windows.Forms.ComboBox cbGTNV;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label lblNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn GTNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dt;
		private System.Windows.Forms.ComboBox cbTenCV;
	}
}