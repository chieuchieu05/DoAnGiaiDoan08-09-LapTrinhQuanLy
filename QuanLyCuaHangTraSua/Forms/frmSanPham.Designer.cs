namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            groupBox1 = new GroupBox();
            dgvSanPham = new DataGridView();
            txtTenSP = new TextBox();
            txtTrangThai = new TextBox();
            gbThongTinKhachHang = new GroupBox();
            panelAnh = new Panel();
            picHinhAnh = new PictureBox();
            btnCRUD = new Button();
            btnNhapXuat = new Button();
            panelNhapXuat = new Panel();
            panelCRUD = new Panel();
            panelChinhSuaAnh = new Panel();
            btnXoaAnh = new Button();
            btnXoayAnh = new Button();
            btnDoiAnh = new Button();
            btnTacVu = new Button();
            cboSize = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            numDonGia = new NumericUpDown();
            label4 = new Label();
            numSoLuong = new NumericUpDown();
            cboLoaiSanPham = new ComboBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            colID = new DataGridViewTextBoxColumn();
            TenLoaiSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            TrangThaiSP = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            gbThongTinKhachHang.SuspendLayout();
            panelAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            panelNhapXuat.SuspendLayout();
            panelCRUD.SuspendLayout();
            panelChinhSuaAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(437, 644);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 30);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(3, 151);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(96, 30);
            btnHuyBo.TabIndex = 47;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(3, 115);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 30);
            btnLuu.TabIndex = 43;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(3, 82);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 30);
            btnXoa.TabIndex = 42;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(3, 46);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(96, 30);
            btnSua.TabIndex = 41;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 10);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(96, 30);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 30;
            label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 31;
            label2.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 245);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 32;
            label3.Text = "Trạng thái:";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(3, 49);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(91, 30);
            btnXuat.TabIndex = 49;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(3, 13);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(91, 30);
            btnNhap.TabIndex = 48;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSanPham);
            groupBox1.Location = new Point(12, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 273);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { colID, TenLoaiSP, TenSP, Size, SoLuong, Gia, TrangThaiSP, HinhAnh });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(3, 23);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(952, 247);
            dgvSanPham.TabIndex = 0;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(123, 32);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(177, 27);
            txtTenSP.TabIndex = 35;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(123, 245);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(177, 27);
            txtTrangThai.TabIndex = 36;
            // 
            // gbThongTinKhachHang
            // 
            gbThongTinKhachHang.Controls.Add(panelAnh);
            gbThongTinKhachHang.Controls.Add(btnCRUD);
            gbThongTinKhachHang.Controls.Add(btnNhapXuat);
            gbThongTinKhachHang.Controls.Add(panelNhapXuat);
            gbThongTinKhachHang.Controls.Add(panelCRUD);
            gbThongTinKhachHang.Controls.Add(panelChinhSuaAnh);
            gbThongTinKhachHang.Controls.Add(btnTacVu);
            gbThongTinKhachHang.Controls.Add(cboSize);
            gbThongTinKhachHang.Controls.Add(label6);
            gbThongTinKhachHang.Controls.Add(label5);
            gbThongTinKhachHang.Controls.Add(numDonGia);
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(numSoLuong);
            gbThongTinKhachHang.Controls.Add(cboLoaiSanPham);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label2);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(txtTenSP);
            gbThongTinKhachHang.Controls.Add(txtTrangThai);
            gbThongTinKhachHang.Location = new Point(13, 17);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(958, 287);
            gbThongTinKhachHang.TabIndex = 5;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin sản phẩm";
            // 
            // panelAnh
            // 
            panelAnh.Controls.Add(picHinhAnh);
            panelAnh.Location = new Point(368, 45);
            panelAnh.Name = "panelAnh";
            panelAnh.Size = new Size(163, 202);
            panelAnh.TabIndex = 70;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(3, 8);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(156, 184);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 62;
            picHinhAnh.TabStop = false;
            // 
            // btnCRUD
            // 
            btnCRUD.Location = new Point(686, 35);
            btnCRUD.Name = "btnCRUD";
            btnCRUD.Size = new Size(101, 30);
            btnCRUD.TabIndex = 69;
            btnCRUD.Text = "CRUD";
            btnCRUD.UseVisualStyleBackColor = true;
            btnCRUD.Click += btnCRUD_Click;
            // 
            // btnNhapXuat
            // 
            btnNhapXuat.Location = new Point(824, 35);
            btnNhapXuat.Name = "btnNhapXuat";
            btnNhapXuat.Size = new Size(101, 30);
            btnNhapXuat.TabIndex = 68;
            btnNhapXuat.Text = "Nhập - Xuất";
            btnNhapXuat.UseVisualStyleBackColor = true;
            btnNhapXuat.Click += btnNhapXuat_Click;
            // 
            // panelNhapXuat
            // 
            panelNhapXuat.Controls.Add(btnNhap);
            panelNhapXuat.Controls.Add(btnXuat);
            panelNhapXuat.Location = new Point(826, 80);
            panelNhapXuat.Name = "panelNhapXuat";
            panelNhapXuat.Size = new Size(99, 96);
            panelNhapXuat.TabIndex = 67;
            // 
            // panelCRUD
            // 
            panelCRUD.Controls.Add(btnThem);
            panelCRUD.Controls.Add(btnSua);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnLuu);
            panelCRUD.Controls.Add(btnHuyBo);
            panelCRUD.Location = new Point(686, 82);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(99, 187);
            panelCRUD.TabIndex = 66;
            // 
            // panelChinhSuaAnh
            // 
            panelChinhSuaAnh.Controls.Add(btnXoaAnh);
            panelChinhSuaAnh.Controls.Add(btnXoayAnh);
            panelChinhSuaAnh.Controls.Add(btnDoiAnh);
            panelChinhSuaAnh.Location = new Point(551, 82);
            panelChinhSuaAnh.Name = "panelChinhSuaAnh";
            panelChinhSuaAnh.Size = new Size(101, 138);
            panelChinhSuaAnh.TabIndex = 65;
            // 
            // btnXoaAnh
            // 
            btnXoaAnh.Location = new Point(12, 95);
            btnXoaAnh.Name = "btnXoaAnh";
            btnXoaAnh.Size = new Size(81, 30);
            btnXoaAnh.TabIndex = 65;
            btnXoaAnh.Text = "Xoá ảnh";
            btnXoaAnh.UseVisualStyleBackColor = true;
            btnXoaAnh.Click += btnXoaAnh_Click;
            // 
            // btnXoayAnh
            // 
            btnXoayAnh.Location = new Point(12, 51);
            btnXoayAnh.Name = "btnXoayAnh";
            btnXoayAnh.Size = new Size(81, 30);
            btnXoayAnh.TabIndex = 64;
            btnXoayAnh.Text = "Xoay ảnh";
            btnXoayAnh.UseVisualStyleBackColor = true;
            btnXoayAnh.Click += btnXoayAnh_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(12, 10);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(81, 30);
            btnDoiAnh.TabIndex = 63;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnTacVu
            // 
            btnTacVu.Location = new Point(551, 35);
            btnTacVu.Name = "btnTacVu";
            btnTacVu.Size = new Size(101, 30);
            btnTacVu.TabIndex = 64;
            btnTacVu.Text = "Tác vụ ảnh";
            btnTacVu.UseVisualStyleBackColor = true;
            btnTacVu.Click += btnTacVu_Click;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(123, 114);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(177, 28);
            cboSize.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 114);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 60;
            label6.Text = "Size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 203);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 59;
            label5.Text = "Đơn giá:";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(123, 203);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(177, 27);
            numDonGia.TabIndex = 58;
            numDonGia.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 159);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 57;
            label4.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(123, 159);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(177, 27);
            numSoLuong.TabIndex = 56;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(123, 71);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(177, 28);
            cboLoaiSanPham.TabIndex = 55;
            cboLoaiSanPham.SelectedIndexChanged += cboLoaiSanPham_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(14, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(955, 59);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 28);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 48;
            label7.Text = "Nhập nguyên liệu:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(804, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 30);
            btnTimKiem.TabIndex = 48;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(143, 21);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(655, 27);
            txtTimKiem.TabIndex = 48;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // TenLoaiSP
            // 
            TenLoaiSP.DataPropertyName = "TenLoaiSP";
            TenLoaiSP.HeaderText = "Phân loại";
            TenLoaiSP.MinimumWidth = 6;
            TenLoaiSP.Name = "TenLoaiSP";
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            // 
            // Size
            // 
            Size.DataPropertyName = "Size";
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            Gia.DataPropertyName = "Gia";
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            // 
            // TrangThaiSP
            // 
            TrangThaiSP.DataPropertyName = "TrangThaiSP";
            TrangThaiSP.HeaderText = "Trạng thái";
            TrangThaiSP.MinimumWidth = 6;
            TrangThaiSP.Name = "TrangThaiSP";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbThongTinKhachHang);
            Controls.Add(btnThoat);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            panelAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            panelNhapXuat.ResumeLayout(false);
            panelCRUD.ResumeLayout(false);
            panelChinhSuaAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnXuat;
        private Button btnNhap;
        private GroupBox groupBox1;
        private TextBox txtTenSP;
        private TextBox txtTrangThai;
        private GroupBox gbThongTinKhachHang;
        private Label label4;
        private NumericUpDown numSoLuong;
        private ComboBox cboLoaiSanPham;
        private PictureBox picHinhAnh;
        private ComboBox cboSize;
        private Label label6;
        private Label label5;
        private NumericUpDown numDonGia;
        private Button btnDoiAnh;
        private DataGridView dgvSanPham;
        private Panel panelChinhSuaAnh;
        private Button btnTacVu;
        private Button btnXoaAnh;
        private Button btnXoayAnh;
        private Panel panelCRUD;
        private Panel panelNhapXuat;
        private Button btnCRUD;
        private Button btnNhapXuat;
        private GroupBox groupBox2;
        private Label label7;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Panel panelAnh;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenLoaiSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn TrangThaiSP;
        private DataGridViewImageColumn HinhAnh;
    }
}