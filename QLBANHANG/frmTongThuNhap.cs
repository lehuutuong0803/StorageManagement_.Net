using QLBANHANG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBANHANG.Reportings;
using Microsoft.Reporting.WinForms;

namespace QLBANHANG
{
    public partial class frmTongThuNhap : Form
    {

        ContextGiayDB Context = new ContextGiayDB();
        public frmTongThuNhap()
        {
            InitializeComponent();
        }

      

        private void frmTongThuNhap_Load(object sender, EventArgs e)
        {
            HienThiHoaDonKetQua();
        }

        private void HienThiHoaDonKetQua()
        {
            string slq = "SELECT b.MaHDBan , b.MaKhach,b.MaNhanVien,b.NgayBan,b.TongTien FROM tblHDBan b";

            List<TongThuNhap> danhSach = Context.Database.SqlQuery<TongThuNhap>(slq).ToList();

            var reportDataSource = new ReportDataSource("DataSet1", danhSach);
            this.rpvTongThuNhap.LocalReport.DataSources.Clear();
            this.rpvTongThuNhap.LocalReport.DataSources.Add(reportDataSource);
            this.rpvTongThuNhap.RefreshReport();
        }
    }
}
