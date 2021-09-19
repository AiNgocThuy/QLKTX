
namespace QuanLy_KTX.Report
{
	partial class FrmRp_DienNuoc
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
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.btnIn = new System.Windows.Forms.Button();
			this.txtMaKhu = new System.Windows.Forms.TextBox();
			this.txtThang = new System.Windows.Forms.TextBox();
			this.txtNam = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.usP_getDIENNUOCFromKHUTableAdapter1 = new QuanLy_KTX.Report.KTXDataSetTableAdapters.USP_getDIENNUOCFromKHUTableAdapter();
			this.ktxDataSet1 = new QuanLy_KTX.Report.KTXDataSet();
			this.uSP_getDIENNUOCFromKHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ktxDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uSP_getDIENNUOCFromKHUBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.uSP_getDIENNUOCFromKHUBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy_KTX.Report.Rp_DienNuoc.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(42, 134);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1317, 538);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// btnIn
			// 
			this.btnIn.Location = new System.Drawing.Point(904, 52);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(75, 31);
			this.btnIn.TabIndex = 1;
			this.btnIn.Text = "In";
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
			// 
			// txtMaKhu
			// 
			this.txtMaKhu.Location = new System.Drawing.Point(170, 52);
			this.txtMaKhu.Multiline = true;
			this.txtMaKhu.Name = "txtMaKhu";
			this.txtMaKhu.Size = new System.Drawing.Size(100, 31);
			this.txtMaKhu.TabIndex = 2;
			// 
			// txtThang
			// 
			this.txtThang.Location = new System.Drawing.Point(421, 52);
			this.txtThang.Multiline = true;
			this.txtThang.Name = "txtThang";
			this.txtThang.Size = new System.Drawing.Size(100, 31);
			this.txtThang.TabIndex = 3;
			// 
			// txtNam
			// 
			this.txtNam.Location = new System.Drawing.Point(686, 52);
			this.txtNam.Multiline = true;
			this.txtNam.Name = "txtNam";
			this.txtNam.Size = new System.Drawing.Size(100, 31);
			this.txtNam.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mã Khu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(329, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tháng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(595, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Năm";
			// 
			// usP_getDIENNUOCFromKHUTableAdapter1
			// 
			this.usP_getDIENNUOCFromKHUTableAdapter1.ClearBeforeFill = true;
			// 
			// ktxDataSet1
			// 
			this.ktxDataSet1.DataSetName = "KTXDataSet";
			this.ktxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// uSP_getDIENNUOCFromKHUBindingSource
			// 
			this.uSP_getDIENNUOCFromKHUBindingSource.DataMember = "USP_getDIENNUOCFromKHU";
			this.uSP_getDIENNUOCFromKHUBindingSource.DataSource = this.ktxDataSet1;
			// 
			// FrmRp_DienNuoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1436, 684);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNam);
			this.Controls.Add(this.txtThang);
			this.Controls.Add(this.txtMaKhu);
			this.Controls.Add(this.btnIn);
			this.Controls.Add(this.reportViewer1);
			this.Name = "FrmRp_DienNuoc";
			this.Text = "FrmRp_DienNuoc";
			this.Load += new System.EventHandler(this.FrmRp_DienNuoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.ktxDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uSP_getDIENNUOCFromKHUBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.TextBox txtMaKhu;
		private System.Windows.Forms.TextBox txtThang;
		private System.Windows.Forms.TextBox txtNam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private KTXDataSetTableAdapters.USP_getDIENNUOCFromKHUTableAdapter usP_getDIENNUOCFromKHUTableAdapter1;
		private KTXDataSet ktxDataSet1;
		private System.Windows.Forms.BindingSource uSP_getDIENNUOCFromKHUBindingSource;
	}
}