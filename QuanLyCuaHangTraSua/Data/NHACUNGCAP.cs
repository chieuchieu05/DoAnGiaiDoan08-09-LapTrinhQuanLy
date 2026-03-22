using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class NHACUNGCAP
    {
        public int ID { get; set; } 
        public string TenNCC { get; set; } = null!;
        public string DiaChiNCC { get; set; }
        public string SDTNCC { get; set; }
        public string EmailNCC { get; set; }

        public virtual ObservableCollectionListSource<PHIEUNHAP> PhieuNhap { get; } = new();
    }
}
