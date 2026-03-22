using QuanLyCuaHangTraSua.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTraSua.Forms
{
    public partial class frmCongThuc : Form
    {

        QLCHTSDbContext context = new QLCHTSDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        bool xuLyThem = false;
        BindingList<DanhSachCongThuc> congThuc = new BindingList<DanhSachCongThuc>();

        public void LayNguyenLieuVaoComboBox()
        {
            cboNguyenLieu.DataSource = context.NguyenLieu.ToList();
            cboNguyenLieu.ValueMember = "ID";
            cboNguyenLieu.DisplayMember = "TenNL";
        }
        public void LaySanPhamVaoComboBox()
        {
            cboTenSanPham.DataSource = context.SanPham.ToList();
            cboTenSanPham.ValueMember = "ID";
            cboTenSanPham.DisplayMember = "TenSP";
        }

        public void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            cboNguyenLieu.Enabled = giaTri;
            cboTenSanPham.Enabled = giaTri;
            numDinhLuong.Enabled = giaTri;

            //btnNhap.Enabled = giaTri;
            //btnXuat.Enabled = giaTri;
            //btnThoat.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        public frmCongThuc()
        {
            InitializeComponent();
        }

        private void frmCongThuc_Load(object sender, EventArgs e)
        {
            LayNguyenLieuVaoComboBox();
            LaySanPhamVaoComboBox();
            panelTacVu.Visible = false;
            dgvCongThuc.AutoGenerateColumns = false;

            List<DanhSachCongThuc> ct = new List<DanhSachCongThuc>();
            ct = context.CongThuc.Select(r => new DanhSachCongThuc
            {
                ID = r.ID,
                SanPhamID = r.SanPhamID,
                TenSP = r.SanPham.TenSP,
                NguyenLieuID = r.NguyenLieuID,
                TenNL = r.NguyenLieu.TenNL,
                DinhLuong = r.DinhLuong,
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ct;

            numDinhLuong.DataBindings.Clear();
            numDinhLuong.DataBindings.Add("Value", bindingSource, "DinhLuong", false, DataSourceUpdateMode.Never);

            dgvCongThuc.DataSource = ct;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboNguyenLieu.Text = "";
            cboTenSanPham.Text = "";
            numDinhLuong.Value = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            if (dgvCongThuc.CurrentRow == null) return;

            id = Convert.ToInt32(dgvCongThuc.CurrentRow.Cells["colID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa công thức " + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvCongThuc.CurrentRow == null) return;

                id = Convert.ToInt32(dgvCongThuc.CurrentRow.Cells["colID"].Value);

                CONGTHUC ct = context.CongThuc.Find(id);
                if (ct != null)
                {
                    context.CongThuc.Remove(ct);
                }
                context.SaveChanges();
                frmCongThuc_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboTenSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboNguyenLieu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (xuLyThem)
            {
                CONGTHUC ct = new CONGTHUC();

                ct.SanPhamID = (int)cboTenSanPham.SelectedValue;
                ct.NguyenLieuID = (int)cboNguyenLieu.SelectedValue;
                ct.DinhLuong = numDinhLuong.Value;

                context.CongThuc.Add(ct);
                context.SaveChanges();
            }
            else
            {
                CONGTHUC ct = context.CongThuc.Find(id);

                if (ct != null)
                {
                    ct.SanPhamID = (int)cboTenSanPham.SelectedValue;
                    ct.NguyenLieuID = (int)cboNguyenLieu.SelectedValue;
                    ct.DinhLuong = numDinhLuong.Value;

                    context.CongThuc.Update(ct);
                    context.SaveChanges();
                }
            }

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmCongThuc_Load(sender, e);
        }

        private void btnTacVu_Click(object sender, EventArgs e)
        {
            panelTacVu.Visible = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmCongThuc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
