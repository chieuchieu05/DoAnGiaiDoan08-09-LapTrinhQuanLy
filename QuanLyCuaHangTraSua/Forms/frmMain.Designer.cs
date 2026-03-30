namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            mnuHoaDon = new ToolStripMenuItem();
            mnuPhieuNhap = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            mnuNguyenLieu = new ToolStripMenuItem();
            mnuCongThuc = new ToolStripMenuItem();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            panelMain = new Panel();
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.LavenderBlush;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1902, 36);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.BackColor = Color.LavenderBlush;
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripMenuItem2, mnuThoat });
            mnuHeThong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuHeThong.ForeColor = Color.RosyBrown;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Padding = new Padding(40, 0, 40, 0);
            mnuHeThong.Size = new Size(184, 32);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.BackColor = Color.LavenderBlush;
            mnuDangNhap.ForeColor = Color.RosyBrown;
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Padding = new Padding(0, 10, 0, 10);
            mnuDangNhap.Size = new Size(241, 50);
            mnuDangNhap.Text = "Đăng nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.BackColor = Color.LavenderBlush;
            mnuDangXuat.ForeColor = Color.RosyBrown;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Padding = new Padding(0, 10, 0, 10);
            mnuDangXuat.Size = new Size(241, 50);
            mnuDangXuat.Text = "Đăng xuất...";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.BackColor = Color.LavenderBlush;
            mnuDoiMatKhau.ForeColor = Color.RosyBrown;
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Padding = new Padding(0, 10, 0, 10);
            mnuDoiMatKhau.Size = new Size(241, 50);
            mnuDoiMatKhau.Text = "Đổi mật khẩu...";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.LavenderBlush;
            toolStripMenuItem2.ForeColor = Color.RosyBrown;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(238, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.BackColor = Color.LavenderBlush;
            mnuThoat.ForeColor = Color.RosyBrown;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Padding = new Padding(0, 10, 0, 10);
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(241, 50);
            mnuThoat.Text = "Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.BackColor = Color.LavenderBlush;
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuSanPham, toolStripMenuItem1, mnuKhachHang, mnuNhanVien, toolStripMenuItem3, mnuHoaDon, mnuPhieuNhap, toolStripMenuItem4, mnuNguyenLieu, mnuCongThuc, mnuNhaCungCap });
            mnuQuanLy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuQuanLy.ForeColor = Color.RosyBrown;
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Padding = new Padding(40, 0, 40, 0);
            mnuQuanLy.Size = new Size(169, 32);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.BackColor = Color.LavenderBlush;
            mnuLoaiSanPham.ForeColor = Color.RosyBrown;
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Padding = new Padding(0, 10, 0, 10);
            mnuLoaiSanPham.Size = new Size(274, 50);
            mnuLoaiSanPham.Text = "Loại sản phẩm";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.BackColor = Color.LavenderBlush;
            mnuSanPham.ForeColor = Color.RosyBrown;
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Padding = new Padding(0, 10, 0, 10);
            mnuSanPham.Size = new Size(274, 50);
            mnuSanPham.Text = "Sản phẩm";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.LavenderBlush;
            toolStripMenuItem1.ForeColor = Color.RosyBrown;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(271, 6);
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.BackColor = Color.LavenderBlush;
            mnuKhachHang.ForeColor = Color.RosyBrown;
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Padding = new Padding(0, 10, 0, 10);
            mnuKhachHang.Size = new Size(274, 50);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.BackColor = Color.LavenderBlush;
            mnuNhanVien.ForeColor = Color.RosyBrown;
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Padding = new Padding(0, 10, 0, 10);
            mnuNhanVien.Size = new Size(274, 50);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.LavenderBlush;
            toolStripMenuItem3.ForeColor = Color.RosyBrown;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(271, 6);
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.BackColor = Color.LavenderBlush;
            mnuHoaDon.ForeColor = Color.RosyBrown;
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Padding = new Padding(0, 10, 0, 10);
            mnuHoaDon.Size = new Size(274, 50);
            mnuHoaDon.Text = "Hoá đơn bán hàng";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuPhieuNhap
            // 
            mnuPhieuNhap.BackColor = Color.LavenderBlush;
            mnuPhieuNhap.ForeColor = Color.RosyBrown;
            mnuPhieuNhap.Name = "mnuPhieuNhap";
            mnuPhieuNhap.Padding = new Padding(0, 10, 0, 10);
            mnuPhieuNhap.Size = new Size(274, 50);
            mnuPhieuNhap.Text = "Phiếu nhập";
            mnuPhieuNhap.Click += mnuPhieuNhap_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.LavenderBlush;
            toolStripMenuItem4.ForeColor = Color.RosyBrown;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(271, 6);
            // 
            // mnuNguyenLieu
            // 
            mnuNguyenLieu.BackColor = Color.LavenderBlush;
            mnuNguyenLieu.ForeColor = Color.RosyBrown;
            mnuNguyenLieu.Name = "mnuNguyenLieu";
            mnuNguyenLieu.Padding = new Padding(0, 10, 0, 10);
            mnuNguyenLieu.Size = new Size(274, 50);
            mnuNguyenLieu.Text = "Nguyên liệu";
            mnuNguyenLieu.Click += mnuNguyenLieu_Click;
            // 
            // mnuCongThuc
            // 
            mnuCongThuc.BackColor = Color.LavenderBlush;
            mnuCongThuc.ForeColor = Color.RosyBrown;
            mnuCongThuc.Name = "mnuCongThuc";
            mnuCongThuc.Padding = new Padding(0, 10, 0, 10);
            mnuCongThuc.Size = new Size(274, 50);
            mnuCongThuc.Text = "Công thức";
            mnuCongThuc.Click += mnuCongThuc_Click;
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.BackColor = Color.LavenderBlush;
            mnuNhaCungCap.ForeColor = Color.RosyBrown;
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Padding = new Padding(0, 10, 0, 10);
            mnuNhaCungCap.Size = new Size(274, 50);
            mnuNhaCungCap.Text = "Nhà cung cấp";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.BackColor = Color.LavenderBlush;
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuBaoCaoThongKe.ForeColor = Color.RosyBrown;
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Padding = new Padding(40, 0, 40, 0);
            mnuBaoCaoThongKe.Size = new Size(279, 32);
            mnuBaoCaoThongKe.Text = "Báo cáo - Thống kê";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.BackColor = Color.LavenderBlush;
            mnuThongKeSanPham.ForeColor = Color.RosyBrown;
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Padding = new Padding(0, 10, 0, 10);
            mnuThongKeSanPham.Size = new Size(289, 50);
            mnuThongKeSanPham.Text = "Thống kê sản phẩm";
            mnuThongKeSanPham.Click += mnuThongKeSanPham_Click;
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.BackColor = Color.LavenderBlush;
            mnuThongKeDoanhThu.ForeColor = Color.RosyBrown;
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Padding = new Padding(0, 10, 0, 10);
            mnuThongKeDoanhThu.Size = new Size(289, 50);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.BackColor = Color.LavenderBlush;
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnuTroGiup.ForeColor = Color.RosyBrown;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Padding = new Padding(40, 0, 40, 0);
            mnuTroGiup.Size = new Size(181, 32);
            mnuTroGiup.Text = "Trợ giúp ";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.BackColor = Color.LavenderBlush;
            mnuHuongDanSuDung.ForeColor = Color.RosyBrown;
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.Padding = new Padding(0, 10, 0, 10);
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(368, 50);
            mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.BackColor = Color.LavenderBlush;
            mnuThongTinPhanMem.ForeColor = Color.RosyBrown;
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(368, 32);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.LavenderBlush;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, toolStripStatusLabel2, lblLienKet });
            statusStrip1.Location = new Point(0, 1004);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1902, 29);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblTrangThai.ForeColor = SystemColors.ActiveCaptionText;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(133, 23);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 23);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1673, 23);
            toolStripStatusLabel2.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 23);
            lblLienKet.Text = "© 2026 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // panelMain
            // 
            panelMain.BackgroundImage = Properties.Resources.br;
            panelMain.BackgroundImageLayout = ImageLayout.Stretch;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 36);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1902, 968);
            panelMain.TabIndex = 3;
            panelMain.Paint += panelMain_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "frmMain";
            Text = "Trang chủ";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuPhieuNhap;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem mnuNguyenLieu;
        private ToolStripMenuItem mnuCongThuc;
        private ToolStripMenuItem mnuNhaCungCap;
        private Panel panelMain;
    }
}