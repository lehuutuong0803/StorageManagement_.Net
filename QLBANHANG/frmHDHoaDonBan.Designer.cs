
namespace QLBANHANG
{
    partial class frmHDHoaDonBan
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
            this.cmbMaHoaDon = new System.Windows.Forms.ComboBox();
            this.btTmKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cmbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.maDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDong = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.cmbMaGiay = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMaHoaDon);
            this.panel1.Controls.Add(this.btTmKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 49);
            this.panel1.TabIndex = 0;
            // 
            // cmbMaHoaDon
            // 
            this.cmbMaHoaDon.FormattingEnabled = true;
            this.cmbMaHoaDon.Location = new System.Drawing.Point(177, 15);
            this.cmbMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaHoaDon.Name = "cmbMaHoaDon";
            this.cmbMaHoaDon.Size = new System.Drawing.Size(156, 24);
            this.cmbMaHoaDon.TabIndex = 24;
            // 
            // btTmKiem
            // 
            this.btTmKiem.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btTmKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btTmKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTmKiem.Location = new System.Drawing.Point(415, 15);
            this.btTmKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTmKiem.Name = "btTmKiem";
            this.btTmKiem.Size = new System.Drawing.Size(75, 23);
            this.btTmKiem.TabIndex = 2;
            this.btTmKiem.Text = "Tìm Kiếm";
            this.btTmKiem.UseVisualStyleBackColor = true;
            this.btTmKiem.Click += new System.EventHandler(this.btTmKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.dtNgayBan);
            this.groupBox1.Controls.Add(this.cmbMaKhachHang);
            this.groupBox1.Controls.Add(this.maDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1143, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(403, 28);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(159, 22);
            this.txtMaNhanVien.TabIndex = 25;
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBan.Location = new System.Drawing.Point(109, 62);
            this.dtNgayBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(176, 22);
            this.dtNgayBan.TabIndex = 24;
            // 
            // cmbMaKhachHang
            // 
            this.cmbMaKhachHang.FormattingEnabled = true;
            this.cmbMaKhachHang.Location = new System.Drawing.Point(692, 22);
            this.cmbMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaKhachHang.Name = "cmbMaKhachHang";
            this.cmbMaKhachHang.Size = new System.Drawing.Size(161, 24);
            this.cmbMaKhachHang.TabIndex = 23;
            this.cmbMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhachHang_SelectedIndexChanged);
            // 
            // maDienThoai
            // 
            this.maDienThoai.Location = new System.Drawing.Point(945, 58);
            this.maDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maDienThoai.Mask = "(999) 000-0000";
            this.maDienThoai.Name = "maDienThoai";
            this.maDienThoai.ReadOnly = true;
            this.maDienThoai.Size = new System.Drawing.Size(183, 22);
            this.maDienThoai.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(945, 21);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(183, 22);
            this.txtDiaChi.TabIndex = 18;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(692, 58);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(161, 22);
            this.txtTenKhachHang.TabIndex = 10;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(405, 62);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(156, 22);
            this.txtTenNhanVien.TabIndex = 9;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(109, 22);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(176, 22);
            this.txtMaHoaDon.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(859, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Địa Chỉ KH:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(859, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "SDT KH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên Khách Hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã Khách Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(391, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hóa Đơn Bán Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.dgvHDB);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.cmbMaGiay);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1143, 350);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Mặt Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nháy Đúp Để Xóa Sản Phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDong);
            this.panel2.Controls.Add(this.btIn);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 52);
            this.panel2.TabIndex = 27;
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
            this.btDong.Location = new System.Drawing.Point(829, 6);
            this.btDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(155, 43);
            this.btDong.TabIndex = 16;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btIn
            // 
            this.btIn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btIn.FlatAppearance.BorderSize = 2;
            this.btIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIn.Location = new System.Drawing.Point(651, 7);
            this.btIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(151, 43);
            this.btIn.TabIndex = 15;
            this.btIn.Text = "In Hóa Đơn";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btXoa.FlatAppearance.BorderSize = 2;
            this.btXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Image = global::QLBANHANG.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(472, 6);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(151, 43);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Hủy Hóa Đơn";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btLuu.FlatAppearance.BorderSize = 2;
            this.btLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLuu.Image = global::QLBANHANG.Properties.Resources.Save;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(292, 7);
            this.btLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(151, 43);
            this.btLuu.TabIndex = 13;
            this.btLuu.Text = "Lưu Hóa Đơn";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btThem.FlatAppearance.BorderSize = 2;
            this.btThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Image = global::QLBANHANG.Properties.Resources.add_row;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(116, 6);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(151, 43);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm Hóa Đơn";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvHDB
            // 
            this.dgvHDB.AllowUserToAddRows = false;
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvHDB.Location = new System.Drawing.Point(15, 89);
            this.dgvHDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.RowHeadersWidth = 51;
            this.dgvHDB.RowTemplate.Height = 24;
            this.dgvHDB.Size = new System.Drawing.Size(1113, 172);
            this.dgvHDB.TabIndex = 26;
            this.dgvHDB.DoubleClick += new System.EventHandler(this.dgvHDB_DoubleClick);
            // 
            // MaHang
            // 
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 125;
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(981, 266);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(156, 22);
            this.txtTongTien.TabIndex = 25;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(405, 25);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(156, 22);
            this.txtTenHang.TabIndex = 24;
            // 
            // cmbMaGiay
            // 
            this.cmbMaGiay.FormattingEnabled = true;
            this.cmbMaGiay.Location = new System.Drawing.Point(109, 26);
            this.cmbMaGiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaGiay.Name = "cmbMaGiay";
            this.cmbMaGiay.Size = new System.Drawing.Size(156, 24);
            this.cmbMaGiay.TabIndex = 23;
            this.cmbMaGiay.SelectedIndexChanged += new System.EventHandler(this.cmbMaGiay_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(691, 26);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(161, 22);
            this.txtThanhTien.TabIndex = 10;
            this.txtThanhTien.Text = "0";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(405, 62);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(156, 22);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(109, 60);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(156, 22);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(901, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tổng Tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(599, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Thành Tiền:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(323, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Đơn Giá:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tên Giày:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Số Lượng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã Giày:";
            // 
            // frmHDHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHDHoaDonBan";
            this.Text = "Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.frmHDHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTmKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.ComboBox cmbMaKhachHang;
        private System.Windows.Forms.MaskedTextBox maDienThoai;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.ComboBox cmbMaGiay;
        private System.Windows.Forms.DataGridView dgvHDB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.ComboBox cmbMaHoaDon;
        private System.Windows.Forms.Label label11;
    }
}