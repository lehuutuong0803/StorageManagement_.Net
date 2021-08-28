using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBANHANG.Models;


namespace QLBANHANG
{
    public partial class frmHDHoaDonBan : Form
    {
        public delegate void MaHoaDon(string mHD);
        public MaHoaDon Sender;
        ContextGiayDB Context = new ContextGiayDB();
        private string tDangNhap;
        private string MHD;

        public frmHDHoaDonBan()
        {
            InitializeComponent();
            Sender = new MaHoaDon(getMHD);
        }
        private void getMHD(string mHD)
        {
            MHD = mHD;
        }

        public frmHDHoaDonBan(string tDangNhap)
        {
            InitializeComponent();
            this.tDangNhap = tDangNhap;
          
        }

        private void frmHDHoaDonBan_Load(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            btLuu.Enabled = false;
            btXoa.Enabled = false;
            btIn.Enabled = false;
            txtMaHoaDon.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtTenKhachHang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            maDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;       
            txtTongTien.Text = "0";
            txtMaNhanVien.Enabled = false;
            dtNgayBan.Enabled = false;
            
            List<tblKhachHang> kHDB = Context.tblKhachHangs.ToList();
            List<tblGiay> gDB = Context.tblGiays.ToList();
            List<tblHDBan> hDB = Context.tblHDBans.ToList();
            comboBoxMHD(hDB);
            comboBoxKH(kHDB);
            ComboBoxG(gDB);
           
            //Hien Ma Nhan Vien Dang Đăng Nhập
            List<tblNhanVien> nVDB = Context.tblNhanViens.ToList();
            nVDB = (from s in nVDB where s.tblTaiKhoan.TaiKhoan == tDangNhap select s).ToList();
            
            foreach(var item in nVDB)
            {
                txtMaNhanVien.Text = item.MaNhanVien;
                txtTenNhanVien.Text = item.TenNhanVien;
            }
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
        private void comboBoxMHD(List<tblHDBan> hDB)
        {
            this.cmbMaHoaDon.DataSource = hDB;
            this.cmbMaHoaDon.DisplayMember = "MaHDBan";
            this.cmbMaHoaDon.ValueMember = "MaHDBan";
            this.cmbMaHoaDon.SelectedValue = "0";
        }

        private void comboBoxKH(List<tblKhachHang> kHDB)
        {
            this.cmbMaKhachHang.DataSource = kHDB;
            this.cmbMaKhachHang.DisplayMember = "MaKhach";
            this.cmbMaKhachHang.ValueMember = "MaKhach";
            this.cmbMaKhachHang.SelectedValue = "0";
        }

        private void ComboBoxG(List<tblGiay> gDB)
        {

            this.cmbMaGiay.DataSource = gDB;
            this.cmbMaGiay.DisplayMember = "MaGiay";
            this.cmbMaGiay.ValueMember = "MaGiay";
            this.cmbMaGiay.SelectedValue = "0";
        }

       

        private void btThem_Click(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btLuu.Enabled = true;
            btIn.Enabled = false;
            btThem.Enabled = false;
            ResetValues();
            txtMaHoaDon.Text = CreateKey("HDB");
            dgvHDB.Rows.Clear();

        }
        

        private static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        private static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        private void ResetValues()
        {
            txtMaHoaDon.Text = "";
            dtNgayBan.Value = DateTime.Now;
          
            cmbMaKhachHang.Text = "";
            txtTongTien.Text = "0";       
            cmbMaGiay.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            maDienThoai.Text = "";          
            txtTenHang.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            double sl, SLcon;
            List<tblHDBan> hDBans = Context.tblHDBans.ToList();
            
            int c = 0;
            foreach (var item in hDBans)
            {
                if (txtMaHoaDon.Text == item.MaHDBan)
                {
                    c++;
                }
              
            }
            if (c != 1)
            {
                if (cmbMaKhachHang.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaKhachHang.Focus();
                    return;
                }
                tblHDBan hDBanInsert = new tblHDBan() { MaHDBan = txtMaHoaDon.Text, MaNhanVien = txtMaNhanVien.Text, NgayBan = dtNgayBan.Value, MaKhach = cmbMaKhachHang.SelectedValue.ToString() };
                Context.tblHDBans.Add(hDBanInsert);
                Context.SaveChanges();

                
            }



            // Lưu thông tin của các mặt hàng
            if (cmbMaGiay.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaGiay.Focus();
                    return;
                }
                if ((txtSoLuong.Text == "") || (txtSoLuong.Text == "0"))
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();
                    return;
                }
            //Kiểm tra MaGiay đã có hay chưa
            List<tblCTHD> tblCTHDs = Context.tblCTHDs.ToList();
            foreach (var item in tblCTHDs)
            {
                if(cmbMaGiay.SelectedValue.ToString()== item.MaGiay && txtMaHoaDon.Text == item.MaHDBan)
                {
                    MessageBox.Show("Đã Có Sản Phẩm Trong Hóa Đơn. Vui Lòng Chọn Lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

                // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
                tblGiay giay = Context.tblGiays.FirstOrDefault(p => p.MaGiay == cmbMaGiay.Text);
                int s = int.Parse(giay.SoLuong.ToString());
                if (s == 0)
                {
                    MessageBox.Show("Số lượng mặt hàng đã hết! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(txtSoLuong.Text) > s)
                {
                    MessageBox.Show("Số lượng mặt hàng này chỉ còn " + s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();
                    return;
                }

                tblCTHD cTHDInsert = new tblCTHD() { MaHDBan = txtMaHoaDon.Text, MaGiay = cmbMaGiay.SelectedValue.ToString(), SoLuong = int.Parse(txtSoLuong.Text), DonGia = float.Parse(txtDonGia.Text), ThanhTien = float.Parse(txtThanhTien.Text) };

                Context.tblCTHDs.Add(cTHDInsert);
                Context.SaveChanges();
                // Cập nhật lại số lượng của mặt hàng vào bảng tblHang

                SLcon = s - int.Parse(txtSoLuong.Text);
                string m = cmbMaGiay.SelectedValue.ToString();
                tblGiay gUpdate = Context.tblGiays.FirstOrDefault(p => p.MaGiay == m);
                gUpdate.SoLuong = SLcon;
                Context.SaveChanges();
            //Lưu Tổng Tiền Cho HDBan
            List<tblCTHD> cTHD = Context.tblCTHDs.ToList();
            double tong = 0;
            foreach(var item in cTHD)
            {
                if(txtMaHoaDon.Text == item.MaHDBan)
                {
                    tong += double.Parse(item.ThanhTien.ToString());
                }
            }
            txtTongTien.Text = tong.ToString();
            tblHDBan upDate = Context.tblHDBans.FirstOrDefault(p => p.MaHDBan == txtMaHoaDon.Text);
            upDate.TongTien = float.Parse(txtTongTien.Text);
            Context.SaveChanges();
            LoadDataGridView1(cTHD);
            ResetValuesHang();
            List<tblHDBan> hDB = Context.tblHDBans.ToList();
            comboBoxMHD(hDB);
            btXoa.Enabled = true;
                btThem.Enabled = true;
                btIn.Enabled = true;
            
        }
        private void LoadDataGridView1(List<tblCTHD> cTHD)
        {
            dgvHDB.Rows.Clear();
          foreach(var item in cTHD)
            {
                if(txtMaHoaDon.Text == item.MaHDBan)
                {
                    int index = dgvHDB.Rows.Add();
                    dgvHDB.Rows[index].Cells[0].Value = item.MaGiay;
                    dgvHDB.Rows[index].Cells[1].Value = item.tblGiay.TenGiay;
                    dgvHDB.Rows[index].Cells[2].Value = item.SoLuong;
                    dgvHDB.Rows[index].Cells[3].Value = item.DonGia;
                    dgvHDB.Rows[index].Cells[4].Value = item.ThanhTien;
                    txtTongTien.Text = item.tblHDBan.TongTien.ToString();
                }
            }
        }

        private void ResetValuesHang()
        {
            cmbMaGiay.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
        }

        private void cmbMaGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaGiay.Text == "")
            {
                txtTenHang.Text = "";
                cmbMaGiay.Text = "";
            }
            else
            {
                // Khi chọn mã hàng thì các thông tin về hàng hiện ra
                List<tblGiay> tblGiays = Context.tblGiays.ToList();
                foreach (var item in tblGiays)
                {
                    if (cmbMaGiay.SelectedValue.ToString() == item.MaGiay)
                    {
                        txtTenHang.Text = item.TenGiay;
                        txtDonGia.Text = item.DonGiaBan.ToString();
                    }
                }
            }
            txtSoLuong_TextChanged(sender, e);
        }

        private void cmbMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKhachHang.Text == "")
            {
                txtTenKhachHang.Text = "";
                txtDiaChi.Text = "";
            }
            else
            {
                // Khi chọn mã hàng thì các thông tin về hàng hiện ra
                List<tblKhachHang> tblKhachHangs = Context.tblKhachHangs.ToList();
                foreach (var item in tblKhachHangs)
                {
                    if (cmbMaKhachHang.SelectedValue.ToString() == item.MaKhach)
                    {
                        txtTenKhachHang.Text = item.TenKhach;
                        txtDiaChi.Text = item.DiaChi;
                        maDienThoai.Text = item.DienThoai;
                    }
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            

            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
          
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        //Hàm Chỉ Cho Nhập Số
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btTmKiem_Click(object sender, EventArgs e)
        {

            if (cmbMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaHoaDon.Focus();
                return;
            }
            txtMaHoaDon.Text = cmbMaHoaDon.Text;
            List<tblCTHD> cTHD = Context.tblCTHDs.ToList();
            LoadDataGridView1(cTHD);
            //hien thi thong tin kh
            tblHDBan hDBan = Context.tblHDBans.FirstOrDefault(p => p.MaHDBan == txtMaHoaDon.Text);
           cmbMaKhachHang.Text = hDBan.MaKhach;
       


            btXoa.Enabled = true;
            btLuu.Enabled = true;
            btIn.Enabled = true;
            cmbMaHoaDon.SelectedIndex = -1;
        }
        public void TimKiem(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = MHD;
            List<tblCTHD> cTHD = Context.tblCTHDs.ToList();
            LoadDataGridView1(cTHD);
       
            cmbMaHoaDon.SelectedIndex = -1;
        }

        private void dgvHDB_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql,MaHoaDon;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (dgvHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHoaDon = txtMaHoaDon.Text;
                MaHangxoa = dgvHDB.CurrentRow.Cells[0].Value.ToString();
                SoLuongxoa = Convert.ToInt32(dgvHDB.CurrentRow.Cells[2].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHDB.CurrentRow.Cells[3].Value.ToString());
                tblCTHD cTHD = Context.tblCTHDs.FirstOrDefault(p => p.MaHDBan == MaHoaDon && p.MaGiay == MaHangxoa);
                Context.tblCTHDs.Remove(cTHD);

                // Cập nhật lại số lượng cho các mặt hàng
                tblGiay g = Context.tblGiays.FirstOrDefault(p => p.MaGiay == MaHangxoa);
                sl = g.SoLuong;
                slcon = sl + SoLuongxoa;
                g.SoLuong = slcon;

                // Cập nhật lại tổng tiền cho hóa đơn bán
                tblHDBan tblHDBan = Context.tblHDBans.FirstOrDefault(p => p.MaHDBan == MaHoaDon);
                tong = tblHDBan.TongTien;
                tongmoi = tong - ThanhTienxoa;              
               
                tblHDBan.TongTien = tongmoi;
                Context.SaveChanges();
                List<tblCTHD> cTHDs = Context.tblCTHDs.ToList();
                LoadDataGridView1(cTHDs);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Bản Ghi Nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                List<tblCTHD> listCTHDs = Context.tblCTHDs.ToList();
                List<tblCTHD> tblCTHDsDelete = listCTHDs.Where(p => p.MaHDBan == txtMaHoaDon.Text).ToList();
                foreach (var item in tblCTHDsDelete)
                {
                    Context.tblCTHDs.Remove(item);
                    Context.SaveChanges();
                }
                tblHDBan hDBan = Context.tblHDBans.FirstOrDefault(p => p.MaHDBan == txtMaHoaDon.Text);
                Context.tblHDBans.Remove(hDBan);
                Context.SaveChanges();
                MessageBox.Show("Đã Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHDB.Rows.Clear();
                ResetValues();
                ResetValuesHang();
                List<tblHDBan> hDB = Context.tblHDBans.ToList();
                comboBoxMHD(hDB);
            }

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            string frmName = "frmReportingHDB";
           
                frmReportingHDB frmManHinhDN = new frmReportingHDB(txtMaHoaDon.Text);
              
                frmManHinhDN.ShowDialog();
            
        }
       
    }
}
