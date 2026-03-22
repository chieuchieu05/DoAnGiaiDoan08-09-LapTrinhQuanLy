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
    public partial class frmThongKeSanPham : Form
    {
        QLCHTSDbContext context = new QLCHTSDbContext();
        QLCHTSDataSet.DanhSachSanPhamDataTable danhSachSanPhamDataTable = new QLCHTSDataSet.DanhSachSanPhamDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoaiSP";
        }
        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            LayLoaiSanPhamVaoComboBox();

            var danhSachSanPham = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                TenSP = r.TenSP,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoaiSP = r.LoaiSanPham.TenLoaiSP,
                Size = r.Size,
                SoLuong = r.SoLuong,
                Gia = r.Gia,
                TrangThaiSP = r.TrangThaiSP,
                HinhAnh = r.HinhAnh
            }).ToList();
            danhSachSanPhamDataTable.Clear();
            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AddDanhSachSanPhamRow(
                row.ID,
                row.TenSP,
                row.LoaiSanPhamID,
                row.TenLoaiSP,
                row.Size,
                row.SoLuong,
                row.Gia,
                row.TrangThaiSP,
                row.HinhAnh);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachSanPham";
            reportDataSource.Value = danhSachSanPhamDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "Reports\\rptThongKeSanPham.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả sản phẩm)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.Text == "")
            {
                // Nếu ComboBox bỏ trống thì hiển thị tất cả
                frmThongKeSanPham_Load(sender, e);
            }
            else
            {
                var danhSachSanPham = context.SanPham.Select(r => new DanhSachSanPham
                {
                    ID = r.ID,
                    TenSP = r.TenSP,
                    LoaiSanPhamID = r.LoaiSanPhamID,
                    TenLoaiSP = r.LoaiSanPham.TenLoaiSP,
                    Size = r.Size,
                    SoLuong = r.SoLuong,
                    Gia = r.Gia,
                    TrangThaiSP = r.TrangThaiSP,
                    HinhAnh = r.HinhAnh
                });

                string loaiSanPham = null;
                
                if (cboLoaiSanPham.Text != "")
                {
                    int loaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue.ToString());
                    loaiSanPham += "Phân loại: " + cboLoaiSanPham.Text;
                    danhSachSanPham = danhSachSanPham.Where(r => r.LoaiSanPhamID == loaiSanPhamID);
                }
                danhSachSanPhamDataTable.Clear();
                foreach (var row in danhSachSanPham)
                {
                    danhSachSanPhamDataTable.AddDanhSachSanPhamRow(row.ID,
                    row.TenSP,
                    row.LoaiSanPhamID,
                    row.TenLoaiSP,
                    row.Size,
                    row.SoLuong,
                    row.Gia,
                    row.TrangThaiSP,
                    row.HinhAnh);
                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachSanPham";
                reportDataSource.Value = danhSachSanPhamDataTable;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "Reports\\rptThongKeSanPham.rdlc");
                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + loaiSanPham + ")");
                reportViewer.LocalReport.SetParameters(reportParameter);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }
    }
}
    
