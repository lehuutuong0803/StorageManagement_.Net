
namespace QLBANHANG
{
    partial class frmTongThuNhap
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
            this.rpvTongThuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTongThuNhap
            // 
            this.rpvTongThuNhap.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.rpvTongThuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTongThuNhap.LocalReport.ReportEmbeddedResource = "QLBANHANG.Reportings.rptTongThuNhap.rdlc";
            this.rpvTongThuNhap.Location = new System.Drawing.Point(0, 0);
            this.rpvTongThuNhap.Name = "rpvTongThuNhap";
            this.rpvTongThuNhap.ServerReport.BearerToken = null;
            this.rpvTongThuNhap.Size = new System.Drawing.Size(800, 450);
            this.rpvTongThuNhap.TabIndex = 0;
            // 
            // frmTongThuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvTongThuNhap);
            this.Name = "frmTongThuNhap";
            this.Text = "frmTongThuNhap";
            this.Load += new System.EventHandler(this.frmTongThuNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTongThuNhap;
    }
}