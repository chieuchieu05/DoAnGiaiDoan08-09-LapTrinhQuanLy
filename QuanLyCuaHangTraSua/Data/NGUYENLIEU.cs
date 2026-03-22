using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class NGUYENLIEU
    {
        public int ID { get; set; } 
        public string TenNL { get; set; } = null!;
        public int DonViTinhID { get; set; }
        public decimal SoLuong { get; set; }
        public decimal GiaNL { get; set; }
        public string TrangThaiNL { get; set; }


        public virtual DONVITINH DonViTinh { get; set; }
        public virtual ObservableCollectionListSource<CHITIETPHIEUNHAP> ChiTietPhieuNhap { get; } = new();
        public virtual ObservableCollectionListSource<CONGTHUC> CongThuc { get; } = new();
    }

    [NotMapped]

    public class DanhSachNguyenLieu
    {
        public int ID { get; set; }
        public string TenNL { get; set; } = null!;
        public int DonViTinhID { get; set; }
        public string TenDVT { get; set; } //Thêm 
        public decimal SoLuong { get; set; }
        public decimal GiaNL { get; set; }
        public string TrangThaiNL { get; set; }

    }

}
