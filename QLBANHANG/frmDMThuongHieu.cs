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
    public partial class frmDMThuongHieu : Form
    {
        DataTable tblThuongHieu;
        ContextGiayDB ConText = new ContextGiayDB();
        private string tDangNhap;

        public frmDMThuongHieu()
        {
            InitializeComponent();
        }

        public frmDMThuongHieu(string tDangNhap)
        {
            InitializeComponent();
            this.tDangNhap = tDangNhap;
        }

        private void frmDMThuongHieu_Load(object sender, EventArgs e)
        {
            List<tblThuongHieu> listTH = ConText.tblThuongHieux.ToList();
            txtMaThuongHieu.Enabled = false;
            btLuu.Enabled = false;
            btBoQua.Enabled = false;
            BindGrid(listTH);

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
        private void BindGrid(List<tblThuongHieu> listTH)
        {
            dgvThuongHieu.Rows.Clear();
            foreach(var item in listTH)
            {
                int index = dgvThuongHieu.Rows.Add();
                dgvThuongHieu.Rows[index].Cells[0].Value = item.MaThuongHieu;
                dgvThuongHieu.Rows[index].Cells[1].Value = item.TenThuongHieu;
            }
        }

        private void dgvThuongHieu_Click(object sender, EventArgs e)
        {
            if (btThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaThuongHieu.Focus();
                return;
            }
            if (dgvThuongHieu.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaThuongHieu.Text = dgvThuongHieu.CurrentRow.Cells["MaThuongHieu"].Value.ToString();
            txtTenThuongHieu.Text = dgvThuongHieu.CurrentRow.Cells["TenThuongHieu"].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btBoQua.Enabled = true;
            btLuu.Enabled = true;
            btThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaThuongHieu.Enabled = true; //cho phép nhập mới
            txtMaThuongHieu.Focus();
        }

        private void ResetValue()
        {
            txtMaThuongHieu.Text = "";
            txtTenThuongHieu.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if(txtMaThuongHieu.Text =="")
            {
                MessageBox.Show("Vui Lòng Nhập MÃ Thương Hiệu!");
                return;
            }
            if (txtTenThuongHieu.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập TÊN Thương Hiệu!");
                return;
            }
            List<tblThuongHieu> listTH = ConText.tblThuongHieux.ToList();
            foreach(var item in listTH)
            {
                if(txtMaThuongHieu.Text == item.MaThuongHieu)
                {
                    MessageBox.Show("MÃ Thương Hiệu Đã Có. Vui Lòng Nhập Mã Khác");
                    return;
                }
                if (txtTenThuongHieu.Text == item.TenThuongHieu)
                {
                    MessageBox.Show("TÊN Thương Hiệu Đã Có. Vui Lòng Nhập Mã Khác");
                    return;
                }
            }
            tblThuongHieu th = new tblThuongHieu() { MaThuongHieu = txtMaThuongHieu.Text, TenThuongHieu = txtTenThuongHieu.Text };
            ConText.tblThuongHieux.Add(th);
            ConText.SaveChanges();
            MessageBox.Show("Đã Lưu Thành Công!");
            frmDMThuongHieu_Load(sender,e);
            btXoa.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btBoQua.Enabled = false;
            btLuu.Enabled = false;
            txtMaThuongHieu.Enabled = false;
            return;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(dgvThuongHieu.Rows.Count == 0)
            {
                MessageBox.Show("Không Còn Dữ Liệu!");
                return;
            }
            if(txtMaThuongHieu.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Bản Ghi Nào!");
                return;
            }
            if(txtTenThuongHieu.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập TÊN Thương Hiệu!");
                return;
            }
            string m = txtMaThuongHieu.Text;
            tblThuongHieu thUpdate = ConText.tblThuongHieux.FirstOrDefault(p => p.MaThuongHieu == m);
            if( thUpdate != null)
            {
                thUpdate.TenThuongHieu = txtTenThuongHieu.Text;
                ConText.SaveChanges();
                MessageBox.Show("Update Thành Công!");
            }
            frmDMThuongHieu_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvThuongHieu.Rows.Count == 0)
            {
                MessageBox.Show("Không Còn Dữ Liệu!");
                return;
            }
            if (txtMaThuongHieu.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Bản Ghi Nào!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string m = txtMaThuongHieu.Text;
                    //Kiêm tra xem đã có trong bảng DM Giày chưa
                    tblGiay sRemove = ConText.tblGiays.FirstOrDefault(p => p.tblThuongHieu.MaThuongHieu == m);
                    if(sRemove != null)
                    {
                        MessageBox.Show("Thương Hiệu Này Đã Nhập Vào DM Giày. Không Thể Xóa!");
                        return;
                    }
                    //Chưa có mới cho xóa TH
                    tblThuongHieu thDlt = ConText.tblThuongHieux.FirstOrDefault(p => p.MaThuongHieu == m);
                    ConText.tblThuongHieux.Remove(thDlt);
                    ConText.SaveChanges();
                    MessageBox.Show("Xóa Thành Công!");
                    ResetValue();
                }
                frmDMThuongHieu_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btBoQua.Enabled = false;
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btLuu.Enabled = false;
            txtMaThuongHieu.Enabled = false;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
