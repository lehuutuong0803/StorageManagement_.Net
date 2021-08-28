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

    public partial class frmDMKhachHang : Form
    {
        ContextGiayDB Context = new ContextGiayDB();
        DataTable tblKH;
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaKH.Enabled = false;
                btLuu.Enabled = false;
                btBoQua.Enabled = false;
                List<tblKhachHang> kh = Context.tblKhachHangs.ToList();
                LoadDataGridView(kh);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void LoadDataGridView(List<tblKhachHang> kh)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in kh)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.MaKhach;
                dgvKhachHang.Rows[index].Cells[1].Value = item.TenKhach;
                dgvKhachHang.Rows[index].Cells[2].Value = item.DiaChi;
                dgvKhachHang.Rows[index].Cells[3].Value = item.DienThoai;
            }
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (btThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (dgvKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            maDienThoai.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
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
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
        }

        private void ResetValues()
        {
            txtTenKH.Text = "";
            txtMaKH.Text = "";
            txtDiaChi.Text = "";
            maDienThoai.Text = "";

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
           
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (maDienThoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maDienThoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            List<tblKhachHang> kh = Context.tblKhachHangs.ToList();
            string m = txtMaKH.Text;
           foreach(var item in kh)
            {
                if (item.MaKhach == m)
                {
                    MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Focus();
                    return;
                }
            }
            //Thêm KH
            try
            {
                tblKhachHang k = new tblKhachHang() { MaKhach = txtMaKH.Text, TenKhach = txtTenKH.Text, DiaChi = txtDiaChi.Text, DienThoai = maDienThoai.Text };
                Context.tblKhachHangs.Add(k);
                Context.SaveChanges();
                MessageBox.Show("Lưu Thành Công!");
                frmDMKhachHang_Load(sender, e);
                ResetValues();
                btXoa.Enabled = true;
                btThem.Enabled = true;
                btSua.Enabled = true;
                btBoQua.Enabled = false;
                btLuu.Enabled = false;
                txtMaKH.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaKH.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                                        //Kiem tra xem đã có sản phẩm trong tblCTHD hôg
                    tblHDBan hDBanCheck = Context.tblHDBans.FirstOrDefault(p => p.tblKhachHang.MaKhach == txtMaKH.Text);
                    if(hDBanCheck !=null)
                    {
                        MessageBox.Show("Khách Hàng đã có trong Hóa Đơn. Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string m = txtMaKH.Text;
                    tblKhachHang k = Context.tblKhachHangs.FirstOrDefault(p => p.MaKhach == m);
                    Context.tblKhachHangs.Remove(k);
                    Context.SaveChanges();
                    MessageBox.Show("Xóa Thành Công!");
                    frmDMKhachHang_Load(sender, e);
                    ResetValues();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                //ktra
                if (dgvKhachHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenKH.Focus();
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Focus();
                    return;
                }
                if (maDienThoai.Text == "(   )    -")
                {
                    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maDienThoai.Focus();
                    return;
                }
                //Update
                if (MessageBox.Show("Bạn có muốn sửa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string m = txtMaKH.Text;
                    tblKhachHang k = Context.tblKhachHangs.FirstOrDefault(p => p.MaKhach == m);
                    k.TenKhach = txtTenKH.Text;
                    k.DiaChi = txtDiaChi.Text;
                    k.DienThoai = maDienThoai.Text;
                    Context.SaveChanges();
                    ResetValues();
                    MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDMKhachHang_Load(sender, e);
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
            btBoQua.Enabled = false;
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btLuu.Enabled = false;
            txtMaKH.Enabled = false;
            btThem.Focus();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
