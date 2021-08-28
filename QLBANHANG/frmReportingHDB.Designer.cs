
namespace QLBANHANG
{
    partial class frmReportingHDB
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
            this.rpvXuatHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvXuatHoaDon
            // 
            reportDataSource1.Name = "InHoaDonDataset";
            reportDataSource1.Value = this.InHoaDonBindingSource;
            this.rpvXuatHoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvXuatHoaDon.LocalReport.ReportEmbeddedResource = "QLBANHANG.Reportings.ReportHoaDon.rdlc";
            this.rpvXuatHoaDon.Location = new System.Drawing.Point(27, 90);
            this.rpvXuatHoaDon.Name = "rpvXuatHoaDon";
            this.rpvXuatHoaDon.ServerReport.BearerToken = null;
            this.rpvXuatHoaDon.Size = new System.Drawing.Size(838, 432);
            this.rpvXuatHoaDon.TabIndex = 0;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(304, 62);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(191, 22);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xuất Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // InHoaDonBindingSource
            // 
            this.InHoaDonBindingSource.DataSource = typeof(QLBANHANG.Reportings.InHoaDon);
            // 
            // frmReportingHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.rpvXuatHoaDon);
            this.Name = "frmReportingHDB";
            this.Text = "frmReportingHDB";
            this.Load += new System.EventHandler(this.frmReportingHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvXuatHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource InHoaDonBindingSource;
    }
}