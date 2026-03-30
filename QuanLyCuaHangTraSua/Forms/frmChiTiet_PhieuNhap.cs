using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class frmChiTiet_PhieuNhap : Form
    {
        QLCHTSDbContext context = new QLCHTSDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachPhieuNhap_ChiTiet> phieuNhapChiTIet = new BindingList<DanhSachPhieuNhap_ChiTiet>();
        public frmChiTiet_PhieuNhap(int maPhieuNhap = 0)
        {
            InitializeComponent();
            id = maPhieuNhap;
        }
        public frmChiTiet_PhieuNhap()
        {
            InitializeComponent();
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "TenNV";
        }
        public void LayNhaCungCapVaoComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNCC";
        }
        public void LayNguyenLieuVaoComboBox()
        {
            cboNguyenLieu.DataSource = context.NguyenLieu.ToList();
            cboNguyenLieu.ValueMember = "ID";
            cboNguyenLieu.DisplayMember = "TenNL";
        }
        public void BatTatChucNang()
        {
            if (id == 0 && dgvChiTietPhieuNhap.Rows.Count == 0) // Thêm
            {
                // Xóa trắng các trường
                cboNhaCungCap.Text = "";
                cboNhanVien.Text = "";
                cboNguyenLieu.Text = "";
                numSoLuongNhap.Value = 1;
                numGiaNhap.Value = 0;
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm
            btnLuuPhieuNhap.Enabled = dgvChiTietPhieuNhap.Rows.Count > 0;
            btnXoa.Enabled = dgvChiTietPhieuNhap.Rows.Count > 0;
        }
        private void frmChiTiet_PhieuNhap_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayNhaCungCapVaoComboBox();
            LayNguyenLieuVaoComboBox();
            dgvChiTietPhieuNhap.AutoGenerateColumns = false;
            if (id != 0) // Đã tồn tại chi tiết
            {
                var phieuNhap = context.PhieuNhap.Where(r => r.ID == id).SingleOrDefault();
                cboNhanVien.SelectedValue = phieuNhap.NhanVienID;
                cboNhaCungCap.SelectedValue = phieuNhap.NhaCungCapID;

                var ct = context.ChiTietPhieuNhap.Where(r => r.PhieuNhapID == id).Select(r => new DanhSachPhieuNhap_ChiTiet
                {
                    ID = r.ID,
                    PhieuNhapID = r.PhieuNhapID,
                    NguyenLieuID = r.NguyenLieuID,
                    TenNguyenLieu = r.NguyenLieu.TenNL,
                    SoLuong = r.SoLuong,
                    GiaNhap = r.GiaNhap,
                    ThanhTien = Convert.ToInt32(r.SoLuong * r.GiaNhap)
                }).ToList();
                phieuNhapChiTIet = new BindingList<DanhSachPhieuNhap_ChiTiet>(ct);
            }
            dgvChiTietPhieuNhap.DataSource = phieuNhapChiTIet;
            MessageBox.Show("ID truyền sang = " + id);
        }

        private void btnXacNhanNhapHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNguyenLieu.Text))
                MessageBox.Show("Vui lòng chọn nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongNhap.Value <= 0)
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numGiaNhap.Value <= 0)
                MessageBox.Show("Giá nhập nguyên liệu phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                int maNguyenLieu = Convert.ToInt32(cboNguyenLieu.SelectedValue.ToString());
                var chiTiet = phieuNhapChiTIet.FirstOrDefault(x => x.NguyenLieuID == maNguyenLieu);
                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin 
                if (chiTiet != null)
                {
                    chiTiet.SoLuong = Convert.ToInt16(numSoLuongNhap.Value);
                    chiTiet.GiaNhap = Convert.ToInt32(numGiaNhap.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongNhap.Value * numGiaNhap.Value);
                    dgvChiTietPhieuNhap.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachPhieuNhap_ChiTiet ct = new DanhSachPhieuNhap_ChiTiet
                    {
                        ID = 0,
                        PhieuNhapID = id,
                        NguyenLieuID = maNguyenLieu,
                        TenNguyenLieu = cboNguyenLieu.Text,
                        SoLuong = Convert.ToInt16(numSoLuongNhap.Value),
                        GiaNhap = Convert.ToInt32(numGiaNhap.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongNhap.Value * numGiaNhap.Value)
                    };
                    phieuNhapChiTIet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNguyenLieu = Convert.ToInt32(dgvChiTietPhieuNhap.CurrentRow.Cells["NguyenLieuID"].Value.ToString());
            var chiTiet = phieuNhapChiTIet.FirstOrDefault(x => x.NguyenLieuID == maNguyenLieu);
            if (chiTiet != null)
            {
                phieuNhapChiTIet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNhaCungCap.Text))
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Đã tồn tại chi tiết thì chỉ cập nhật
                {
                    PHIEUNHAP pn = context.PhieuNhap.Find(id);
                    if (pn != null)
                    {
                        pn.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                        pn.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue.ToString());
                        decimal tongTien = phieuNhapChiTIet.Sum(x => x.ThanhTien);
                        pn.TongTien = tongTien;

                        context.PhieuNhap.Update(pn);
                        // Xóa chi tiết cũ
                        var old = context.ChiTietPhieuNhap.Where(r => r.PhieuNhapID == id).ToList();
                        context.ChiTietPhieuNhap.RemoveRange(old);
                        // Thêm lại chi tiết mới
                        foreach (var item in phieuNhapChiTIet.ToList())
                        {
                            CHITIETPHIEUNHAP ct = new CHITIETPHIEUNHAP();
                            ct.PhieuNhapID = id;
                            ct.NguyenLieuID = item.NguyenLieuID;
                            ct.SoLuong = item.SoLuong;
                            ct.GiaNhap = item.GiaNhap;
                            context.ChiTietPhieuNhap.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else // Thêm mới
                {
                    PHIEUNHAP pn = new PHIEUNHAP();
                    pn.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                    pn.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue.ToString());
                    pn.NgayLap = DateTime.Now;
                    decimal tongTien = phieuNhapChiTIet.Sum(x => x.ThanhTien);
                    pn.TongTien = tongTien;

                    context.PhieuNhap.Add(pn);
                    context.SaveChanges();
                    // Thêm chi tiết
                    foreach (var item in phieuNhapChiTIet.ToList())
                    {
                        CHITIETPHIEUNHAP ct = new CHITIETPHIEUNHAP();
                        ct.PhieuNhapID = pn.ID;
                        ct.NguyenLieuID = item.NguyenLieuID;
                        ct.SoLuong = item.SoLuong;
                        ct.GiaNhap = item.GiaNhap;
                        context.ChiTietPhieuNhap.Add(ct);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboNguyenLieu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maNguyenLieu = Convert.ToInt32(cboNguyenLieu.SelectedValue.ToString());
            var nguyenLieu = context.NguyenLieu.Find(maNguyenLieu);
            numGiaNhap.Value = nguyenLieu.GiaNL;
        }

        private void dgvChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietPhieuNhap.Rows[e.RowIndex];

                numGiaNhap.Value = Convert.ToDecimal(row.Cells["GiaNhap"].Value);
                numSoLuongNhap.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);
                MessageBox.Show("ID = " + row.Cells["NguyenLieuID"].Value);
                cboNguyenLieu.SelectedValue = row.Cells["NguyenLieuID"].Value; //
                
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
