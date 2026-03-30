using ClosedXML.Excel;
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
    public partial class frmNguyenLieu : Form
    {
        //Khai báo biến toàn cục
        QLCHTSDbContext context = new QLCHTSDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenNL.Enabled = giaTri;
            cboDonViTinh.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtTrangThai.Enabled = giaTri;

            btnNhap.Enabled = giaTri;
            btnXuat.Enabled = giaTri;
            //btnThoat.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayDonViTinhVaoCombobox()
        {
            cboDonViTinh.DataSource = context.DonViTinh.ToList();
            cboDonViTinh.ValueMember = "ID";
            cboDonViTinh.DisplayMember = "TenDVT";
        }
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource = new BindingSource();
        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayDonViTinhVaoCombobox();
            panelCRUD.Visible = !panelCRUD.Visible;
            panelNhapXuat.Visible = !panelNhapXuat.Visible;
            panelTimKiem.Visible = !panelTimKiem.Visible;

            dgvNguyenLieu.AutoGenerateColumns = false;

            List<DanhSachNguyenLieu> nl = new List<DanhSachNguyenLieu>();
            nl = context.NguyenLieu.Select(r => new DanhSachNguyenLieu
            {
                ID = r.ID,
                TenNL = r.TenNL,
                DonViTinhID = r.DonViTinhID,
                TenDVT = r.DonViTinh.TenDVT,
                SoLuong = r.SoLuong,
                GiaNL = r.GiaNL,
                TrangThaiNL = r.TrangThaiNL
            }).ToList();

            bindingSource.DataSource = nl;

            txtTenNL.DataBindings.Clear();
            txtTenNL.DataBindings.Add("Text", bindingSource, "TenNL", false, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", bindingSource, "TrangThaiNL", false, DataSourceUpdateMode.Never);

            // Binding
            cboDonViTinh.DataBindings.Clear();
            cboDonViTinh.DataBindings.Add("SelectedValue", bindingSource, "DonViTinhID", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();

            Binding soLuongBinding = new Binding("Value", bindingSource, "SoLuong");

            soLuongBinding.Format += (s, e) =>
            {
                if (e.Value == null)
                    e.Value = 0;
            };

            soLuongBinding.Parse += (s, e) =>
            {
                e.Value = Convert.ToInt32(e.Value);
            };

            numSoLuong.DataBindings.Add(soLuongBinding);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "GiaNL", false, DataSourceUpdateMode.Never);


            dgvNguyenLieu.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            dgvNguyenLieu.ClearSelection();
            bindingSource.SuspendBinding();
            cboDonViTinh.Text = "";
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            txtTrangThai.Clear();
            txtTenNL.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            if (dgvNguyenLieu.CurrentRow == null) return;

            id = Convert.ToInt32(dgvNguyenLieu.CurrentRow.Cells["colID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nguyên liệu " + txtTenNL.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvNguyenLieu.CurrentRow == null) return;

                id = Convert.ToInt32(dgvNguyenLieu.CurrentRow.Cells["colID"].Value);

                NGUYENLIEU nl = context.NguyenLieu.Find(id);
                if (nl != null)
                {
                    context.NguyenLieu.Remove(nl);
                }
                context.SaveChanges();
                frmNguyenLieu_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNL.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboDonViTinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int DonViTinhID = Convert.ToInt32(cboDonViTinh.SelectedValue);

            if (xuLyThem)
            {
                NGUYENLIEU nl = new NGUYENLIEU();

                nl.TenNL = txtTenNL.Text;
                nl.TrangThaiNL = txtTrangThai.Text;
                nl.DonViTinhID = DonViTinhID;
                nl.GiaNL = numDonGia.Value;
                nl.SoLuong = numSoLuong.Value;
                nl.TrangThaiNL = txtTrangThai.Text;

                context.NguyenLieu.Add(nl);
                context.SaveChanges();
            }
            else
            {
                NGUYENLIEU nl = context.NguyenLieu.Find(id);

                if (nl != null)
                {
                    nl.TenNL = txtTenNL.Text;
                    nl.TrangThaiNL = txtTrangThai.Text;
                    nl.DonViTinhID = DonViTinhID;
                    nl.GiaNL = numDonGia.Value;
                    nl.SoLuong = numSoLuong.Value;
                    nl.TrangThaiNL = txtTrangThai.Text;

                    context.NguyenLieu.Update(nl);
                    context.SaveChanges();
                }
            }

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bindingSource.ResumeBinding();
            frmNguyenLieu_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNguyenLieu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                NGUYENLIEU nl = new NGUYENLIEU();
                                nl.TenNL = r["TenNL"].ToString();
                                context.NguyenLieu.Add(nl);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNguyenLieu_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NguyenLieu_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[6] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("TenNL", typeof(string)),
                    new DataColumn("DonViTinh", typeof(string)),
                    new DataColumn("SoLuong", typeof(int)),
                    new DataColumn("GiaNL", typeof(decimal)),
                    new DataColumn("TrangThai", typeof(string))
                    });
                    var nl = context.NguyenLieu.ToList();
                    if (nl != null)
                    {
                        foreach (var p in nl)
                            table.Rows.Add(p.ID, p.TenNL, p.DonViTinh.TenDVT, p.SoLuong, p.GiaNL, p.TrangThaiNL);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NguyenLieu");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        void DongCacPanels()
        {
            panelCRUD.Visible = false;
            panelNhapXuat.Visible = false;
            panelTimKiem.Visible = false;
        }
        private void btnTacVu_Click(object sender, EventArgs e)
        {
            if (!panelCRUD.Visible)
            {
                DongCacPanels();
                panelCRUD.Visible = true;
            }
            else
            {
                panelCRUD.Visible = false;
            }
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            if (!panelCRUD.Visible)
            {
                DongCacPanels();
                panelNhapXuat.Visible = true;
            }
            else
            {
                panelNhapXuat.Visible = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!panelCRUD.Visible)
            {
                DongCacPanels();
                panelTimKiem.Visible = true;
            }
            else
            {
                panelTimKiem.Visible = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            btnHuyBo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            string tuKhoa = txtTimKiem.Text.Trim();

            List<NGUYENLIEU> ketQua;

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu không nhập gì → hiện tất cả
                //ketQua = context.KhachHang.ToList();
                MessageBox.Show("Vui lòng nhập nguyên liệu cần tìm kiếm!", "Cảnh báo");
                return;
            }
            else
            {
                ketQua = context.NguyenLieu.Where(nl => nl.TenNL.Contains(tuKhoa)).ToList();
            }

            //BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ketQua;

            dgvNguyenLieu.DataSource = bindingSource;
        }
    }
}
