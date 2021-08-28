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
    public partial class frmTKHoaDon : Form
    {
        ContextGiayDB ConText = new ContextGiayDB();

        public frmTKHoaDon()
        {
            InitializeComponent();
        }

        private void frmTKHoaDon_Load(object sender, EventArgs e)
        {
            ResetValue();
            dgvTimKiemHoaDon.Rows.Clear();
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
        private void ResetValue()
        {
            txtMaHoaDon.Text = "";
            txtMaKhachHang.Text = "";
            txtMaNhanVien.Text = "";
            txtMaHoaDon.Focus();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Hãy nhập Mã Nhân Viên tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<tblHDBan> g = ConText.tblHDBans.ToList();
            int count = 0;
            List<tblHDBan> lisGTK = g.Where(p => p.MaNhanVien.ToLower() == txtMaNhanVien.Text.ToLower()).ToList();

            if (lisGTK.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("Có " + lisGTK.Count + " Hóa Đơn Cần Tìm Kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView(lisGTK);
            }

        }

        private void LoadDataGridView(List<tblHDBan> listHDBan)
        {
            dgvTimKiemHoaDon.Rows.Clear();
            foreach (var item in listHDBan)
            {
                int index = dgvTimKiemHoaDon.Rows.Add();
                dgvTimKiemHoaDon.Rows[index].Cells[0].Value = item.MaHDBan;
                dgvTimKiemHoaDon.Rows[index].Cells[1].Value = item.MaNhanVien;
                dgvTimKiemHoaDon.Rows[index].Cells[2].Value = item.NgayBan;
                dgvTimKiemHoaDon.Rows[index].Cells[3].Value = item.MaKhach;
                dgvTimKiemHoaDon.Rows[index].Cells[4].Value = item.TongTien;
            }
        }

        private void btTimLai_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvTimKiemHoaDon.Rows.Clear();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void dgvTimKiemHoaDon_DoubleClick(object sender, EventArgs e)
         {
             string mahd;
             if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 mahd = dgvTimKiemHoaDon.CurrentRow.Cells[0].Value.ToString();
                 frmHDHoaDonBan frm = new frmHDHoaDonBan();
                frm.Sender(mahd);    //Gọi delegate
                frm.TimKiem(sender,e);
                frm.StartPosition = FormStartPosition.CenterParent;
                 frm.ShowDialog();
             
             }
         }

        private void btTKMaHD_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Hãy nhập Mã Hóa Đơn tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<tblHDBan> g = ConText.tblHDBans.ToList();
            int count = 0;
            List<tblHDBan> lisGTK = g.Where(p => p.MaHDBan.ToLower() == txtMaHoaDon.Text.ToLower()).ToList();

            if (lisGTK.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("Có " + lisGTK.Count + " Hóa Đơn Cần Tìm Kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView(lisGTK);
            }
        }

        private void btTKMaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Hãy nhập Mã Khách Hàng tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<tblHDBan> g = ConText.tblHDBans.ToList();
            int count = 0;
            List<tblHDBan> lisGTK = g.Where(p => p.MaKhach.ToLower() == txtMaKhachHang.Text.ToLower()).ToList();

            if (lisGTK.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("Có"+lisGTK.Count +" Hóa Đơn Cần Tìm Kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView(lisGTK);
            }
        }
    }
}