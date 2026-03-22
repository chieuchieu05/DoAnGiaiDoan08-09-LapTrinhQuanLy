using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class QLCHTSDbContext: DbContext
    {
        public DbSet<SANPHAM> SanPham { get; set; }
        public DbSet<LOAISANPHAM> LoaiSanPham { get; set; }
        public DbSet<HOADON> HoaDon { get; set; }
        public DbSet<CHITIETHOADON> ChiTietHoaDon { get; set; }
        public DbSet<KHACHHANG> KhachHang { get; set; }
        public DbSet<NHANVIEN> NhanVien { get; set; }
        public DbSet<PHIEUNHAP> PhieuNhap { get; set; }
        public DbSet<CHITIETPHIEUNHAP> ChiTietPhieuNhap { get; set; }
        public DbSet<NGUYENLIEU> NguyenLieu { get; set; }
        public DbSet<DONVITINH> DonViTinh { get; set; }

        public DbSet<NHACUNGCAP> NhaCungCap { get; set; }
        public DbSet<CONGTHUC> CongThuc { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLCHTSConnection"].ConnectionString);
        }
    }
}
