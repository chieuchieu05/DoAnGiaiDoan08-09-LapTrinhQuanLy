using Microsoft.EntityFrameworkCore;
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

namespace QuanLyCuaHangTraSua.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLCHTSDbContext context = new QLCHTSDbContext();
        QLCHTSDataSet.DanhSachHoaDonChiTietDataTable danhSachHoaDon_ChiTietDataTable = new QLCHTSDataSet.DanhSachHoaDonChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id; // Mã hóa đơn
        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Include(r => r.KhachHang).Include(r => r.ChiTietHoaDon).Where(r => r.ID == id).SingleOrDefault();
            if (hoaDon != null)
            {
                var hoaDonChiTiet = context.ChiTietHoaDon.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSP,
                    SoLuong = r.SoLuong,
                    DonGia = r.DonGia,
                    ThanhTien = r.ThanhTien
                }).ToList();
                danhSachHoaDon_ChiTietDataTable.Clear();
                foreach (var row in hoaDonChiTiet)
                {
                    danhSachHoaDon_ChiTietDataTable.AddDanhSachHoaDonChiTietRow(row.ID,
                    row.HoaDonID,
                    row.SanPhamID,
                    row.TenSanPham,
                    row.SoLuong,
                    row.DonGia,
                    row.ThanhTien);
                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachHoaDonChiTiet";
                reportDataSource.Value = danhSachHoaDon_ChiTietDataTable;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");

                //MessageBox.Show(hoaDon.KhachHang.TenKH);//
                ReportParameter[] param = new ReportParameter[]
                {
                    new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}", hoaDon.NgayLap.Day, hoaDon.NgayLap.Month,hoaDon.NgayLap.Year)),
                    new ReportParameter("NguoiBan_Ten", "TIỆM TRÀ SỮA CỘNG ĐỒNG"),
                    new ReportParameter("NguoiBan_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
                    new ReportParameter("NguoiBan_MaSoThue", "1602162070"),
                    new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.TenKH),
                    new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChiKH),
                    new ReportParameter("NguoiMua_MaSoThue", "")
                };
                /**IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}", hoaDon.NgayLap.Day, hoaDon.NgayLap.Month,hoaDon.NgayLap.Year)),
                    new ReportParameter("NguoiBan_Ten", "TIỆM TRÀ SỮA CỘNG ĐỒNG"),
                    new ReportParameter("NguoiBan_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
                    new ReportParameter("NguoiBan_MaSoThue", "1602162070"),
                    new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.TenKH),
                    new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChiKH),
                    new ReportParameter("NguoiMua_MaSoThue", "")
                };**/

                reportViewer.LocalReport.SetParameters(param);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }
    }
}
    

