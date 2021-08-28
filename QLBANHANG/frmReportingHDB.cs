using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLBANHANG.Models;
using QLBANHANG.Reportings;
namespace QLBANHANG
{
    public partial class frmReportingHDB : Form
    {
        ContextGiayDB Context = new ContextGiayDB();
        public frmReportingHDB()
        {
            InitializeComponent();
        }

        public frmReportingHDB(string text)
        {
            InitializeComponent();
            txtMaHoaDon.Text = text;
        }

        private void frmReportingHDB_Load(object sender, EventArgs e)
        {
            HienThiHoaDonKetQua();
        }

        private void HienThiHoaDonKetQua()
        {
            string slq = "SELECT b.MaHDBan , b.MaKhach,b.NgayBan, c.TenGiay,a.SoLuong,a.ThanhTien,b.TongTien  FROM tblCTHD a, tblHDBan b, tblGiay c WHERE a.MaHDBan = b.MaHDBan AND a.MaGiay = c.MaGiay";

            List<InHoaDon> danhSach = Context.Database.SqlQuery<InHoaDon>(slq).ToList();
         
            if (txtMaHoaDon.Text != "")
            {
                danhSach = danhSach.Where(hd => hd.MaHDBan.ToLower()==txtMaHoaDon.Text.ToLower()).ToList();
               
            }

            var reportDataSource = new ReportDataSource("InHoaDonDataset", danhSach);
            this.rpvXuatHoaDon.LocalReport.DataSources.Clear();
            this.rpvXuatHoaDon.LocalReport.DataSources.Add(reportDataSource);
            this.rpvXuatHoaDon.RefreshReport();
        }
    }
}
