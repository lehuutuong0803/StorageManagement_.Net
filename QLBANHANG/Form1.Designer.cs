
namespace QLBANHANG
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mncDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mncDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mndmThuongHieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mndmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mndmKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mndmGiay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnhdHDBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntkHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHello = new System.Windows.Forms.StatusStrip();
            this.tool1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.frmBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.frmTongThuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolHello.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSignIn,
            this.mnDanhMuc,
            this.mnHoaDon,
            this.mnTimKiem,
            this.frmBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnSignIn
            // 
            this.mnSignIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mncDangNhap,
            this.mncDangXuat});
            this.mnSignIn.Name = "mnSignIn";
            this.mnSignIn.Size = new System.Drawing.Size(68, 24);
            this.mnSignIn.Text = "Sign In";
            // 
            // mncDangNhap
            // 
            this.mncDangNhap.Name = "mncDangNhap";
            this.mncDangNhap.Size = new System.Drawing.Size(168, 26);
            this.mncDangNhap.Text = "Đăng Nhập";
            this.mncDangNhap.Click += new System.EventHandler(this.mncDangNhap_Click);
            // 
            // mncDangXuat
            // 
            this.mncDangXuat.Name = "mncDangXuat";
            this.mncDangXuat.Size = new System.Drawing.Size(168, 26);
            this.mncDangXuat.Text = "Đăng Xuất";
            this.mncDangXuat.Click += new System.EventHandler(this.mncDangXuat_Click);
            // 
            // mnDanhMuc
            // 
            this.mnDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mndmThuongHieu,
            this.mndmNhanVien,
            this.mndmKhachHang,
            this.mndmGiay});
            this.mnDanhMuc.Name = "mnDanhMuc";
            this.mnDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnDanhMuc.Text = "Danh Mục";
            // 
            // mndmThuongHieu
            // 
            this.mndmThuongHieu.Name = "mndmThuongHieu";
            this.mndmThuongHieu.Size = new System.Drawing.Size(178, 26);
            this.mndmThuongHieu.Text = "Thương Hiệu";
            this.mndmThuongHieu.Click += new System.EventHandler(this.mndmThuongHieu_Click);
            // 
            // mndmNhanVien
            // 
            this.mndmNhanVien.Name = "mndmNhanVien";
            this.mndmNhanVien.Size = new System.Drawing.Size(178, 26);
            this.mndmNhanVien.Text = "Nhân Viên";
            this.mndmNhanVien.Click += new System.EventHandler(this.mndmNhanVien_Click);
            // 
            // mndmKhachHang
            // 
            this.mndmKhachHang.Name = "mndmKhachHang";
            this.mndmKhachHang.Size = new System.Drawing.Size(178, 26);
            this.mndmKhachHang.Text = "Khách Hàng";
            this.mndmKhachHang.Click += new System.EventHandler(this.mndmKhachHang_Click);
            // 
            // mndmGiay
            // 
            this.mndmGiay.Name = "mndmGiay";
            this.mndmGiay.Size = new System.Drawing.Size(178, 26);
            this.mndmGiay.Text = "Giày";
            this.mndmGiay.Click += new System.EventHandler(this.mndmGiay_Click);
            // 
            // mnHoaDon
            // 
            this.mnHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnhdHDBan});
            this.mnHoaDon.Name = "mnHoaDon";
            this.mnHoaDon.Size = new System.Drawing.Size(83, 24);
            this.mnHoaDon.Text = "Hóa Đơn";
            // 
            // mnhdHDBan
            // 
            this.mnhdHDBan.Name = "mnhdHDBan";
            this.mnhdHDBan.Size = new System.Drawing.Size(181, 26);
            this.mnhdHDBan.Text = "Hóa Đơn Bán";
            this.mnhdHDBan.Click += new System.EventHandler(this.mnhdHDBan_Click);
            // 
            // mnTimKiem
            // 
            this.mnTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntkHoaDon});
            this.mnTimKiem.Name = "mnTimKiem";
            this.mnTimKiem.Size = new System.Drawing.Size(86, 24);
            this.mnTimKiem.Text = "Tìm Kiếm";
            // 
            // mntkHoaDon
            // 
            this.mntkHoaDon.Name = "mntkHoaDon";
            this.mntkHoaDon.Size = new System.Drawing.Size(152, 26);
            this.mntkHoaDon.Text = "Hóa Đơn";
            this.mntkHoaDon.Click += new System.EventHandler(this.mntkHoaDon_Click);
            // 
            // toolHello
            // 
            this.toolHello.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolHello.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool1});
            this.toolHello.Location = new System.Drawing.Point(0, 485);
            this.toolHello.Name = "toolHello";
            this.toolHello.Size = new System.Drawing.Size(1313, 26);
            this.toolHello.TabIndex = 2;
            this.toolHello.Text = "statusStrip1";
            // 
            // tool1
            // 
            this.tool1.Name = "tool1";
            this.tool1.Size = new System.Drawing.Size(68, 20);
            this.tool1.Text = "Xin Chào";
            // 
            // frmBaoCao
            // 
            this.frmBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmTongThuNhap});
            this.frmBaoCao.Name = "frmBaoCao";
            this.frmBaoCao.Size = new System.Drawing.Size(79, 24);
            this.frmBaoCao.Text = "Báo Cáo";
            // 
            // frmTongThuNhap
            // 
            this.frmTongThuNhap.Name = "frmTongThuNhap";
            this.frmTongThuNhap.Size = new System.Drawing.Size(224, 26);
            this.frmTongThuNhap.Text = "Tổng Thu Nhập";
            this.frmTongThuNhap.Click += new System.EventHandler(this.frmTongThuNhap_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 511);
            this.Controls.Add(this.toolHello);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyBanHang";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolHello.ResumeLayout(false);
            this.toolHello.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnSignIn;
        private System.Windows.Forms.ToolStripMenuItem mncDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mncDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mndmThuongHieu;
        private System.Windows.Forms.ToolStripMenuItem mndmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mndmKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mndmGiay;
        private System.Windows.Forms.ToolStripMenuItem mnHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnhdHDBan;
        private System.Windows.Forms.ToolStripMenuItem mnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mntkHoaDon;
        private System.Windows.Forms.StatusStrip toolHello;
        internal System.Windows.Forms.ToolStripStatusLabel tool1;
        private System.Windows.Forms.ToolStripMenuItem frmBaoCao;
        private System.Windows.Forms.ToolStripMenuItem frmTongThuNhap;
    }
}

