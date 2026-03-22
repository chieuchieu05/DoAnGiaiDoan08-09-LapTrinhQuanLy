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
            panelTacVu = new Panel();
            btnNhap = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnTacVu = new Button();
            cboDonViTinh = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            numDonGia = new NumericUpDown();
            label4 = new Label();
            numSoLuong = new NumericUpDown();
            btnThoat = new Button();
            label1 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dgvNguyenLieu = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenNL = new DataGridViewTextBoxColumn();
            TenDVT = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaNL = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            gbThongTinKhachHang.SuspendLayout();
            panelTacVu.SuspendLayout();
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
            gbThongTinKhachHang.Controls.Add(panelTacVu);
            gbThongTinKhachHang.Controls.Add(btnTacVu);
            gbThongTinKhachHang.Controls.Add(cboDonViTinh);
            gbThongTinKhachHang.Controls.Add(label6);
            gbThongTinKhachHang.Controls.Add(label5);
            gbThongTinKhachHang.Controls.Add(numDonGia);
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(numSoLuong);
            gbThongTinKhachHang.Controls.Add(btnThoat);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(txtTenNL);
            gbThongTinKhachHang.Controls.Add(txtTrangThai);
            gbThongTinKhachHang.Location = new Point(13, 17);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(958, 222);
            gbThongTinKhachHang.TabIndex = 7;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin nguyên liệu";
            // 
            // panelTacVu
            // 
            panelTacVu.Controls.Add(btnNhap);
            panelTacVu.Controls.Add(btnThem);
            panelTacVu.Controls.Add(btnSua);
            panelTacVu.Controls.Add(btnXoa);
            panelTacVu.Controls.Add(btnLuu);
            panelTacVu.Controls.Add(btnHuyBo);
            panelTacVu.Controls.Add(btnXuat);
            panelTacVu.Controls.Add(btnTimKiem);
            panelTacVu.Location = new Point(113, 116);
            panelTacVu.Name = "panelTacVu";
            panelTacVu.Size = new Size(516, 103);
            panelTacVu.TabIndex = 65;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(391, 19);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(107, 30);
            btnNhap.TabIndex = 48;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(4, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 30);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(140, 19);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 30);
            btnSua.TabIndex = 41;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(266, 18);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 30);
            btnXoa.TabIndex = 42;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(4, 64);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(107, 30);
            btnLuu.TabIndex = 43;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(140, 64);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(107, 30);
            btnHuyBo.TabIndex = 47;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(391, 61);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(107, 30);
            btnXuat.TabIndex = 49;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(266, 64);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 30);
            btnTimKiem.TabIndex = 48;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnTacVu
            // 
            btnTacVu.Location = new Point(10, 114);
            btnTacVu.Name = "btnTacVu";
            btnTacVu.Size = new Size(97, 30);
            btnTacVu.TabIndex = 64;
            btnTacVu.Text = "Tác vụ ";
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
            // numSoLuong
            // 
            numSoLuong.Location = new Point(675, 40);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(177, 27);
            numSoLuong.TabIndex = 56;
            numSoLuong.ThousandsSeparator = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(10, 164);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 30);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNguyenLieu);
            groupBox1.Location = new Point(12, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 391);
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
            dgvNguyenLieu.Size = new Size(952, 365);
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
            Name = "frmNguyenLieu";
            Text = "Nguyên Liệu";
            Load += frmNguyenLieu_Load;
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            panelTacVu.ResumeLayout(false);
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
        private Panel panelTacVu;
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
    }
}