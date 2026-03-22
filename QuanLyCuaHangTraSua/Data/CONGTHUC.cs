using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class CONGTHUC
    {
        public int ID { get; set; }
        public int SanPhamID { get; set; }      
        public int NguyenLieuID { get; set; }   

        public decimal DinhLuong { get; set; }  // Số lượng NL dùng cho 1 SP
        public virtual SANPHAM SanPham { get; set; } = null!;
        public virtual NGUYENLIEU NguyenLieu { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachCongThuc
    {
        public int ID { get; set; }
        public int SanPhamID { get; set; }
        public string TenSP { get; set; } //Thêm 
        public int NguyenLieuID { get; set; }
        public string TenNL { get; set; } //Thêm 
        public decimal DinhLuong { get; set; }  // Số lượng NL dùng cho 1 SP
    }
}
