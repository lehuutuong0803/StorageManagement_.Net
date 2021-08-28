using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class frmMain : Form
    {
        string tDangNhap;
        public frmMain()
        {
            InitializeComponent();
        }

        private void MoManHinhDangNhap()
        {
            string frmName = "frmDangNhap";
            if(!KiemTraManHinh(frmName))
            {
                frmDangNhap frmManHinhDN = new frmDangNhap();
                frmManHinhDN.MdiParent = this;
                frmManHinhDN.chungThucThongTinTaiKhoan += frmManHinhDN_chungThucThongTinTaiKhoan;
                frmManHinhDN.Show();
            }
        }

    
        private void frmManHinhDN_chungThucThongTinTaiKhoan(object sender)
        {
            mncDangNhap.Enabled = false;
            mnDanhMuc.Enabled = mnHoaDon.Enabled = mnTimKiem.Enabled = mncDangXuat.Enabled = frmBaoCao.Enabled= true;

            tool1.Text = "Xin Chao: " + sender.ToString();
            tDangNhap = sender.ToString();
           
        }

        private bool KiemTraManHinh(string frmName)
        {
            Form frmManHinh;
            if(this.MdiChildren.Any(f => f.Name ==frmName))
            {
                frmManHinh = this.MdiChildren.Where(f => f.Name == frmName).FirstOrDefault();
                frmManHinh.Show();
                return true;
            }
            return false;
        }

        private void KhoaChucNangHeThong()
        {
            mncDangXuat.Enabled = false;
            mnDanhMuc.Enabled = false;
            mnHoaDon.Enabled = false;
            mnTimKiem.Enabled = false;
            frmBaoCao.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KhoaChucNangHeThong();
            MoManHinhDangNhap();
        }

        private void mncDangNhap_Click(object sender, EventArgs e)
        {
            MoManHinhDangNhap();
        }

        private void mncDangXuat_Click(object sender, EventArgs e)
        {
            tool1.Text = "...";
            mncDangNhap.Enabled = true;
            foreach(Form item in this.MdiChildren)
            {
                item.Close();
            }
            MoManHinhDangNhap();
            KhoaChucNangHeThong();

        }

        private void mndmThuongHieu_Click(object sender, EventArgs e)
        {
            //Chi Cho Xuat 1 Man Hinh
            string frmName = "frmDMThuongHieu";
            if (!KiemTraManHinh(frmName))
            {
                frmDMThuongHieu frmManHinhDN = new frmDMThuongHieu(tDangNhap);
                frmManHinhDN.MdiParent = this;             
                frmManHinhDN.Show();
            }
        }

        private void mndmNhanVien_Click(object sender, EventArgs e)
        {
            //Chi Cho Xuat 1 Man Hinh
            string frmName = "frmDMNhanVien";
            if (!KiemTraManHinh(frmName))
            {
                frmDMNhanVien frmManHinhDN = new frmDMNhanVien(tDangNhap);
                frmManHinhDN.MdiParent = this;
                frmManHinhDN.Show();
            }
        }

        private void mndmKhachHang_Click(object sender, EventArgs e)
        {
            //Chi Cho Xuat 1 Man Hinh
            string frmName = "frmDMKhachHang";
            if (!KiemTraManHinh(frmName))
            {
                frmDMKhachHang frmManHinhDN = new frmDMKhachHang();
                frmManHinhDN.MdiParent = this;
                frmManHinhDN.Show();
            }
        }

        private void mndmGiay_Click(object sender, EventArgs e)
        {
            //Chi Cho Xuat 1 Man Hinh
            string frmName = "frmDMGiay";
            if (!KiemTraManHinh(frmName))
            {
                frmDMGiay frmManHinhDN = new frmDMGiay();
                frmManHinhDN.MdiParent = this;
                frmManHinhDN.Show();
            }
        }

        private void mnhdHDBan_Click(object sender, EventArgs e)
        {
            //Chi Cho Xuat 1 Man Hinh
            string frmName = "frmHDHoaDonBan";
            if (!KiemTraManHinh(frmName))
            {
                frmHDHoaDonBan frmManHinhDN = new frmHDHoaDonBan(tDangNhap);
                frmManHinhDN.MdiParent = this;
                frmManHinhDN.Show();
            }
        }

        private void mntkHoaDon_Click(object sender, EventArgs e)
        {
            //Chi Cho Xuat 1 Man Hinh
            string frmName = "frmTKHoaDon";
            if (!KiemTraManHinh(frmName))
            {
                frmTKHoaDon frmManHinhDN = new frmTKHoaDon();
                frmManHinhDN.MdiParent = this;
                frmManHinhDN.Show();
            }
        }

        private void frmTongThuNhap_Click(object sender, EventArgs e)
        {
            string frmName = "frmTongThuNhap";

            frmTongThuNhap frmManHinhDN = new frmTongThuNhap();

            frmManHinhDN.ShowDialog();

        }
    }
}
