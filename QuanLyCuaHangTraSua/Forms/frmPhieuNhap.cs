using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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

namespace QuanLyCuaHangTraSua.Forms
{
    public partial class frmPhieuNhap : Form
    {
        QLCHTSDbContext context = new QLCHTSDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void DinhDangDataGridView()
        {

            dgvPhieuNhap.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPhieuNhap.Columns["TongTien"].DefaultCellStyle.Font = new Font(dgvPhieuNhap.Font, FontStyle.Bold);

            dgvPhieuNhap.Columns["TongTien"].DefaultCellStyle.ForeColor = Color.Blue;

            dgvPhieuNhap.Columns["TongTien"].DefaultCellStyle.Format = "N0";  // N0 = phân cách hàng nghìn, không có số lẻ


            dgvPhieuNhap.Columns["NgayLap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPhieuNhap.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.AutoGenerateColumns = false;
            List<DanhSachPhieuNhap> pn = new List<DanhSachPhieuNhap>();
            pn = context.PhieuNhap.Select(r => new DanhSachPhieuNhap
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.TenNV,
                NhaCungCapID = r.NhaCungCapID,
                TenNhaCungCap = r.NhaCungCap.TenNCC,
                NgayLap = r.NgayLap,
                TongTien = r.TongTien,
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dgvPhieuNhap.DataSource = pn;
            DinhDangDataGridView();
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            using (frmChiTiet_PhieuNhap chiTiet = new frmChiTiet_PhieuNhap())
            {
                chiTiet.ShowDialog();
            }

            // reload lại danh sách sau khi đóng form
            //dgvPhieuNhap.DataSource = context.PhieuNhap.ToList();
            frmPhieuNhap_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["colID"].Value.ToString());
            using (frmChiTiet_PhieuNhap chiTiet = new frmChiTiet_PhieuNhap(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xoá phiêu nhập ", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["colID"].Value.ToString());
                PHIEUNHAP pn = context.PhieuNhap.Find(id);
                if (pn != null)
                {
                    context.PhieuNhap.Remove(pn);
                }
                context.SaveChanges();

                frmPhieuNhap_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmPhieuNhap_Load(sender, e);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất phiếu nhập ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "PhieuNhap_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ===== SHEET1: PHIEUNHAP =====
                    DataTable tablePhieuNhap = new DataTable();
                    tablePhieuNhap.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("colID", typeof(int)),
                        new DataColumn("HoVaTenNhanVien", typeof(string)),
                        new DataColumn("TenNhaCungCap", typeof(string)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("TongTien", typeof(string)),
                        new DataColumn("XemChiTiet", typeof(string)),
                    });

                    var phieuNhap = context.PhieuNhap.Include(x => x.NhanVien).Include(x => x.NhaCungCap).ToList();

                    foreach (var hd in phieuNhap)
                    {
                        tablePhieuNhap.Rows.Add(
                            hd.ID,
                            hd.NhanVien.TenNV,
                            hd.NhaCungCap.TenNCC,
                            hd.NgayLap
                        );
                    }

                    // ===== SHEET2: CHI TIET PHIEU NHAP =====
                    DataTable tableChiTiet = new DataTable();
                    tableChiTiet.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("colID", typeof(int)),
                        new DataColumn("TenNguyenLieu", typeof(string)),
                        new DataColumn("DonGia", typeof(int)),
                        new DataColumn("SoLuong", typeof(int)),
                        new DataColumn("ThanhTien", typeof(decimal))

                    });

                    var chiTiet = context.ChiTietPhieuNhap.Include(x => x.NguyenLieu).ToList();

                    foreach (var ct in chiTiet)
                    {
                        tableChiTiet.Rows.Add(
                            ct.PhieuNhapID,
                            ct.NguyenLieu.TenNL,
                            ct.SoLuong,
                            ct.GiaNhap
                        );
                    }

                    // ===== XUAT EXCEL =====
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tablePhieuNhap, "PhieuNhap");
                        sheet1.Columns().AdjustToContents();

                        var sheet2 = wb.Worksheets.Add(tableChiTiet, "ChiTietPhieuNhap");
                        sheet2.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
