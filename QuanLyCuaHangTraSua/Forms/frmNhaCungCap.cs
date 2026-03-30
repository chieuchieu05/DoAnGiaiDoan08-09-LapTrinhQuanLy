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
    public partial class frmNhaCungCap : Form
    {
        //Khai báo biến toàn cục
        QLCHTSDbContext context = new QLCHTSDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenNCC.Enabled = giaTri;
            txtDiaChiNCC.Enabled = giaTri;
            txtSDTNCC.Enabled = giaTri;
            txtEmailNCC.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource = new BindingSource();
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser đang null");
                return;
            }

            BatTatChucNang(false);

            panelCRUD.Visible = !panelCRUD.Visible;
            panelNhapXuat.Visible = !panelNhapXuat.Visible;

            dgvNhaCungCap.AutoGenerateColumns = true;

            List<NHACUNGCAP> nv = new List<NHACUNGCAP>();
            nv = context.NhaCungCap.ToList();
            bindingSource.DataSource = nv;

            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", bindingSource, "TenNCC", false, DataSourceUpdateMode.Never);

            txtDiaChiNCC.DataBindings.Clear();
            txtDiaChiNCC.DataBindings.Add("Text", bindingSource, "DiaChiNCC", false, DataSourceUpdateMode.Never);

            txtSDTNCC.DataBindings.Clear();
            txtSDTNCC.DataBindings.Add("Text", bindingSource, "SDTNCC", false, DataSourceUpdateMode.Never);

            txtEmailNCC.DataBindings.Clear();
            txtEmailNCC.DataBindings.Add("Text", bindingSource, "EmailNCC", false, DataSourceUpdateMode.Never);

            dgvNhaCungCap.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            xuLyThem = true;

            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtSDTNCC.Clear();
            txtEmailNCC.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            if (dgvNhaCungCap.CurrentRow == null) return;

            id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhà cung cấp " + txtTenNCC.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                if (dgvNhaCungCap.CurrentRow == null) return;

                id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value);

                NHACUNGCAP ncc = context.NhaCungCap.Find(id);
                if (ncc != null)
                {
                    context.NhaCungCap.Remove(ncc);
                }
                context.SaveChanges();
                frmNhaCungCap_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                if (xuLyThem)
                {
                    NHACUNGCAP ncc = new NHACUNGCAP();
                    ncc.TenNCC = txtTenNCC.Text;
                    ncc.DiaChiNCC = txtDiaChiNCC.Text;
                    ncc.SDTNCC = txtSDTNCC.Text;
                    ncc.EmailNCC = txtEmailNCC.Text;
                    context.NhaCungCap.Add(ncc);
                    context.SaveChanges();
                }
                else
                {
                    NHACUNGCAP ncc = context.NhaCungCap.Find(id);
                    if (ncc != null)
                    {
                        ncc.TenNCC = txtTenNCC.Text;
                        ncc.DiaChiNCC = txtDiaChiNCC.Text;
                        ncc.SDTNCC = txtSDTNCC.Text;
                        ncc.EmailNCC = txtEmailNCC.Text;
                        context.NhaCungCap.Update(ncc);
                        context.SaveChanges();
                    }
                }
                frmNhaCungCap_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyBo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            string tuKhoa = txtTimKiem.Text.Trim();

            List<NHACUNGCAP> ketQua;

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu không nhập gì → hiện tất cả
                //ketQua = context.KhachHang.ToList();
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp cần tìm kiếm!", "Cảnh báo");
                return;
            }
            else
            {
                ketQua = context.NhaCungCap.Where(ncc => ncc.TenNCC.Contains(tuKhoa)).ToList();
            }

            //BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ketQua;

            //dgvNhanVien.DataSource = bindingSource;
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
                                NHACUNGCAP ncc = new NHACUNGCAP();
                                ncc.TenNCC = r["TenNCC"].ToString();
                                context.NhaCungCap.Add(ncc);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhaCungCap_Load(sender, e);
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
            saveFileDialog.Title = "Xuất dữ liệu Nhà Cung Cấp";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "NhaCungCap_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("Tên nhà cung cấp", typeof(string)),
                    new DataColumn("Địa chỉ", typeof(string)),
                    new DataColumn("SĐT", typeof(string)),
                    new DataColumn("Email", typeof(string)),
            });

                    var nhaCungCap = context.NhaCungCap.ToList();

                    foreach (var ncc in nhaCungCap)
                    {
                        table.Rows.Add(
                            ncc.ID,
                            ncc.TenNCC,
                            ncc.DiaChiNCC,
                            ncc.SDTNCC,
                            ncc.EmailNCC
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhaCungCap");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        void DongCacPanels()
        {
            panelCRUD.Visible = false;
            panelNhapXuat.Visible = false;
        }

        private void btnCRUD_Click(object sender, EventArgs e)
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
            if (!panelNhapXuat.Visible)
            {
                DongCacPanels();
                panelNhapXuat.Visible = true;
            }
            else
            {
                panelNhapXuat.Visible = false;
            }
        }
    }
}
