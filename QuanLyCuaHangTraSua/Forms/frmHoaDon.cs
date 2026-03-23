using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangTraSua.Data;
using QuanLyCuaHangTraSua.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTraSua.Forms
{
    public partial class frmHoaDon : Form
    {
        QLCHTSDbContext context = new QLCHTSDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void DinhDangDataGridView()
        {

            dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Font = new Font(dgvHoaDon.Font, FontStyle.Bold);

            dgvHoaDon.Columns["TongTien"].DefaultCellStyle.ForeColor = Color.Blue;

            dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";  // N0 = phân cách hàng nghìn, không có số lẻ


            dgvHoaDon.Columns["NgayLap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHoaDon.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.TenNV,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.TenKH,
                NgayLap = r.NgayLap,
                TongTien = r.TongTien,
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dgvHoaDon.DataSource = hd;
            DinhDangDataGridView();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmChiTiet_HoaDon chiTiet = new frmChiTiet_HoaDon())
            {
                chiTiet.ShowDialog();
            }

            // reload lại danh sách sau khi đóng form
            dgvHoaDon.DataSource = context.HoaDon.ToList();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["colID"].Value.ToString());
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["colID"].Value.ToString());
            using (frmChiTiet_HoaDon chiTiet = new frmChiTiet_HoaDon(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xoá hoá đơn ", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["colID"].Value.ToString());
                HOADON hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();

                frmHoaDon_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất hóa đơn ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ===== SHEET1: HOA DON =====
                    DataTable tableHoaDon = new DataTable();
                    tableHoaDon.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("colID", typeof(int)),
                        new DataColumn("HoVaTenNhanVien", typeof(string)),
                        new DataColumn("HoVaTenKhachHang", typeof(string)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("TongTienHoaDon", typeof(string)),
                        new DataColumn("XemChiTiet", typeof(string)),
                    });

                    var hoaDon = context.HoaDon.Include(x => x.NhanVien).Include(x => x.KhachHang).ToList();

                    foreach (var hd in hoaDon)
                    {
                        tableHoaDon.Rows.Add(
                            hd.ID,
                            hd.NhanVien.TenNV,
                            hd.KhachHang.TenKH,
                            hd.NgayLap
                        );
                    }

                    // ===== SHEET2: CHI TIET HOA DON =====
                    DataTable tableChiTiet = new DataTable();
                    tableChiTiet.Columns.AddRange(new DataColumn[4]
                    {
                        new DataColumn("colID", typeof(int)),
                        new DataColumn("TenSanPham", typeof(string)),
                        new DataColumn("DonGiaBan", typeof(int)),
                        new DataColumn("SoLuongBan", typeof(int))

                    });

                    var chiTiet = context.ChiTietHoaDon.Include(x => x.SanPham).ToList();

                    foreach (var ct in chiTiet)
                    {
                        tableChiTiet.Rows.Add(
                            ct.HoaDonID,
                            ct.SanPham.TenSP,
                            ct.SoLuong,
                            ct.DonGia
                        );
                    }

                    // ===== XUAT EXCEL =====
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tableHoaDon, "HoaDon");
                        sheet1.Columns().AdjustToContents();

                        var sheet2 = wb.Worksheets.Add(tableChiTiet, "ChiTietHoaDon");
                        sheet2.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
