using QuanLyCuaHangTraSua.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using QuanLyCuaHangTraSua.Reports;

namespace QuanLyCuaHangTraSua.Forms
{
    public partial class frmMain : Form
    {
        QLCHTSDbContext context = new QLCHTSDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        frmLoaiSanPham loaiSanPham = null;
        frmSanPham sanPham = null;
        frmKhachHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmHoaDon hoaDon = null;
        frmPhieuNhap phieuNhap = null;
        frmNguyenLieu nguyenLieu = null;
        frmCongThuc congThuc = null;
        frmNhaCungCap nhaCungCap = null;
        frmDangNhap dangNhap = null;
        frmThongKeSanPham thongKeSanPham = null;
        frmThongKeDoanhThu thongKeDoanhThu = null;
        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status.
        public frmMain()
        {
            InitializeComponent();
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.MatKhau))
                        {
                            Session.CurrentUser = nhanVien;
                            hoVaTenNhanVien = nhanVien.TenNV;
                            if (nhanVien.VaiTro == true)
                                QuyenQuanLy();
                            else if (nhanVien.VaiTro == false)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        public void ChuaDangNhap()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;
            // Mờ tất cả
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuLoaiSanPham.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;
            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng quản lý không được phép
            // Sáng đăng xuất và các chức năng quản lý được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuLoaiSanPham.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }
        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng nhân viên không được phép
            mnuLoaiSanPham.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;
            // Sáng đăng xuất và các chức năng nhân viên được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void OpenForm(Form f)
        {
            panelMain.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelMain.Controls.Add(f);
            f.Show();
        }
        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new frmLoaiSanPham();
                loaiSanPham.MdiParent = this;
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.MdiParent = this;
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            //if (khachHang == null || khachHang.IsDisposed)
            //{
            //    khachHang = new frmKhachHang();
            //    khachHang.MdiParent = this;
            //    khachHang.Show();
            //}
            //else
            //    khachHang.Activate();
            if (khachHang == null || khachHang.IsDisposed)
                khachHang = new frmKhachHang();

            OpenForm(khachHang);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            //if (nhanVien == null || nhanVien.IsDisposed)
            //{
            //    nhanVien = new frmNhanVien();
            //    nhanVien.MdiParent = this;
            //    nhanVien.Show();
            //}
            //else
            //    nhanVien.Activate();
            if (nhanVien == null || nhanVien.IsDisposed)
                nhanVien = new frmNhanVien();

            OpenForm(nhanVien);
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            //if (hoaDon == null || hoaDon.IsDisposed)
            //{
            //    hoaDon = new frmHoaDon();
            //    hoaDon.MdiParent = this;
            //    hoaDon.Show();
            //}
            //else
            //    hoaDon.Activate();
            if (hoaDon == null || hoaDon.IsDisposed)
                hoaDon = new frmHoaDon();

            OpenForm(hoaDon);
        }

        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (phieuNhap == null || phieuNhap.IsDisposed)
            {
                phieuNhap = new frmPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
            else
                phieuNhap.Activate();
        }

        private void mnuNguyenLieu_Click(object sender, EventArgs e)
        {
            if (nguyenLieu == null || nguyenLieu.IsDisposed)
            {
                nguyenLieu = new frmNguyenLieu();
                nguyenLieu.MdiParent = this;
                nguyenLieu.Show();
            }
            else
                nguyenLieu.Activate();
        }

        private void mnuCongThuc_Click(object sender, EventArgs e)
        {
            if (congThuc == null || congThuc.IsDisposed)
            {
                congThuc = new frmCongThuc();
                congThuc.MdiParent = this;
                congThuc.Show();
            }
            else
                congThuc.Activate();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new frmNhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            Session.CurrentUser = null;
            ChuaDangNhap();
        }

        private void mnuThongKeSanPham_Click(object sender, EventArgs e)
        {
            if (thongKeSanPham == null || thongKeSanPham.IsDisposed)
            {
                thongKeSanPham = new frmThongKeSanPham();
                thongKeSanPham.MdiParent = this;
                thongKeSanPham.Show();
            }
            else
                thongKeSanPham.Activate();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new frmThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
                thongKeDoanhThu.Activate();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

