
namespace QLBANHANG
{
    partial class frmTKHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTimKiemHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTKMaNV = new System.Windows.Forms.Button();
            this.btTimLai = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btTKMaKH = new System.Windows.Forms.Button();
            this.btTKMaHD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaKhachHang);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 152);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Mã Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(238, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(561, 41);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(172, 22);
            this.txtMaKhachHang.TabIndex = 17;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(975, 41);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(197, 22);
            this.txtMaNhanVien.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(836, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(180, 41);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(197, 22);
            this.txtMaHoaDon.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // dgvTimKiemHoaDon
            // 
            this.dgvTimKiemHoaDon.AllowUserToAddRows = false;
            this.dgvTimKiemHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB,
            this.MaNV,
            this.NgayBan,
            this.MaKhach,
            this.TongTien});
            this.dgvTimKiemHoaDon.Location = new System.Drawing.Point(12, 88);
            this.dgvTimKiemHoaDon.Name = "dgvTimKiemHoaDon";
            this.dgvTimKiemHoaDon.RowHeadersWidth = 51;
            this.dgvTimKiemHoaDon.RowTemplate.Height = 24;
            this.dgvTimKiemHoaDon.Size = new System.Drawing.Size(1083, 291);
            this.dgvTimKiemHoaDon.TabIndex = 2;
            this.dgvTimKiemHoaDon.DoubleClick += new System.EventHandler(this.dgvTimKiemHoaDon_DoubleClick);
            // 
            // MaHDB
            // 
            this.MaHDB.HeaderText = "Mã Hóa Đơn";
            this.MaHDB.MinimumWidth = 6;
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // NgayBan
            // 
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 150;
            // 
            // MaKhach
            // 
            this.MaKhach.HeaderText = "Mã Khách";
            this.MaKhach.MinimumWidth = 6;
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 150;
            // 
            // btTKMaNV
            // 
            this.btTKMaNV.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btTKMaNV.FlatAppearance.BorderSize = 2;
            this.btTKMaNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btTKMaNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btTKMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTKMaNV.Image = global::QLBANHANG.Properties.Resources.Search;
            this.btTKMaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTKMaNV.Location = new System.Drawing.Point(211, 421);
            this.btTKMaNV.Name = "btTKMaNV";
            this.btTKMaNV.Size = new System.Drawing.Size(166, 33);
            this.btTKMaNV.TabIndex = 3;
            this.btTKMaNV.Text = "Tìm Kiếm Mã NV";
            this.btTKMaNV.UseVisualStyleBackColor = true;
            this.btTKMaNV.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btTimLai
            // 
            this.btTimLai.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btTimLai.FlatAppearance.BorderSize = 2;
            this.btTimLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btTimLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btTimLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimLai.Image = global::QLBANHANG.Properties.Resources.Search;
            this.btTimLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimLai.Location = new System.Drawing.Point(614, 421);
            this.btTimLai.Name = "btTimLai";
            this.btTimLai.Size = new System.Drawing.Size(104, 33);
            this.btTimLai.TabIndex = 4;
            this.btTimLai.Text = "Tìm Lại";
            this.btTimLai.UseVisualStyleBackColor = true;
            this.btTimLai.Click += new System.EventHandler(this.btTimLai_Click);
            // 
            // btDong
            // 
            this.btDong.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btDong.FlatAppearance.BorderSize = 2;
            this.btDong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDong.Image = global::QLBANHANG.Properties.Resources.Delete;
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(753, 421);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(104, 33);
            this.btDong.TabIndex = 5;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(9, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Nháy Đúp Để Hiện Thị Chi Tiết Hóa Đơn";
            // 
            // btTKMaKH
            // 
            this.btTKMaKH.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btTKMaKH.FlatAppearance.BorderSize = 2;
            this.btTKMaKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btTKMaKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btTKMaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTKMaKH.Image = global::QLBANHANG.Properties.Resources.Search;
            this.btTKMaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTKMaKH.Location = new System.Drawing.Point(416, 421);
            this.btTKMaKH.Name = "btTKMaKH";
            this.btTKMaKH.Size = new System.Drawing.Size(166, 33);
            this.btTKMaKH.TabIndex = 30;
            this.btTKMaKH.Text = "Tìm Kiếm Mã KH";
            this.btTKMaKH.UseVisualStyleBackColor = true;
            this.btTKMaKH.Click += new System.EventHandler(this.btTKMaKH_Click);
            // 
            // btTKMaHD
            // 
            this.btTKMaHD.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btTKMaHD.FlatAppearance.BorderSize = 2;
            this.btTKMaHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btTKMaHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btTKMaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTKMaHD.Image = global::QLBANHANG.Properties.Resources.Search;
            this.btTKMaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTKMaHD.Location = new System.Drawing.Point(12, 421);
            this.btTKMaHD.Name = "btTKMaHD";
            this.btTKMaHD.Size = new System.Drawing.Size(166, 33);
            this.btTKMaHD.TabIndex = 31;
            this.btTKMaHD.Text = "Tìm Kiếm Mã HD";
            this.btTKMaHD.UseVisualStyleBackColor = true;
            this.btTKMaHD.Click += new System.EventHandler(this.btTKMaHD_Click);
            // 
            // frmTKHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 542);
            this.Controls.Add(this.btTKMaHD);
            this.Controls.Add(this.btTKMaKH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btTimLai);
            this.Controls.Add(this.btTKMaNV);
            this.Controls.Add(this.dgvTimKiemHoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "frmTKHoaDon";
            this.Text = "frmTKHoaDon";
            this.Load += new System.EventHandler(this.frmTKHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTimKiemHoaDon;
        private System.Windows.Forms.Button btTKMaNV;
        private System.Windows.Forms.Button btTimLai;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btTKMaKH;
        private System.Windows.Forms.Button btTKMaHD;
    }
}