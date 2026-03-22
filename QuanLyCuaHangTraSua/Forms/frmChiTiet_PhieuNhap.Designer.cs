namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmChiTiet_PhieuNhap
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
            groupBox1 = new GroupBox();
            txtGhiChuPhieuNhap = new TextBox();
            label3 = new Label();
            cboNhaCungCap = new ComboBox();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvChiTietPhieuNhap = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenNguyenLieu = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnXacNhanNhapHang = new Button();
            numGiaNhap = new NumericUpDown();
            numSoLuongNhap = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cboNguyenLieu = new ComboBox();
            label4 = new Label();
            btnInPhieuNhap = new Button();
            btnLuuPhieuNhap = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChuPhieuNhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 155);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtGhiChuPhieuNhap
            // 
            txtGhiChuPhieuNhap.Location = new Point(159, 88);
            txtGhiChuPhieuNhap.Name = "txtGhiChuPhieuNhap";
            txtGhiChuPhieuNhap.Size = new Size(774, 27);
            txtGhiChuPhieuNhap.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 91);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 4;
            label3.Text = "Chi tiết phiếu nhập:";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(638, 32);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(295, 28);
            cboNhaCungCap.TabIndex = 3;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(142, 32);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(296, 28);
            cboNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 35);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhà cung cấp(*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập (*)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvChiTietPhieuNhap);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanNhapHang);
            groupBox2.Controls.Add(numGiaNhap);
            groupBox2.Controls.Add(numSoLuongNhap);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboNguyenLieu);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(958, 398);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // dgvChiTietPhieuNhap
            // 
            dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            dgvChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colID, TenNguyenLieu, DonGia, SoLuong, ThanhTien });
            dgvChiTietPhieuNhap.Dock = DockStyle.Bottom;
            dgvChiTietPhieuNhap.Location = new Point(3, 127);
            dgvChiTietPhieuNhap.MultiSelect = false;
            dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            dgvChiTietPhieuNhap.Size = new Size(952, 268);
            dgvChiTietPhieuNhap.TabIndex = 16;
            dgvChiTietPhieuNhap.CellClick += dgvChiTietPhieuNhap_CellClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // TenNguyenLieu
            // 
            TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            TenNguyenLieu.MinimumWidth = 6;
            TenNguyenLieu.Name = "TenNguyenLieu";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá bán";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(705, 71);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 31);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanNhapHang
            // 
            btnXacNhanNhapHang.Location = new Point(541, 71);
            btnXacNhanNhapHang.Name = "btnXacNhanNhapHang";
            btnXacNhanNhapHang.Size = new Size(158, 31);
            btnXacNhanNhapHang.TabIndex = 13;
            btnXacNhanNhapHang.Text = "Xác nhận nhập hàng";
            btnXacNhanNhapHang.UseVisualStyleBackColor = true;
            btnXacNhanNhapHang.Click += btnXacNhanNhapHang_Click;
            // 
            // numGiaNhap
            // 
            numGiaNhap.Location = new Point(225, 71);
            numGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.Size = new Size(140, 27);
            numGiaNhap.TabIndex = 12;
            numGiaNhap.ThousandsSeparator = true;
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Location = new Point(382, 72);
            numSoLuongNhap.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(140, 27);
            numSoLuongNhap.TabIndex = 11;
            numSoLuongNhap.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 37);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 8;
            label6.Text = "Số lượng(*)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 36);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 7;
            label5.Text = "Giá nhập(*)";
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(16, 71);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(194, 28);
            cboNguyenLieu.TabIndex = 6;
            cboNguyenLieu.SelectionChangeCommitted += cboNguyenLieu_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 37);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Nguyên liệu (*)";
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Location = new Point(450, 598);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(123, 31);
            btnInPhieuNhap.TabIndex = 28;
            btnInPhieuNhap.Text = "In phiếu nhập";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.Location = new Point(321, 598);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(123, 31);
            btnLuuPhieuNhap.TabIndex = 27;
            btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(578, 598);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 31);
            btnThoat.TabIndex = 29;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmChiTiet_PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 646);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLuuPhieuNhap);
            Controls.Add(btnThoat);
            Name = "frmChiTiet_PhieuNhap";
            Text = "Chi Tiết Phiếu Nhập";
            Load += frmChiTiet_PhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGhiChuPhieuNhap;
        private Label label3;
        private ComboBox cboNhaCungCap;
        private ComboBox cboNhanVien;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvChiTietPhieuNhap;
        private Button btnXoa;
        private Button btnXacNhanNhapHang;
        private NumericUpDown numGiaNhap;
        private NumericUpDown numSoLuongNhap;
        private Label label6;
        private Label label5;
        private ComboBox cboNguyenLieu;
        private Label label4;
        private Button btnInPhieuNhap;
        private Button btnLuuPhieuNhap;
        private Button btnThoat;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenNguyenLieu;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}