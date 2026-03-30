using BCrypt.Net;
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
    public partial class frmNhanVien : Form
    {
        //Khai báo biến toàn cục
        QLCHTSDbContext context = new QLCHTSDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtHoTenNV.Enabled = giaTri;
            txtDiaChiNV.Enabled = giaTri;
            txtSDTNV.Enabled = giaTri;
            txtCCCDNV.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboVaiTro.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource = new BindingSource();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser đang null");
                return;
            }


            BatTatChucNang(false);
            panelCRUD.Visible = false;
            panelNhapXuat.Visible = false;
            picStaff.Visible = true;
            dgvNhanVien.AutoGenerateColumns = true;

            List<NHANVIEN> nv = new List<NHANVIEN>();
            nv = context.NhanVien.ToList();

            //BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", bindingSource, "TenNV", false, DataSourceUpdateMode.Never);

            // Tương tự đối với txtDienThoai, txtDiaChi, txtTenDangNhap

            txtDiaChiNV.DataBindings.Clear();
            txtDiaChiNV.DataBindings.Add("Text", bindingSource, "DiaChiNV", false, DataSourceUpdateMode.Never);

            txtSDTNV.DataBindings.Clear();
            txtSDTNV.DataBindings.Add("Text", bindingSource, "SDTNV", false, DataSourceUpdateMode.Never);

            txtCCCDNV.DataBindings.Clear();
            txtCCCDNV.DataBindings.Add("Text", bindingSource, "CCCD", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("User");   // index 0 → false
            cboVaiTro.Items.Add("Admin");  // index 1 → true

            cboVaiTro.DataBindings.Clear();
            cboVaiTro.DataBindings.Add("SelectedIndex", bindingSource, "VaiTro", false, DataSourceUpdateMode.Never);


            if (Session.CurrentUser.VaiTro)
            {
                bindingSource.DataSource = context.NhanVien.ToList();
            }
            else
            {
                bindingSource.DataSource = context.NhanVien.Where(nv => nv.ID == Session.CurrentUser.ID).ToList();
            }

            dgvNhanVien.DataSource = bindingSource;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            xuLyThem = true;

            txtHoTenNV.Clear();
            txtSDTNV.Clear();
            txtDiaChiNV.Clear();
            txtCCCDNV.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboVaiTro.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            //id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
            if (dgvNhanVien.CurrentRow == null) return;

            id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoTenNV.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                if (dgvNhanVien.CurrentRow == null) return;

                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value);

                NHANVIEN nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTenNV.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboVaiTro.Text))
                MessageBox.Show("Vui lòng chọn vai trò cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                    {

                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        NHANVIEN nv = new NHANVIEN();
                        nv.TenNV = txtHoTenNV.Text;
                        nv.DiaChiNV = txtDiaChiNV.Text;
                        nv.SDTNV = txtSDTNV.Text;
                        nv.CCCD = txtCCCDNV.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu
                        //nv.VaiTro = cboVaiTro.SelectedIndex == 0 ? true : false;
                        nv.VaiTro = cboVaiTro.SelectedIndex == 1;
                        context.NhanVien.Add(nv);
                        //context.SaveChanges();
                    }
                }
                else
                {
                    NHANVIEN nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.TenNV = txtHoTenNV.Text;
                        nv.DiaChiNV = txtDiaChiNV.Text;
                        nv.SDTNV = txtSDTNV.Text;
                        nv.CCCD = txtCCCDNV.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.VaiTro = cboVaiTro.SelectedIndex == 1;

                        //context.NhanVien.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ
                        else
                            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu
                        //context.SaveChanges();
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công", "Thông báo");
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
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

            List<NHANVIEN> ketQua;

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu không nhập gì → hiện tất cả
                //ketQua = context.KhachHang.ToList();
                MessageBox.Show("Vui lòng nhập họ tên nhân viên cần tìm kiếm!", "Cảnh báo");
                return;
            }
            else
            {
                ketQua = context.NhanVien.Where(nv => nv.TenNV.Contains(tuKhoa)).ToList();
            }

            //BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ketQua;

            //dgvNhanVien.DataSource = bindingSource;

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Nhân Viên";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[7] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Tên nhân viên", typeof(string)),
                new DataColumn("Địa chỉ", typeof(string)),
                new DataColumn("SĐT", typeof(string)),
                new DataColumn("CCCD", typeof(string)),
                new DataColumn("Tên đăng nhập", typeof(string)),
                new DataColumn("Mật khẩu", typeof(string)),
            });

                    var nhanVien = context.NhanVien.ToList();

                    foreach (var nv in nhanVien)
                    {
                        table.Rows.Add(
                            nv.ID,
                            nv.TenNV,
                            nv.DiaChiNV,
                            nv.SDTNV,
                            nv.CCCD,
                            nv.TenDangNhap,
                            nv.MatKhau
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
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
                            // Đọc dòng tiêu đề
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);

                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());

                                firstRow = false;
                            }
                            else // Đọc dữ liệu
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
                                NHANVIEN nv = new NHANVIEN();
                                nv.TenNV = r["Tên nhân viên"].ToString();
                                nv.SDTNV = r["SĐT"].ToString();
                                nv.DiaChiNV = r["Địa chỉ"].ToString();
                                nv.CCCD = r["CCCD"].ToString();
                                nv.TenDangNhap = r["Tên đăng nhập"].ToString();
                                nv.MatKhau = r["Mật khẩu"].ToString();


                                context.NhanVien.Add(nv);
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmNhanVien_Load(sender, e);
                        }

                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        void DongCacPanels()
        {
            panelCRUD.Visible = false;
            panelNhapXuat.Visible = false;
            picStaff.Visible = true; 
        }
        private void btnCRUD_Click(object sender, EventArgs e)
        {
            if (!panelCRUD.Visible)
            {
                DongCacPanels();
                panelCRUD.Visible = true;
                picStaff.Visible = false;
            }
            else
            {
                panelCRUD.Visible = false;
                picStaff.Visible = true;
            }
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            if (!panelNhapXuat.Visible)
            {
                DongCacPanels();
                panelNhapXuat.Visible = true;
                picStaff.Visible = false;
            }
            else
            {
                panelNhapXuat.Visible = false;
                picStaff.Visible = true;
            }
        }
    }
}
