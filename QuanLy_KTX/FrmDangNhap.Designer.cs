
namespace QuanLy_KTX
{
	partial class FrmDangNhap
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
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.lblTaiKhoan = new System.Windows.Forms.Label();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.lblMatKhau = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.labelDangNhap = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDangNhap.Location = new System.Drawing.Point(29, 316);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(200, 62);
			this.btnDangNhap.TabIndex = 0;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// lblTaiKhoan
			// 
			this.lblTaiKhoan.AutoSize = true;
			this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTaiKhoan.Location = new System.Drawing.Point(30, 145);
			this.lblTaiKhoan.Name = "lblTaiKhoan";
			this.lblTaiKhoan.Size = new System.Drawing.Size(111, 31);
			this.lblTaiKhoan.TabIndex = 1;
			this.lblTaiKhoan.Text = "Tài Khoản";
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtTaiKhoan.Location = new System.Drawing.Point(168, 129);
			this.txtTaiKhoan.Multiline = true;
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(287, 47);
			this.txtTaiKhoan.TabIndex = 2;
			this.txtTaiKhoan.Text = "ADMIN";
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtMatKhau.Location = new System.Drawing.Point(168, 234);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(287, 47);
			this.txtMatKhau.TabIndex = 3;
			this.txtMatKhau.Text = "123456";
			// 
			// lblMatKhau
			// 
			this.lblMatKhau.AutoSize = true;
			this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMatKhau.Location = new System.Drawing.Point(29, 250);
			this.lblMatKhau.Name = "lblMatKhau";
			this.lblMatKhau.Size = new System.Drawing.Size(112, 31);
			this.lblMatKhau.TabIndex = 4;
			this.lblMatKhau.Text = "Mật Khẩu";
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnThoat.Location = new System.Drawing.Point(255, 316);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(200, 62);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// labelDangNhap
			// 
			this.labelDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDangNhap.Location = new System.Drawing.Point(0, 0);
			this.labelDangNhap.Name = "labelDangNhap";
			this.labelDangNhap.Size = new System.Drawing.Size(491, 65);
			this.labelDangNhap.TabIndex = 6;
			this.labelDangNhap.Text = "ĐĂNG NHẬP";
			this.labelDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmDangNhap
			// 
			this.AcceptButton = this.btnDangNhap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 410);
			this.Controls.Add(this.labelDangNhap);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.lblMatKhau);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.lblTaiKhoan);
			this.Controls.Add(this.btnDangNhap);
			this.Name = "FrmDangNhap";
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.FrmDangNhap_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Label lblTaiKhoan;
		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label lblMatKhau;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Label labelDangNhap;
	}
}