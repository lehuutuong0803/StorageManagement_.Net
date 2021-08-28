
namespace QLBANHANG
{
    partial class frmDMThuongHieu
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
            this.txtMaThuongHieu = new System.Windows.Forms.TextBox();
            this.txtTenThuongHieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvThuongHieu = new System.Windows.Forms.DataGridView();
            this.MaThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaThuongHieu
            // 
            this.txtMaThuongHieu.Location = new System.Drawing.Point(239, 78);
            this.txtMaThuongHieu.Multiline = true;
            this.txtMaThuongHieu.Name = "txtMaThuongHieu";
            this.txtMaThuongHieu.Size = new System.Drawing.Size(305, 22);
            this.txtMaThuongHieu.TabIndex = 0;
            // 
            // txtTenThuongHieu
            // 
            this.txtTenThuongHieu.Location = new System.Drawing.Point(239, 128);
            this.txtTenThuongHieu.Name = "txtTenThuongHieu";
            this.txtTenThuongHieu.Size = new System.Drawing.Size(305, 22);
            this.txtTenThuongHieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Thương Hiệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Thương Hiệu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(245, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh Mục Thương Hiệu";
            // 
            // dgvThuongHieu
            // 
            this.dgvThuongHieu.AllowUserToAddRows = false;
            this.dgvThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuongHieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuongHieu,
            this.TenThuongHieu});
            this.dgvThuongHieu.Location = new System.Drawing.Point(71, 180);
            this.dgvThuongHieu.Name = "dgvThuongHieu";
            this.dgvThuongHieu.RowHeadersWidth = 51;
            this.dgvThuongHieu.RowTemplate.Height = 24;
            this.dgvThuongHieu.Size = new System.Drawing.Size(667, 209);
            this.dgvThuongHieu.TabIndex = 5;
            this.dgvThuongHieu.Click += new System.EventHandler(this.dgvThuongHieu_Click);
            // 
            // MaThuongHieu
            // 
            this.MaThuongHieu.HeaderText = "Mã Thương Hiệu";
            this.MaThuongHieu.MinimumWidth = 6;
            this.MaThuongHieu.Name = "MaThuongHieu";
            this.MaThuongHieu.Width = 200;
            // 
            // TenThuongHieu
            // 
            this.TenThuongHieu.HeaderText = "Tên Thương Hiệu";
            this.TenThuongHieu.MinimumWidth = 6;
            this.TenThuongHieu.Name = "TenThuongHieu";
            this.TenThuongHieu.Width = 200;
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
            this.btThem.Location = new System.Drawing.Point(21, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(98, 43);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
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
            this.btXoa.Location = new System.Drawing.Point(275, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 43);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btSua.FlatAppearance.BorderSize = 2;
            this.btSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(146, 3);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(98, 43);
            this.btSua.TabIndex = 8;
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
            this.btLuu.Location = new System.Drawing.Point(406, 3);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(98, 43);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btBoQua.FlatAppearance.BorderSize = 2;
            this.btBoQua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btBoQua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBoQua.Location = new System.Drawing.Point(542, 3);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(98, 43);
            this.btBoQua.TabIndex = 10;
            this.btBoQua.Text = "Bỏ Qua";
            this.btBoQua.UseVisualStyleBackColor = true;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
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
            this.btDong.Location = new System.Drawing.Point(674, 3);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(98, 43);
            this.btDong.TabIndex = 11;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btDong);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btBoQua);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 12;
            // 
            // frmDMThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThuongHieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenThuongHieu);
            this.Controls.Add(this.txtMaThuongHieu);
            this.Name = "frmDMThuongHieu";
            this.Text = "Danh Mục Thương Hiệu";
            this.Load += new System.EventHandler(this.frmDMThuongHieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaThuongHieu;
        private System.Windows.Forms.TextBox txtTenThuongHieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThuongHieu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuongHieu;
    }
}