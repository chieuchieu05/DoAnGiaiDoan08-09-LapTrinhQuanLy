using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class NHANVIEN
    {
        public int ID { get; set; } 
        public string TenNV { get; set; } = null!;
        public string DiaChiNV { get; set; }
        public string SDTNV { get; set; }
        public string CCCD { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool VaiTro { get; set; }

        public virtual ObservableCollectionListSource<HOADON> HoaDon { get; } = new();

        public virtual ObservableCollectionListSource<PHIEUNHAP> PhieuNhap { get; } = new();
    }
}
