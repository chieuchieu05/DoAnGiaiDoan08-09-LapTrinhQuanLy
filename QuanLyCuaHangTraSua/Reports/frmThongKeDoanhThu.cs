using Microsoft.Reporting.WinForms;
using QuanLyCuaHangTraSua.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCuaHangTraSua.Reports.QLCHTSDataSet;

namespace QuanLyCuaHangTraSua.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLCHTSDbContext context = new QLCHTSDbContext();
        QLCHTSDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLCHTSDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NgayLap = r.NgayLap,
                TongTien = r.TongTien,
                HoVaTenNhanVien = r.NhanVien.TenNV,
                HoVaTenKhachHang = r.KhachHang.TenKH,
            }).ToList();
            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                row.ID,
                row.NgayLap,
                row.TongTien,
                row.HoVaTenNhanVien,
                row.HoVaTenKhachHang);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "Reports\\rptThongKeDoanhThu.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NgayLap = r.NgayLap,
                TongTien = r.ChiTietHoaDon.Sum(r => r.SoLuong * r.DonGia),
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.TenNV,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.TenKH

            });
            danhSachHoaDon = danhSachHoaDon.Where(r => r.NgayLap >= dtpTuNgay.Value && r.NgayLap <= dtpDenNgay.Value);
            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.ID,
                row.NgayLap,
                row.TongTien,
                row.HoVaTenNhanVien,
                row.HoVaTenKhachHang
                );
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "Reports\\rptThongKeDoanhThu.rdlc");
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Từ ngày " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }
    }
}

