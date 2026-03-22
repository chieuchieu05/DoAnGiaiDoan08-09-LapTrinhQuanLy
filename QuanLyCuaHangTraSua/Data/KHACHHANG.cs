using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class KHACHHANG
    {
        public int ID { get; set; } 
        public string TenKH { get; set; } = null!;
        public string DiaChiKH { get; set; }
        public string SDTKH { get; set; }
        public string EmailKH { get; set; }
        public string? SoTaiKhoanKH { get; set; }

        public virtual ObservableCollectionListSource<HOADON> HoaDon {get; } = new();
    }
}
