
namespace QuanLy_KTX
{
	partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.QLSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.QLPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.QLDienNuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.QLNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DKPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChuyenPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TimKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.ThongTinToolStripMenuItem,
            this.TimKiemToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1160, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// trangChuToolStripMenuItem
			// 
			this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
			this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
			this.trangChuToolStripMenuItem.Text = "Trang Chủ";
			// 
			// quảnLýToolStripMenuItem
			// 
			this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLSVToolStripMenuItem,
            this.QLPhongToolStripMenuItem,
            this.QLDienNuocToolStripMenuItem,
            this.QLNVToolStripMenuItem});
			this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
			this.quảnLýToolStripMenuItem.Text = "Quản Lý";
			// 
			// QLSVToolStripMenuItem
			// 
			this.QLSVToolStripMenuItem.Name = "QLSVToolStripMenuItem";
			this.QLSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.QLSVToolStripMenuItem.Text = "Quản Lý Sinh Viên";
			this.QLSVToolStripMenuItem.Click += new System.EventHandler(this.QLSVToolStripMenuItem_Click);
			// 
			// QLPhongToolStripMenuItem
			// 
			this.QLPhongToolStripMenuItem.Name = "QLPhongToolStripMenuItem";
			this.QLPhongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.QLPhongToolStripMenuItem.Text = "Quản Lý Phòng";
			this.QLPhongToolStripMenuItem.Click += new System.EventHandler(this.QLPhongToolStripMenuItem_Click);
			// 
			// QLDienNuocToolStripMenuItem
			// 
			this.QLDienNuocToolStripMenuItem.Name = "QLDienNuocToolStripMenuItem";
			this.QLDienNuocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.QLDienNuocToolStripMenuItem.Text = "Quản Lý Điện Nước";
			this.QLDienNuocToolStripMenuItem.Click += new System.EventHandler(this.QLDienNuocToolStripMenuItem_Click);
			// 
			// QLNVToolStripMenuItem
			// 
			this.QLNVToolStripMenuItem.Name = "QLNVToolStripMenuItem";
			this.QLNVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.QLNVToolStripMenuItem.Text = "Quản Lý Nhân Viên";
			this.QLNVToolStripMenuItem.Click += new System.EventHandler(this.QLNVToolStripMenuItem_Click);
			// 
			// phòngToolStripMenuItem
			// 
			this.phòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DKPhongToolStripMenuItem,
            this.ChuyenPhongToolStripMenuItem});
			this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
			this.phòngToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.phòngToolStripMenuItem.Text = "Phòng";
			// 
			// DKPhongToolStripMenuItem
			// 
			this.DKPhongToolStripMenuItem.Name = "DKPhongToolStripMenuItem";
			this.DKPhongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.DKPhongToolStripMenuItem.Text = "Đăng Ký Phòng";
			this.DKPhongToolStripMenuItem.Click += new System.EventHandler(this.DKPhongToolStripMenuItem_Click);
			// 
			// ChuyenPhongToolStripMenuItem
			// 
			this.ChuyenPhongToolStripMenuItem.Name = "ChuyenPhongToolStripMenuItem";
			this.ChuyenPhongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.ChuyenPhongToolStripMenuItem.Text = "Chuyển Phòng ";
			this.ChuyenPhongToolStripMenuItem.Click += new System.EventHandler(this.ChuyenPhongToolStripMenuItem_Click);
			// 
			// ThongTinToolStripMenuItem
			// 
			this.ThongTinToolStripMenuItem.Name = "ThongTinToolStripMenuItem";
			this.ThongTinToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
			this.ThongTinToolStripMenuItem.Text = "Thông Tin";
			this.ThongTinToolStripMenuItem.Click += new System.EventHandler(this.ThongTinToolStripMenuItem_Click);
			// 
			// TimKiemToolStripMenuItem
			// 
			this.TimKiemToolStripMenuItem.Name = "TimKiemToolStripMenuItem";
			this.TimKiemToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.TimKiemToolStripMenuItem.Text = " Tìm Kiếm";
			this.TimKiemToolStripMenuItem.Click += new System.EventHandler(this.TimKiemToolStripMenuItem_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1160, 525);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmMain";
			this.Text = "Màn hình chính";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ThongTinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TimKiemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem QLSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem QLPhongToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem QLDienNuocToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem QLNVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DKPhongToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ChuyenPhongToolStripMenuItem;
	}
}

