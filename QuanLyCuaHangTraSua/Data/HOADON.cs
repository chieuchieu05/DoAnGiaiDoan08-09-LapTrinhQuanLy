using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class HOADON
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }

        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public virtual ObservableCollectionListSource<CHITIETHOADON> ChiTietHoaDon { get; } = new();

        public virtual NHANVIEN NhanVien { get; set; }
        public virtual KHACHHANG KhachHang { get; set; }
    }

    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // Thêm
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; } // Thêm
        public string? XemChiTiet { get; set; } // Thêm

    }
}
