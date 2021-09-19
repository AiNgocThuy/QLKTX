
namespace QuanLy_KTX
{
	partial class FrmKhu
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
			this.pictureBoxKhu = new System.Windows.Forms.PictureBox();
			this.btnSua = new System.Windows.Forms.Button();
			this.txtHinh = new System.Windows.Forms.TextBox();
			this.txtMoTa = new System.Windows.Forms.TextBox();
			this.txtViTri = new System.Windows.Forms.TextBox();
			this.cbTTKhu = new System.Windows.Forms.ComboBox();
			this.cbKhu = new System.Windows.Forms.ComboBox();
			this.lblHinh = new System.Windows.Forms.Label();
			this.lblMoTa = new System.Windows.Forms.Label();
			this.lblKhu = new System.Windows.Forms.Label();
			this.lblTTKhu = new System.Windows.Forms.Label();
			this.lblViTri = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxKhu)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxKhu
			// 
			this.pictureBoxKhu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxKhu.Location = new System.Drawing.Point(-3, 79);
			this.pictureBoxKhu.Name = "pictureBoxKhu";
			this.pictureBoxKhu.Size = new System.Drawing.Size(563, 540);
			this.pictureBoxKhu.TabIndex = 26;
			this.pictureBoxKhu.TabStop = false;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnSua.Location = new System.Drawing.Point(838, 517);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(111, 48);
			this.btnSua.TabIndex = 25;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
			// 
			// txtHinh
			// 
			this.txtHinh.Location = new System.Drawing.Point(101, 8);
			this.txtHinh.Multiline = true;
			this.txtHinh.Name = "txtHinh";
			this.txtHinh.Size = new System.Drawing.Size(305, 27);
			this.txtHinh.TabIndex = 24;
			// 
			// txtMoTa
			// 
			this.txtMoTa.Location = new System.Drawing.Point(676, 362);
			this.txtMoTa.Multiline = true;
			this.txtMoTa.Name = "txtMoTa";
			this.txtMoTa.Size = new System.Drawing.Size(305, 79);
			this.txtMoTa.TabIndex = 23;
			// 
			// txtViTri
			// 
			this.txtViTri.Location = new System.Drawing.Point(676, 293);
			this.txtViTri.Multiline = true;
			this.txtViTri.Name = "txtViTri";
			this.txtViTri.Size = new System.Drawing.Size(305, 49);
			this.txtViTri.TabIndex = 22;
			// 
			// cbTTKhu
			// 
			this.cbTTKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTTKhu.FormattingEnabled = true;
			this.cbTTKhu.Items.AddRange(new object[] {
			"Có Thể ở ",
			"Chưa thể ở được"});
			this.cbTTKhu.Location = new System.Drawing.Point(676, 223);
			this.cbTTKhu.Name = "cbTTKhu";
			this.cbTTKhu.Size = new System.Drawing.Size(151, 28);
			this.cbTTKhu.TabIndex = 21;
			// 
			// cbKhu
			// 
			this.cbKhu.FormattingEnabled = true;
			this.cbKhu.Location = new System.Drawing.Point(676, 157);
			this.cbKhu.Name = "cbKhu";
			this.cbKhu.Size = new System.Drawing.Size(151, 28);
			this.cbKhu.TabIndex = 20;
			this.cbKhu.SelectedIndexChanged += new System.EventHandler(this.cbKhu_TextChanged);
			this.cbKhu.TextChanged += new System.EventHandler(this.cbKhu_TextChanged);
			// 
			// lblHinh
			// 
			this.lblHinh.AutoSize = true;
			this.lblHinh.Location = new System.Drawing.Point(34, 15);
			this.lblHinh.Name = "lblHinh";
			this.lblHinh.Size = new System.Drawing.Size(40, 20);
			this.lblHinh.TabIndex = 19;
			this.lblHinh.Text = "Hình";
			// 
			// lblMoTa
			// 
			this.lblMoTa.AutoSize = true;
			this.lblMoTa.Location = new System.Drawing.Point(607, 365);
			this.lblMoTa.Name = "lblMoTa";
			this.lblMoTa.Size = new System.Drawing.Size(51, 20);
			this.lblMoTa.TabIndex = 18;
			this.lblMoTa.Text = "Mô Tả";
			// 
			// lblKhu
			// 
			this.lblKhu.AutoSize = true;
			this.lblKhu.Location = new System.Drawing.Point(607, 157);
			this.lblKhu.Name = "lblKhu";
			this.lblKhu.Size = new System.Drawing.Size(34, 20);
			this.lblKhu.TabIndex = 17;
			this.lblKhu.Text = "Khu";
			// 
			// lblTTKhu
			// 
			this.lblTTKhu.AutoSize = true;
			this.lblTTKhu.Location = new System.Drawing.Point(560, 231);
			this.lblTTKhu.Name = "lblTTKhu";
			this.lblTTKhu.Size = new System.Drawing.Size(107, 20);
			this.lblTTKhu.TabIndex = 16;
			this.lblTTKhu.Text = "Tình Trạng Khu";
			// 
			// lblViTri
			// 
			this.lblViTri.AutoSize = true;
			this.lblViTri.Location = new System.Drawing.Point(607, 296);
			this.lblViTri.Name = "lblViTri";
			this.lblViTri.Size = new System.Drawing.Size(42, 20);
			this.lblViTri.TabIndex = 15;
			this.lblViTri.Text = "Vị Trí";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(983, 76);
			this.label1.TabIndex = 14;
			this.label1.Text = "THÔNG TIN KÝ TÚC XÁ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtHinh);
			this.panel1.Controls.Add(this.lblHinh);
			this.panel1.Location = new System.Drawing.Point(575, 460);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(407, 48);
			this.panel1.TabIndex = 27;
			// 
			// FrmKhu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 625);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBoxKhu);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.txtMoTa);
			this.Controls.Add(this.txtViTri);
			this.Controls.Add(this.cbTTKhu);
			this.Controls.Add(this.cbKhu);
			this.Controls.Add(this.lblMoTa);
			this.Controls.Add(this.lblKhu);
			this.Controls.Add(this.lblTTKhu);
			this.Controls.Add(this.lblViTri);
			this.Controls.Add(this.label1);
			this.Name = "FrmKhu";
			this.Text = "Khu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxKhu)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxKhu;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.TextBox txtHinh;
		private System.Windows.Forms.TextBox txtMoTa;
		private System.Windows.Forms.TextBox txtViTri;
		private System.Windows.Forms.ComboBox cbTTKhu;
		private System.Windows.Forms.ComboBox cbKhu;
		private System.Windows.Forms.Label lblHinh;
		private System.Windows.Forms.Label lblMoTa;
		private System.Windows.Forms.Label lblKhu;
		private System.Windows.Forms.Label lblTTKhu;
		private System.Windows.Forms.Label lblViTri;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}