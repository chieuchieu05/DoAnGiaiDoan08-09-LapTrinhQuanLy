using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class CHITIETPHIEUNHAP
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int NguyenLieuID { get; set; } 

        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }

        public decimal ThanhTien { get; set; }

        public virtual PHIEUNHAP PhieuNhap { get; set; } = null!;
        public virtual NGUYENLIEU NguyenLieu { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachPhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int NguyenLieuID { get; set; }
        public string TenNguyenLieu { get; set; } // Thêm
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }

        public decimal ThanhTien { get; set; }
    }
}
