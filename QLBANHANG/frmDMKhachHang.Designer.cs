
namespace QLBANHANG
{
    partial class frmDMKhachHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.maDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maDienThoai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 152);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(238, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Danh Mục Khách Hàng";
            // 
            // maDienThoai
            // 
            this.maDienThoai.Location = new System.Drawing.Point(549, 107);
            this.maDienThoai.Mask = "(999) 000-0000";
            this.maDienThoai.Name = "maDienThoai";
            this.maDienThoai.Size = new System.Drawing.Size(197, 22);
            this.maDienThoai.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Điện Thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(549, 59);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(197, 22);
            this.txtDiaChi.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Địa Chỉ:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(180, 107);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(197, 22);
            this.txtTenKH.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(180, 61);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(197, 22);
            this.txtMaKH.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.btDong);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btBoQua);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 70);
            this.panel2.TabIndex = 1;
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
            this.btThem.Location = new System.Drawing.Point(25, 14);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(103, 43);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
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
            this.btDong.Location = new System.Drawing.Point(694, 14);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(103, 43);
            this.btDong.TabIndex = 17;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
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
            this.btXoa.Location = new System.Drawing.Point(286, 14);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(103, 43);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btBoQua.FlatAppearance.BorderSize = 2;
            this.btBoQua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btBoQua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBoQua.Location = new System.Drawing.Point(558, 14);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(103, 43);
            this.btBoQua.TabIndex = 16;
            this.btBoQua.Text = "Bỏ Qua";
            this.btBoQua.UseVisualStyleBackColor = true;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btSua
            // 
            this.btSua.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btSua.FlatAppearance.BorderSize = 2;
            this.btSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Image = global::QLBANHANG.Properties.Resources.add_row;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(153, 14);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(103, 43);
            this.btSua.TabIndex = 14;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
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
            this.btLuu.Location = new System.Drawing.Point(422, 14);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(103, 43);
            this.btLuu.TabIndex = 15;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhach,
            this.TenKhach,
            this.DiaChi,
            this.DienThoai});
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 158);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(899, 216);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // MaKhach
            // 
            this.MaKhach.HeaderText = "Mã Khách";
            this.MaKhach.MinimumWidth = 6;
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.Width = 200;
            // 
            // TenKhach
            // 
            this.TenKhach.HeaderText = "Tên Khách";
            this.TenKhach.MinimumWidth = 6;
            this.TenKhach.Name = "TenKhach";
            this.TenKhach.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // DienThoai
            // 
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 200;
            // 
            // frmDMKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 482);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDMKhachHang";
            this.Text = "Danh Mục Khách Hàng";
            this.Load += new System.EventHandler(this.frmDMKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
    }
}