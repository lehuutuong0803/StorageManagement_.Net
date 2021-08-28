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
    public partial class frmDMGiay : Form
    {
        ContextGiayDB ConText = new ContextGiayDB();

        public frmDMGiay()
        {
            InitializeComponent();
        }

        private void frmDMGiay_Load(object sender, EventArgs e)
        {
            txtMaGiay.Enabled = false;
            txtAnh.Enabled = false;
            btLuu.Enabled = false;
            btBoQua.Enabled = false;
            List<tblThuongHieu> th = ConText.tblThuongHieux.ToList();
            List<tblGiay> g = ConText.tblGiays.ToList();
            ThemCmBMaThuongHieu(th);
            LoadDataGridView(g);
            ResetValues();
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
        private void LoadDataGridView(List<tblGiay> g)
        {
            dgvGiay.Rows.Clear();
            foreach(var item in g)
            {
                int index = dgvGiay.Rows.Add();
                dgvGiay.Rows[index].Cells[0].Value = item.MaGiay;
                dgvGiay.Rows[index].Cells[1].Value = item.TenGiay;
                dgvGiay.Rows[index].Cells[2].Value = item.tblThuongHieu.TenThuongHieu;
                dgvGiay.Rows[index].Cells[3].Value = item.SoLuong;
                dgvGiay.Rows[index].Cells[4].Value = item.DonGiaNhap;
                dgvGiay.Rows[index].Cells[5].Value = item.DonGiaBan;
                dgvGiay.Rows[index].Cells[6].Value = item.Anh;
                dgvGiay.Rows[index].Cells[7].Value = item.GhiChu;

            }
        }

        private void ThemCmBMaThuongHieu(List<tblThuongHieu> th)
        {
            this.cmbThuongHieu.DataSource = th;
            this.cmbThuongHieu.DisplayMember = "TenThuongHieu";
            this.cmbThuongHieu.ValueMember = "MaThuongHieu";
        }

        private void ResetValues()
        {
            txtMaGiay.Text = "";
            txtTenGiay.Text = "";
            cmbThuongHieu.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtAnh.Text = "";
            pictureBox1.Image = null;
            txtGhiChu.Text = "";
        }

        private void dgvGiay_Click(object sender, EventArgs e)
        {
            if (btThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiay.Focus();
                return;
            }
            if (dgvGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<tblGiay> g = ConText.tblGiays.ToList();
            txtMaGiay.Text = dgvGiay.CurrentRow.Cells[0].Value.ToString();
            txtTenGiay.Text = dgvGiay.CurrentRow.Cells[1].Value.ToString();          
            cmbThuongHieu.Text = dgvGiay.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvGiay.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaNhap.Text = dgvGiay.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaBan.Text = dgvGiay.CurrentRow.Cells[5].Value.ToString();
            txtAnh.Text = dgvGiay.CurrentRow.Cells[6].Value.ToString();
            txtGhiChu.Text = dgvGiay.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.Image = Image.FromFile(txtAnh.Text);
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btBoQua.Enabled = true;
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btBoQua.Enabled = true;
            btLuu.Enabled = true;
            btThem.Enabled = false;
            ResetValues();
            txtMaGiay.Enabled = true;
            txtMaGiay.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            //ktra
            if (txtMaGiay.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiay.Focus();
                return;
            }
            if (txtTenGiay.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGiay.Focus();
                return;
            }
            if (cmbThuongHieu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập thương hiệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbThuongHieu.Focus();
                return;
            }
            if (int.Parse(txtSoLuong.Text) == 0 )
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbThuongHieu.Focus();
                return;
            }
            if (txtAnh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbThuongHieu.Focus();
                return;
            }
            List<tblGiay> g = ConText.tblGiays.ToList();
            foreach(var item in g)
            {
                if(item.MaGiay == txtMaGiay.Text)
                {
                    MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaGiay.Focus();
                    return;
                }    
            }
            //them
            try
            {
                tblGiay gInsert = new tblGiay() { MaGiay = txtMaGiay.Text, TenGiay = txtTenGiay.Text, MaThuongHieu = cmbThuongHieu.SelectedValue.ToString(), SoLuong = float.Parse(txtSoLuong.Text), DonGiaNhap = float.Parse(txtDonGiaNhap.Text), DonGiaBan = float.Parse(txtDonGiaBan.Text), Anh = txtAnh.Text, GhiChu = txtGhiChu.Text };
                ConText.tblGiays.Add(gInsert);
                ConText.SaveChanges();
                MessageBox.Show("Đã Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDMGiay_Load(sender, e);
                ResetValues();
                btXoa.Enabled = true;
                btThem.Enabled = true;
                btSua.Enabled = true;
                btBoQua.Enabled = false;
                btLuu.Enabled = false;
                txtMaGiay.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //ktra
            if (dgvGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGiay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiay.Focus();
                return;
            }
            if (txtTenGiay.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGiay.Focus();
                return;
            }
            if (cmbThuongHieu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbThuongHieu.Focus();
                return;
            }

            //update
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    tblGiay gUpdate = ConText.tblGiays.FirstOrDefault(p => p.MaGiay == txtMaGiay.Text);
                    gUpdate.TenGiay = txtTenGiay.Text;
                    gUpdate.MaThuongHieu = cmbThuongHieu.SelectedValue.ToString();
                    gUpdate.SoLuong = float.Parse(txtSoLuong.Text);
                    gUpdate.DonGiaNhap = float.Parse(txtDonGiaNhap.Text);
                    gUpdate.DonGiaBan = float.Parse(txtDonGiaBan.Text);
                    gUpdate.Anh = txtAnh.Text;
                    gUpdate.GhiChu = txtGhiChu.Text;
                    ConText.SaveChanges();
                    MessageBox.Show("Đã Sửa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDMGiay_Load(sender, e);
                    ResetValues();
                    btBoQua.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGiay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Kiem tra xem đã có sản phẩm trong tblCTHD hôg
                    tblCTHD cTHDCheck = ConText.tblCTHDs.FirstOrDefault(p => p.tblGiay.MaGiay == txtMaGiay.Text);
                    if(cTHDCheck !=null)
                    {
                        MessageBox.Show("Giày đã có trong Hóa Đơn. Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //xóa
                    tblGiay gDelete = ConText.tblGiays.FirstOrDefault(p => p.MaGiay == txtMaGiay.Text);
                    ConText.tblGiays.Remove(gDelete);
                    ConText.SaveChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDMGiay_Load(sender, e);
                    ResetValues();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btThem.Enabled = true;
            btBoQua.Enabled = false;
            btLuu.Enabled = false;
            txtMaGiay.Enabled = false;
        }
        //lam hiện thị ảnh sản phẩm
        private void btMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
           
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
           
            List<tblGiay> g = ConText.tblGiays.ToList();
           
            List<tblGiay> lisGTK = g.Where(p => p.TenGiay.ToLower() == txtTenGiay.Text.ToLower()).ToList();
          
            if (lisGTK.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else 
            {
                MessageBox.Show("Có "+lisGTK.Count+" Sản Phẩm Cần Tìm Kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                dgvGiay.Rows.Clear();
                foreach(var item in lisGTK)
                {
                    int index = dgvGiay.Rows.Add();
                    dgvGiay.Rows[index].Cells[0].Value = item.MaGiay;
                    dgvGiay.Rows[index].Cells[1].Value = item.TenGiay;
                    dgvGiay.Rows[index].Cells[2].Value = item.tblThuongHieu.TenThuongHieu;
                    dgvGiay.Rows[index].Cells[3].Value = item.SoLuong;
                    dgvGiay.Rows[index].Cells[4].Value = item.DonGiaNhap;
                    dgvGiay.Rows[index].Cells[5].Value = item.DonGiaBan;
                    dgvGiay.Rows[index].Cells[6].Value = item.Anh;
                    dgvGiay.Rows[index].Cells[7].Value = item.GhiChu;
                }
            }
            

            ResetValues();
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            frmDMGiay_Load(sender, e);
            ResetValues();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btTimKiemTH_Click(object sender, EventArgs e)
        {
            if ((cmbThuongHieu.Text == ""))
            {
                MessageBox.Show("Bạn hãy chọn THƯƠNG HIỆU cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<tblGiay> g = ConText.tblGiays.ToList();
            int count = 0;
            
            List<tblGiay> lisGTK = g.Where(p => p.MaThuongHieu == cmbThuongHieu.SelectedValue.ToString()).ToList();
            if (lisGTK.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("Có "+lisGTK.Count+" Sản Phẩm Cần Tìm Kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvGiay.Rows.Clear();
                foreach (var item in lisGTK)
                {
                    int index = dgvGiay.Rows.Add();
                    dgvGiay.Rows[index].Cells[0].Value = item.MaGiay;
                    dgvGiay.Rows[index].Cells[1].Value = item.TenGiay;
                    dgvGiay.Rows[index].Cells[2].Value = item.tblThuongHieu.TenThuongHieu;
                    dgvGiay.Rows[index].Cells[3].Value = item.SoLuong;
                    dgvGiay.Rows[index].Cells[4].Value = item.DonGiaNhap;
                    dgvGiay.Rows[index].Cells[5].Value = item.DonGiaBan;
                    dgvGiay.Rows[index].Cells[6].Value = item.Anh;
                    dgvGiay.Rows[index].Cells[7].Value = item.GhiChu;
                }
            }
            ResetValues();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
