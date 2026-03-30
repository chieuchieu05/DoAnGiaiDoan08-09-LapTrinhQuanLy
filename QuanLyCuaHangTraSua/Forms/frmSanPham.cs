using ClosedXML.Excel;
using Microsoft.IdentityModel.Logging;
using QuanLyCuaHangTraSua.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTraSua.Forms
{
    public partial class frmSanPham : Form
    {
        //Khai báo biến toàn cục
        QLCHTSDbContext context = new QLCHTSDbContext();
        bool xuLyThem = false;
        int id;
        //string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "image");
        string imagesFolder = Path.Combine(Application.StartupPath, "image");

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenSP.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            cboSize.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtTrangThai.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayLoaiSPVaoCombobox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoaiSP";
        }
        public frmSanPham()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource = new BindingSource();

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            picHinhAnh.Parent = panelAnh;

            cboLoaiSanPham.SelectedIndexChanged -= cboLoaiSanPham_SelectedIndexChanged;
            dgvSanPham.DataError += dgvSanPham_DataError;
            panelChinhSuaAnh.Visible = !panelChinhSuaAnh.Visible;
            panelCRUD.Visible = !panelCRUD.Visible;
            panelNhapXuat.Visible = !panelNhapXuat.Visible;
            BatTatChucNang(false);
            LayLoaiSPVaoCombobox();

            dgvSanPham.AutoGenerateColumns = false;

            LoadAnh();

            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                TenSP = r.TenSP,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoaiSP = r.LoaiSanPham.TenLoaiSP,
                Size = r.Size,
                SoLuong = r.SoLuong,
                Gia = r.Gia,
                TrangThaiSP = r.TrangThaiSP,
                HinhAnh = r.HinhAnh
            }).ToList();

            bindingSource.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", bindingSource, "TenSP", false, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", bindingSource, "TrangThaiSP", false, DataSourceUpdateMode.Never);

            // Load size
            cboSize.Items.Clear();
            cboSize.Items.AddRange(new string[] { "S", "M", "L" });

            // Binding
            cboSize.DataBindings.Clear();
            cboSize.DataBindings.Add("Text", bindingSource, "Size", false, DataSourceUpdateMode.Never);

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
            numDonGia.DataBindings.Add("Value", bindingSource, "Gia", false, DataSourceUpdateMode.Never);

            dgvSanPham.DataSource = bindingSource;
            cboLoaiSanPham.SelectedIndexChanged += cboLoaiSanPham_SelectedIndexChanged;
        }
        private void LoadAnh()
        {
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                TenSP = r.TenSP,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoaiSP = r.LoaiSanPham.TenLoaiSP,
                Size = r.Size,
                SoLuong = r.SoLuong,
                Gia = r.Gia,
                TrangThaiSP = r.TrangThaiSP,
                HinhAnh = r.HinhAnh
            }).ToList();

            bindingSource.DataSource = sp;         

            picHinhAnh.Image?.Dispose();
            picHinhAnh.Image = null;
            picHinhAnh.DataBindings.Clear();

            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value != null)
                {
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
                }
                else
                {
                    e.Value = null;  
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dgvSanPham.CellFormatting -= dataGridView_CellFormatting;  
            dgvSanPham.CellFormatting += dataGridView_CellFormatting;

            dgvSanPham.Refresh();
            picHinhAnh.Refresh();
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.Value = null;
                    return;
                }

                string path = Path.Combine(imagesFolder, e.Value.ToString());

                if (File.Exists(path))
                {
                    using (Image img = Image.FromFile(path))
                    {
                        e.Value = new Bitmap(img, 24, 24);
                    }
                }
                else
                {
                    e.Value = null;
                }
            }
        }

        private void dgvSanPham_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bindingSource.SuspendBinding();
            bindingSource.Position = -1; 

            dgvSanPham.ClearSelection();
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboSize.Text = "";
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            txtTrangThai.Clear();
            txtTenSP.Clear();
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            if (dgvSanPham.CurrentRow == null) return;

            id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSP.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvSanPham.CurrentRow == null) return;

                id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);

                SANPHAM sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboLoaiSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int loaiID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);

            if (xuLyThem)
            {
                SANPHAM sp = new SANPHAM();

                sp.TenSP = txtTenSP.Text;
                sp.TrangThaiSP = txtTrangThai.Text;
                sp.LoaiSanPhamID = loaiID;
                sp.Gia = numDonGia.Value;
                sp.SoLuong = (int)numSoLuong.Value;
                sp.TrangThaiSP = txtTrangThai.Text;

                // Nếu là TRASUA hoặc TRATRAICAY
                if (loaiID == 1 || loaiID == 2)
                {
                    sp.Size = cboSize.Text;
                  
                }
                else // TOPPING hoặc BANH
                {
                    sp.Size = null;

                }

                if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                {
                    sp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                }

                context.SanPham.Add(sp);
                context.SaveChanges();
            }
            else
            {
                SANPHAM sp = context.SanPham.Find(id);

                if (sp != null)
                {
                    sp.TenSP = txtTenSP.Text;
                    sp.TrangThaiSP = txtTrangThai.Text;
                    sp.LoaiSanPhamID = loaiID;
                    sp.Gia = numDonGia.Value;
                    sp.SoLuong = (int)numSoLuong.Value;
                    sp.TrangThaiSP = txtTrangThai.Text;

                    if (loaiID == 1 || loaiID == 2)
                    {
                        sp.Size = cboSize.Text;
                    }
                    else
                    {
                        sp.Size = null;
                    }

                    if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                    {
                        sp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                    }

                    context.SanPham.Update(sp);
                    context.SaveChanges();
                }
            }

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bindingSource.ResumeBinding();
            frmSanPham_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loaiID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
            if (loaiID == 1 || loaiID == 2)
            {
                cboSize.Enabled = true;
            }
            else
            {
                cboSize.Enabled = false;
                cboSize.Text = "";
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            // Chọn hình ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đuôi file
                string ext = Path.GetExtension(openFileDialog.FileName);

                // Tạo tên file mới bằng GUID (không trùng)
                string newFileName = Guid.NewGuid().ToString() + ext;

                // Đường dẫn lưu
                string fileSavePath = Path.Combine(imagesFolder, newFileName);

                // Copy file vào thư mục Images
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                // Lấy username (khóa chính)
                int id = (int)dgvSanPham.CurrentRow.Cells["colID"].Value;

                SANPHAM sp = context.SanPham.Find(id);

                if (sp != null)
                {
                    sp.HinhAnh = newFileName;
                    context.SaveChanges();
                }

                // Load lại dữ liệu
                frmSanPham_Load(sender, e);
            }
        }

        void DongCacPanels()
        {
            panelChinhSuaAnh.Visible = false;
            panelCRUD.Visible = false;
            panelNhapXuat.Visible = false;
        }
        private void btnTacVu_Click(object sender, EventArgs e)
        {
            if (!panelChinhSuaAnh.Visible)
            {
                DongCacPanels();
                panelChinhSuaAnh.Visible = true;
            }
            else
            {
                panelChinhSuaAnh.Visible = false;
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
                                SANPHAM sp = new SANPHAM();
                                sp.TenSP = r["TenSP"].ToString();
                                context.SanPham.Add(sp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmSanPham_Load(sender, e);
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
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[7] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("TenLoaiSP", typeof(string)),
                    new DataColumn("TenSP", typeof(string)),
                    new DataColumn("Size", typeof(string)),
                    new DataColumn("SoLuong", typeof(int)),
                    new DataColumn("Gia", typeof(decimal)),
                    new DataColumn("TrangThai", typeof(string))
                    });
                    var sp = context.SanPham.ToList();
                    if (sp != null)
                    {
                        foreach (var p in sp)
                            table.Rows.Add(p.ID, p.TenSP, p.Size, p.SoLuong, p.Gia, p.TrangThaiSP);

                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "SanPham");
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

        private void btnXoayAnh_Click(object sender, EventArgs e)
        {
            // Kiểm tra 
            if (bindingSource.Current == null)
            {
                return;
            }

            if (dgvSanPham.CurrentRow == null)
                return;

            var item = dgvSanPham.CurrentRow.DataBoundItem as DanhSachSanPham;
            if (item == null || string.IsNullOrEmpty(item.HinhAnh))
                return;

            string path = Path.Combine(imagesFolder, item.HinhAnh);
            if (!File.Exists(path))
                return;

            // TẠO FILE MỚI + XOAY ẢNH (KHÔNG XÓA FILE CŨ)
            string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(item.HinhAnh);
            string newPath = Path.Combine(imagesFolder, newFileName);

            try
            {
                using (Image img = Image.FromFile(path))
                {
                    Image imgXoay = new Bitmap(img.Width, img.Height);
                    using (Graphics g = Graphics.FromImage(imgXoay))
                    {
                        g.Clear(Color.Transparent);
                        g.DrawImage(img, 0, 0);
                    }
                    imgXoay.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    imgXoay.Save(newPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgXoay.Dispose();
                }

                // Cập nhật database
                int idSP = item.ID;
                SANPHAM sp = context.SanPham.Find(idSP);
                if (sp != null)
                {
                    sp.HinhAnh = newFileName;
                    context.SaveChanges();
                }

                MessageBox.Show("Xoay ảnh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAnh();
            }
            catch (Exception ex)
            {
                if (File.Exists(newPath)) File.Delete(newPath);
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xoay ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is DanhSachSanPham item && !string.IsNullOrEmpty(item.HinhAnh))
            {
                if (MessageBox.Show($"Xóa ảnh '{item.HinhAnh}'?", "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.SanPham.Find(item.ID).HinhAnh = null;
                    context.SaveChanges();
                    LoadAnh(); 
                    MessageBox.Show("Thành công!", "Thông báo");
                }
            }
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyBo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            string tuKhoa = txtTimKiem.Text.Trim();

            List<DanhSachSanPham> ketQua;

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập sản phẩm cần tìm kiếm!", "Cảnh báo");
                return;
            }
            else
            {
                ketQua = context.SanPham.Where(sp => sp.TenSP.Contains(tuKhoa)).Select(r => new DanhSachSanPham
                {
                    ID = r.ID,
                    TenSP = r.TenSP,
                    LoaiSanPhamID = r.LoaiSanPhamID,
                    TenLoaiSP = r.LoaiSanPham.TenLoaiSP,
                    Size = r.Size,
                    SoLuong = r.SoLuong,
                    Gia = r.Gia,
                    TrangThaiSP = r.TrangThaiSP,
                    HinhAnh = r.HinhAnh
                }).ToList();
            }    
                
            //List<DanhSachSanPham> ketQua;

            
            //else
            //{
            //    ketQua = context.DanhSachSanPham.Where(sp => sp.TenSP.Contains(tuKhoa)).ToList();
            //}

            bindingSource.DataSource = ketQua;
            dgvSanPham.DataSource = bindingSource;
        }
    }
}
