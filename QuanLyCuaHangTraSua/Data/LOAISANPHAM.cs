using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class LOAISANPHAM
    {
        public int ID { get; set; }
        public string TenLoaiSP { get; set; }
        public virtual ObservableCollectionListSource<SANPHAM> SanPham { get; } = new();
    }
}
