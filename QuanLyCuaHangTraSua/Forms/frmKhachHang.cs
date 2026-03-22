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
using ClosedXML.Excel;

namespace QuanLyCuaHangTraSua.Forms
{
    public partial class frmKhachHang : Form
    {
        //Khai báo biến toàn cục
        QLCHTSDbContext context = new QLCHTSDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtHoTenKH.Enabled = giaTri;
            txtSDTKH.Enabled = giaTri;
            txtDiaChiKH.Enabled = giaTri;
            txtSoTaiKhoanKH.Enabled = giaTri;
            txtEmailKH.Enabled = giaTri;
            

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource = new BindingSource();
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KHACHHANG> kh = new List<KHACHHANG>();
            kh = context.KhachHang.ToList();

            //BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoTenKH.DataBindings.Clear();
            txtHoTenKH.DataBindings.Add("Text", bindingSource, "TenKH", false, DataSourceUpdateMode.Never);

            txtDiaChiKH.DataBindings.Clear();
            txtDiaChiKH.DataBindings.Add("Text", bindingSource, "DiaChiKH", false, DataSourceUpdateMode.Never);

            txtSDTKH.DataBindings.Clear();
            txtSDTKH.DataBindings.Add("Text", bindingSource, "SDTKH", false, DataSourceUpdateMode.Never);

            txtEmailKH.DataBindings.Clear();
            txtEmailKH.DataBindings.Add("Text", bindingSource, "EmailKH", false, DataSourceUpdateMode.Never);

            txtSoTaiKhoanKH.DataBindings.Clear();
            txtSoTaiKhoanKH.DataBindings.Add("Text", bindingSource, "SoTaiKhoanKH", false, DataSourceUpdateMode.Never);

            txtTimKiem.Clear();
            txtHoTenKH.Clear();
            txtDiaChiKH.Clear();
            txtSDTKH.Clear();
            txtEmailKH.Clear();
            txtSoTaiKhoanKH.Clear();

            dgvKhachHang.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoTenKH.Clear();
            txtDiaChiKH.Clear();
            txtEmailKH.Clear();
            txtSDTKH.Clear();
            txtSoTaiKhoanKH.Clear();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xoá khách hàng " + txtHoTenKH.Text + "?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                KHACHHANG kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();

                frmKhachHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (xuLyThem)
                {
                    KHACHHANG kh = new KHACHHANG();
                    kh.TenKH = txtHoTenKH.Text;
                    kh.SDTKH = txtSDTKH.Text;
                    kh.DiaChiKH = txtDiaChiKH.Text;
                    kh.EmailKH = txtEmailKH.Text;
                    kh.SoTaiKhoanKH = txtSoTaiKhoanKH.Text;

                    context.KhachHang.Add(kh);
                    //context.SaveChanges();
                }
                else
                {
                    KHACHHANG kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.TenKH = txtHoTenKH.Text;
                        kh.SDTKH = txtSDTKH.Text;
                        kh.DiaChiKH = txtDiaChiKH.Text;
                        kh.EmailKH = txtEmailKH.Text;
                        kh.SoTaiKhoanKH = txtSoTaiKhoanKH.Text;
                        //context.KhachHang.Update(kh);
                        //context.SaveChanges();
                    }
                }

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }
        }

        /**private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }**/


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyBo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            string tuKhoa = txtTimKiem.Text.Trim();

            List<KHACHHANG> ketQua;

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu không nhập gì → hiện tất cả
                //ketQua = context.KhachHang.ToList();
                MessageBox.Show("Vui lòng nhập họ tên khách hàng cần tìm kiếm!", "Cảnh báo");
                return;
            }
            else
            {
                ketQua = context.KhachHang.Where(kh => kh.TenKH.Contains(tuKhoa)).ToList();
            }

            //BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ketQua;

            dgvKhachHang.DataSource = bindingSource;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Khách Hàng";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[6] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Tên khách hàng", typeof(string)),
                new DataColumn("SĐT", typeof(string)),
                new DataColumn("Địa chỉ", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("Số tài khoản", typeof(string)),
            });

                    var khachHang = context.KhachHang.ToList();

                    foreach (var kh in khachHang)
                    {
                        table.Rows.Add(
                            kh.ID,
                            kh.TenKH,
                            kh.SDTKH,
                            kh.DiaChiKH,
                            kh.EmailKH,
                            kh.SoTaiKhoanKH
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhachHang");
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
                                KHACHHANG kh = new KHACHHANG();
                                kh.TenKH = r["TenKH"].ToString();
                                kh.SDTKH = r["SDTKH"].ToString();
                                kh.DiaChiKH = r["DiaChiKH"].ToString();
                                kh.EmailKH = r["EmailKH"].ToString();
                                kh.SoTaiKhoanKH = r["SoTaiKhoanKH"].ToString();

                                context.KhachHang.Add(kh);
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmKhachHang_Load(sender, e);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
