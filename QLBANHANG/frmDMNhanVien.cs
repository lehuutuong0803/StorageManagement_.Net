using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.Models;

namespace QLBANHANG
{
    public partial class frmDMNhanVien : Form
    {
        ContextGiayDB Context = new ContextGiayDB();
        private string tDangNhap;

        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        public frmDMNhanVien(string tDangNhap)
        {
            InitializeComponent();
        
            this.tDangNhap = tDangNhap;
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            txtTenNV.Enabled = false;
            txtMaNV.Enabled = false;
            txtDiaChi.Enabled = false;
            maDienThoai.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            dtNgaySinh.Enabled = false;
            btLuu.Enabled = false;
            //Lay Thong Tin NV

            tblNhanVien nv = Context.tblNhanViens.FirstOrDefault(p => p.tblTaiKhoan.TaiKhoan == tDangNhap);
            txtTenNV.Text = nv.TenNhanVien;
            txtMaNV.Text = nv.MaNhanVien;
            txtDiaChi.Text = nv.DiaChi;
            maDienThoai.Text = nv.DienThoai;
            if (rdoNam.Text == nv.GioiTinh && nv.GioiTinh =="Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            dtNgaySinh.Value = DateTime.Parse(nv.NgaySinh.ToString());
            ReallyCenterToScreen();
        }

        protected void ReallyCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
        private void btSuaThongTin_Click(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = true;
            maDienThoai.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            dtNgaySinh.Enabled = true;
            btLuu.Enabled = true;
            btSuaThongTin.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if(txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhâp Địa Chỉ");
                return;
            }
            if(maDienThoai.Text == "(   )    -")
            {
                MessageBox.Show("Vui Long Nhap SDT");
                return;
            }
            //Gan Gia Tri Vao DB
            tblNhanVien nv = Context.tblNhanViens.FirstOrDefault(p => p.tblTaiKhoan.TaiKhoan == tDangNhap);
            nv.DiaChi = txtDiaChi.Text;
            nv.DienThoai = maDienThoai.Text;
            
            nv.NgaySinh = dtNgaySinh.Value;
            nv.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            Context.SaveChanges();
            MessageBox.Show("Lưu Thành Công!");
            frmDMNhanVien_Load(sender, e);
            btSuaThongTin.Enabled = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
