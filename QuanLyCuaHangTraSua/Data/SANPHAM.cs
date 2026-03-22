using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class SANPHAM
    {
        
        public int ID { get; set; } 
        public string TenSP { get; set; } = null!;
        //public string LoaiSP { get; set; } = null!;   // TRASUA | TOPPING
        public int LoaiSanPhamID { get; set; }
        public string? Size { get; set; }             // chỉ dùng cho trà sữa/trà trái cây
        public int SoLuong { get; set; }               //Số lượng sản phẩm
        public decimal Gia { get; set; }
        public string TrangThaiSP { get; set; }
        public string? HinhAnh { get; set; }

        public virtual ObservableCollectionListSource<CHITIETHOADON> ChiTietHoaDon { get; } = new();
        public virtual ObservableCollectionListSource<CONGTHUC> CongThuc { get; } = new();
        public virtual LOAISANPHAM LoaiSanPham { get; set; } = null!;

    }

    [NotMapped]
    public class DanhSachSanPham
    {
        public int ID { get; set; }
        public string TenSP { get; set; } = null!;
        public int LoaiSanPhamID { get; set; }
        public string TenLoaiSP { get; set; } //Thêm
        public string? Size { get; set; }            
        public int SoLuong { get; set; }               
        public decimal Gia { get; set; }
        public string TrangThaiSP { get; set; }
        public string? HinhAnh { get; set; }

    }
}
