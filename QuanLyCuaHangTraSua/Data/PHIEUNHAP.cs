using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class PHIEUNHAP
    {
        public int ID { get; set; }
        public DateTime NgayLap { get; set; }

        public int NhanVienID { get; set; }
        public int NhaCungCapID { get; set; }
        public decimal TongTien { get; set; }

        public virtual NHANVIEN NhanVien { get; set; }
        public virtual NHACUNGCAP NhaCungCap { get; set; }

        public virtual ObservableCollectionListSource<CHITIETPHIEUNHAP> ChiTietPhieuNhap { get; } = new();
    }

    [NotMapped]
    public class DanhSachPhieuNhap
    {
        public int ID { get; set; }
        public DateTime NgayLap { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // Thêm
        public int NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; } // Thêm
        public decimal TongTien { get; set; }
        public string? XemChiTiet { get; set; } // Thêm

    }
}
