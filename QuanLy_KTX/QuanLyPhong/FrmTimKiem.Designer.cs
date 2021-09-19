
namespace QuanLy_KTX.QuanLyPhong
{
	partial class FrmTimKiem
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
			this.lblTuKhoa = new System.Windows.Forms.Label();
			this.lblTimKiem = new System.Windows.Forms.Label();
			this.cbTimKiem = new System.Windows.Forms.ComboBox();
			this.txtTuKhoa = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.dGTimKiem = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dGTimKiem)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1094, 57);
			this.label1.TabIndex = 0;
			this.label1.Text = "TÌM KIẾM THÔNG TIN ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTuKhoa
			// 
			this.lblTuKhoa.AutoSize = true;
			this.lblTuKhoa.Location = new System.Drawing.Point(738, 95);
			this.lblTuKhoa.Name = "lblTuKhoa";
			this.lblTuKhoa.Size = new System.Drawing.Size(64, 20);
			this.lblTuKhoa.TabIndex = 1;
			this.lblTuKhoa.Text = "Từ Khóa";
			// 
			// lblTimKiem
			// 
			this.lblTimKiem.AutoSize = true;
			this.lblTimKiem.Location = new System.Drawing.Point(415, 100);
			this.lblTimKiem.Name = "lblTimKiem";
			this.lblTimKiem.Size = new System.Drawing.Size(109, 20);
			this.lblTimKiem.TabIndex = 2;
			this.lblTimKiem.Text = "Tìm Kiếm Theo";
			// 
			// cbTimKiem
			// 
			this.cbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTimKiem.FormattingEnabled = true;
			this.cbTimKiem.Location = new System.Drawing.Point(545, 92);
			this.cbTimKiem.Name = "cbTimKiem";
			this.cbTimKiem.Size = new System.Drawing.Size(151, 28);
			this.cbTimKiem.TabIndex = 4;
			// 
			// txtTuKhoa
			// 
			this.txtTuKhoa.Location = new System.Drawing.Point(858, 88);
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.Size = new System.Drawing.Size(125, 27);
			this.txtTuKhoa.TabIndex = 5;
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnTim.Location = new System.Drawing.Point(667, 163);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(107, 43);
			this.btnTim.TabIndex = 6;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = false;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// dGTimKiem
			// 
			this.dGTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGTimKiem.Location = new System.Drawing.Point(0, 259);
			this.dGTimKiem.Name = "dGTimKiem";
			this.dGTimKiem.ReadOnly = true;
			this.dGTimKiem.RowHeadersWidth = 51;
			this.dGTimKiem.RowTemplate.Height = 29;
			this.dGTimKiem.Size = new System.Drawing.Size(1094, 426);
			this.dGTimKiem.TabIndex = 7;
			// 
			// FrmTimKiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1094, 697);
			this.Controls.Add(this.dGTimKiem);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtTuKhoa);
			this.Controls.Add(this.cbTimKiem);
			this.Controls.Add(this.lblTimKiem);
			this.Controls.Add(this.lblTuKhoa);
			this.Controls.Add(this.label1);
			this.Name = "FrmTimKiem";
			this.Text = "Tìm kiếm";
			((System.ComponentModel.ISupportInitialize)(this.dGTimKiem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTuKhoa;
		private System.Windows.Forms.Label lblTimKiem;
		private System.Windows.Forms.ComboBox cbTimKiem;
		private System.Windows.Forms.TextBox txtTuKhoa;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.DataGridView dGTimKiem;
	}
}