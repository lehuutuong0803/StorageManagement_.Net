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
    public partial class frmDangNhap : Form
    {
        static string  nameTK;
        public event ChungThucTaiKhoan chungThucThongTinTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ContextGiayDB tk = new ContextGiayDB();
            List<tblTaiKhoan> listTK = tk.tblTaiKhoans.ToList();   
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

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                MessageBox.Show("Chưa nhập Tài Khoản");
                return;
            }
            if(txtPassWord.Text == "")
            {
                MessageBox.Show("Chưa nhập Mật Khuẩu");
            }    

            string UserName = txtUserName.Text;
            string PassWord = txtPassWord.Text;
            
            //ktr tkhoan
            using (var Context = new ContextGiayDB())
            {
                if( Context.tblTaiKhoans.Any(Tk => Tk.TaiKhoan == UserName && Tk.MatKhau == PassWord))
                {
                    chungThucThongTinTaiKhoan(this.txtUserName.Text);
                    MessageBox.Show("Đăng Nhâp Thành Công!");
                    nameTK = txtUserName.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại!");
                    return;
                }
            }
        }

       

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap_Click(this, new EventArgs());

            }
        }
    }
}
