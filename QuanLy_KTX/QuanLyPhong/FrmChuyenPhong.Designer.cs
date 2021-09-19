

namespace QuanLy_KTX.QuanLyPhong
{
	partial class FrmChuyenPhong
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblMaSV = new System.Windows.Forms.Label();
			this.lblMaPM = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaSV = new System.Windows.Forms.TextBox();
			this.txtMaPM = new System.Windows.Forms.TextBox();
			this.dGVSinhVien = new System.Windows.Forms.DataGridView();
			this.btnChuyen = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TENSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1017, 66);
			this.label1.TabIndex = 0;
			this.label1.Text = "CHUYỂN PHÒNG";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMaSV
			// 
			this.lblMaSV.AutoSize = true;
			this.lblMaSV.Location = new System.Drawing.Point(717, 151);
			this.lblMaSV.Name = "lblMaSV";
			this.lblMaSV.Size = new System.Drawing.Size(95, 20);
			this.lblMaSV.TabIndex = 1;
			this.lblMaSV.Text = "Mã Sinh Viên";
			// 
			// lblMaPM
			// 
			this.lblMaPM.AutoSize = true;
			this.lblMaPM.Location = new System.Drawing.Point(717, 215);
			this.lblMaPM.Name = "lblMaPM";
			this.lblMaPM.Size = new System.Drawing.Size(106, 20);
			this.lblMaPM.TabIndex = 2;
			this.lblMaPM.Text = "Mã Phòng Mới";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(717, 319);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Khu Nam : N1, N2, N3";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(717, 381);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Khu Nữ : K1, K2, K3";
			// 
			// txtMaSV
			// 
			this.txtMaSV.Location = new System.Drawing.Point(835, 144);
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(149, 27);
			this.txtMaSV.TabIndex = 5;
			// 
			// txtMaPM
			// 
			this.txtMaPM.Location = new System.Drawing.Point(835, 208);
			this.txtMaPM.Name = "txtMaPM";
			this.txtMaPM.Size = new System.Drawing.Size(149, 27);
			this.txtMaPM.TabIndex = 6;
			// 
			// dGVSinhVien
			// 
			this.dGVSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.MASV,
			this.TENSV,
			this.GIOITINH});
			this.dGVSinhVien.Location = new System.Drawing.Point(0, 69);
			this.dGVSinhVien.Name = "dGVSinhVien";
			this.dGVSinhVien.ReadOnly = true;
			this.dGVSinhVien.RowHeadersWidth = 51;
			this.dGVSinhVien.RowTemplate.Height = 29;
			this.dGVSinhVien.Size = new System.Drawing.Size(648, 432);
			this.dGVSinhVien.TabIndex = 7;
			// 
			// btnChuyen
			// 
			this.btnChuyen.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnChuyen.Location = new System.Drawing.Point(892, 262);
			this.btnChuyen.Name = "btnChuyen";
			this.btnChuyen.Size = new System.Drawing.Size(104, 42);
			this.btnChuyen.TabIndex = 8;
			this.btnChuyen.Text = "Chuyển";
			this.btnChuyen.UseVisualStyleBackColor = false;
			this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MAPHONG";
			this.Column1.HeaderText = "Mã Phòng";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// MASV
			// 
			this.MASV.DataPropertyName = "MASV";
			this.MASV.HeaderText = "Mã Sinh Viên";
			this.MASV.MinimumWidth = 6;
			this.MASV.Name = "MASV";
			this.MASV.ReadOnly = true;
			this.MASV.Width = 125;
			// 
			// TENSV
			// 
			this.TENSV.DataPropertyName = "Tên Sinh Viên";
			this.TENSV.HeaderText = "Tên Sinh Viên";
			this.TENSV.MinimumWidth = 6;
			this.TENSV.Name = "TENSV";
			this.TENSV.ReadOnly = true;
			this.TENSV.Width = 220;
			// 
			// GIOITINH
			// 
			this.GIOITINH.DataPropertyName = "GIOITINH";
			this.GIOITINH.HeaderText = "Giới Tính";
			this.GIOITINH.MinimumWidth = 6;
			this.GIOITINH.Name = "GIOITINH";
			this.GIOITINH.ReadOnly = true;
			this.GIOITINH.Width = 125;
			// 
			// FrmChuyenPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1017, 502);
			this.Controls.Add(this.btnChuyen);
			this.Controls.Add(this.dGVSinhVien);
			this.Controls.Add(this.txtMaPM);
			this.Controls.Add(this.txtMaSV);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMaPM);
			this.Controls.Add(this.lblMaSV);
			this.Controls.Add(this.label1);
			this.Name = "FrmChuyenPhong";
			this.Text = "Chuyển Phòng";
			((System.ComponentModel.ISupportInitialize)(this.dGVSinhVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMaSV;
		private System.Windows.Forms.Label lblMaPM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaSV;
		private System.Windows.Forms.TextBox txtMaPM;
		private System.Windows.Forms.DataGridView dGVSinhVien;
		private System.Windows.Forms.Button btnChuyen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TENSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
	}
}