using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTraSua.Data
{
    public class DONVITINH
    {
        public int ID { get; set; }
        public string TenDVT { get; set; } = null!; //THUNG, KG, ML, CHAI, ...VV
        public virtual ObservableCollectionListSource<NGUYENLIEU> NguyenLieu { get; } = new();

    }
}
