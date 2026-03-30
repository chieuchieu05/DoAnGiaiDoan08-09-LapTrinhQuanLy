namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmNguyenLieu
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
            txtTenNL = new TextBox();
            txtTrangThai = new TextBox();
            gbThongTinKhachHang = new GroupBox();
            panelTimKiem = new Panel();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            btnNhapXuat = new Button();
            panelNhapXuat = new Panel();
            btnNhap = new Button();
            btnXuat = new Button();
            panelCRUD = new Panel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnTacVu = new Button();
            cboDonViTinh = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            numDonGia = new NumericUpDown();
            label4 = new Label();
            btnTimKiem = new Button();
            numSoLuong = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            dgvNguyenLieu = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenNL = new DataGridViewTextBoxColumn();
            TenDVT = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaNL = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            gbThongTinKhachHang.SuspendLayout();
            panelTimKiem.SuspendLayout();
            panelNhapXuat.SuspendLayout();
            panelCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).BeginInit();
            SuspendLayout();
            // 
            // txtTenNL
            // 
            txtTenNL.Location = new Point(123, 32);
            txtTenNL.Name = "txtTenNL";
            txtTenNL.Size = new Size(177, 27);
            txtTenNL.TabIndex = 35;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(415, 83);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(520, 27);
            txtTrangThai.TabIndex = 36;
            // 
            // gbThongTinKhachHang
            // 
            gbThongTinKhachHang.Controls.Add(panelTimKiem);
            gbThongTinKhachHang.Controls.Add(btnNhapXuat);
            gbThongTinKhachHang.Controls.Add(panelNhapXuat);
            gbThongTinKhachHang.Controls.Add(panelCRUD);
            gbThongTinKhachHang.Controls.Add(btnTacVu);
            gbThongTinKhachHang.Controls.Add(cboDonViTinh);
            gbThongTinKhachHang.Controls.Add(label6);
            gbThongTinKhachHang.Controls.Add(label5);
            gbThongTinKhachHang.Controls.Add(numDonGia);
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(btnTimKiem);
            gbThongTinKhachHang.Controls.Add(numSoLuong);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(txtTenNL);
            gbThongTinKhachHang.Controls.Add(txtTrangThai);
            gbThongTinKhachHang.Location = new Point(13, 17);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(958, 254);
            gbThongTinKhachHang.TabIndex = 7;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin nguyên liệu";
            // 
            // panelTimKiem
            // 
            panelTimKiem.Controls.Add(btnTim);
            panelTimKiem.Controls.Add(txtTimKiem);
            panelTimKiem.Location = new Point(575, 153);
            panelTimKiem.Name = "panelTimKiem";
            panelTimKiem.Size = new Size(255, 95);
            panelTimKiem.TabIndex = 69;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(37, 57);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(169, 30);
            btnTim.TabIndex = 68;
            btnTim.Text = "Tìm kiếm nguyên liệu";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(3, 24);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(249, 27);
            txtTimKiem.TabIndex = 0;
            // 
            // btnNhapXuat
            // 
            btnNhapXuat.Location = new Point(452, 126);
            btnNhapXuat.Name = "btnNhapXuat";
            btnNhapXuat.Size = new Size(107, 30);
            btnNhapXuat.TabIndex = 67;
            btnNhapXuat.Text = "Nhập - xuất";
            btnNhapXuat.UseVisualStyleBackColor = true;
            btnNhapXuat.Click += btnNhapXuat_Click;
            // 
            // panelNhapXuat
            // 
            panelNhapXuat.Controls.Add(btnNhap);
            panelNhapXuat.Controls.Add(btnXuat);
            panelNhapXuat.Location = new Point(433, 162);
            panelNhapXuat.Name = "panelNhapXuat";
            panelNhapXuat.Size = new Size(136, 86);
            panelNhapXuat.TabIndex = 66;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(17, 18);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(107, 30);
            btnNhap.TabIndex = 48;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(17, 53);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(107, 30);
            btnXuat.TabIndex = 49;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // panelCRUD
            // 
            panelCRUD.Controls.Add(btnThem);
            panelCRUD.Controls.Add(btnSua);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnLuu);
            panelCRUD.Controls.Add(btnHuyBo);
            panelCRUD.Location = new Point(206, 162);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(203, 86);
            panelCRUD.TabIndex = 65;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(4, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(57, 30);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(67, 18);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(57, 30);
            btnSua.TabIndex = 41;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(133, 18);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(57, 30);
            btnXoa.TabIndex = 42;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(37, 53);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(57, 30);
            btnLuu.TabIndex = 43;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(100, 53);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(57, 30);
            btnHuyBo.TabIndex = 47;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTacVu
            // 
            btnTacVu.Location = new Point(265, 126);
            btnTacVu.Name = "btnTacVu";
            btnTacVu.Size = new Size(97, 30);
            btnTacVu.TabIndex = 64;
            btnTacVu.Text = "CRUD";
            btnTacVu.UseVisualStyleBackColor = true;
            btnTacVu.Click += btnTacVu_Click;
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Location = new Point(415, 39);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(154, 28);
            cboDonViTinh.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 39);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 60;
            label6.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 78);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 59;
            label5.Text = "Đơn giá:";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(123, 76);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(177, 27);
            numDonGia.TabIndex = 58;
            numDonGia.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(597, 39);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 57;
            label4.Text = "Số lượng:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(649, 126);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 30);
            btnTimKiem.TabIndex = 48;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(675, 40);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(177, 27);
            numSoLuong.TabIndex = 56;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 30;
            label1.Text = "Tên nguyên liệu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 83);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 32;
            label3.Text = "Trạng thái:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(459, 612);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 30);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNguyenLieu);
            groupBox1.Location = new Point(13, 277);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 329);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nguyên liệu";
            // 
            // dgvNguyenLieu
            // 
            dgvNguyenLieu.AllowUserToAddRows = false;
            dgvNguyenLieu.AllowUserToDeleteRows = false;
            dgvNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNguyenLieu.Columns.AddRange(new DataGridViewColumn[] { colID, TenNL, TenDVT, SoLuong, GiaNL, TrangThai });
            dgvNguyenLieu.Dock = DockStyle.Fill;
            dgvNguyenLieu.Location = new Point(3, 23);
            dgvNguyenLieu.MultiSelect = false;
            dgvNguyenLieu.Name = "dgvNguyenLieu";
            dgvNguyenLieu.RowHeadersWidth = 51;
            dgvNguyenLieu.Size = new Size(952, 303);
            dgvNguyenLieu.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // TenNL
            // 
            TenNL.DataPropertyName = "TenNL";
            TenNL.HeaderText = "Tên nguyên liệu";
            TenNL.MinimumWidth = 6;
            TenNL.Name = "TenNL";
            // 
            // TenDVT
            // 
            TenDVT.DataPropertyName = "TenDVT";
            TenDVT.HeaderText = "Đơn vị tính";
            TenDVT.MinimumWidth = 6;
            TenDVT.Name = "TenDVT";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // GiaNL
            // 
            GiaNL.DataPropertyName = "GiaNL";
            GiaNL.HeaderText = "Giá nguyên liệu";
            GiaNL.MinimumWidth = 6;
            GiaNL.Name = "GiaNL";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThaiNL";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // frmNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(gbThongTinKhachHang);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Name = "frmNguyenLieu";
            Text = "Nguyên Liệu";
            Load += frmNguyenLieu_Load;
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            panelTimKiem.ResumeLayout(false);
            panelTimKiem.PerformLayout();
            panelNhapXuat.ResumeLayout(false);
            panelCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTenNL;
        private TextBox txtTrangThai;
        private GroupBox gbThongTinKhachHang;
        private Panel panelCRUD;
        private Button btnNhap;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnTacVu;
        private ComboBox cboDonViTinh;
        private Label label6;
        private Label label5;
        private NumericUpDown numDonGia;
        private Label label4;
        private NumericUpDown numSoLuong;
        private Button btnThoat;
        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dgvNguyenLieu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenNL;
        private DataGridViewTextBoxColumn TenDVT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaNL;
        private DataGridViewTextBoxColumn TrangThai;
        private Panel panelNhapXuat;
        private Button btnNhapXuat;
        private Button btnTim;
        private TextBox txtTimKiem;
        private Panel panelTimKiem;
    }
}