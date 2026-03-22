namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmNhanVien
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
            gbThongTinKhachHang = new GroupBox();
            btnThoat = new Button();
            cboVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCCCDNV = new TextBox();
            txtSDTNV = new TextBox();
            txtHoTenNV = new TextBox();
            txtDiaChiNV = new TextBox();
            groupBox1 = new GroupBox();
            dgvNhanVien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            DiaChiNV = new DataGridViewTextBoxColumn();
            SDTNV = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            VaiTro = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label8 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            groupBox3 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            gbThongTinKhachHang.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gbThongTinKhachHang
            // 
            gbThongTinKhachHang.Controls.Add(btnThoat);
            gbThongTinKhachHang.Controls.Add(cboVaiTro);
            gbThongTinKhachHang.Controls.Add(txtMatKhau);
            gbThongTinKhachHang.Controls.Add(txtTenDangNhap);
            gbThongTinKhachHang.Controls.Add(label7);
            gbThongTinKhachHang.Controls.Add(label6);
            gbThongTinKhachHang.Controls.Add(label5);
            gbThongTinKhachHang.Controls.Add(btnHuyBo);
            gbThongTinKhachHang.Controls.Add(btnLuu);
            gbThongTinKhachHang.Controls.Add(btnXoa);
            gbThongTinKhachHang.Controls.Add(btnSua);
            gbThongTinKhachHang.Controls.Add(btnThem);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label2);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(txtCCCDNV);
            gbThongTinKhachHang.Controls.Add(txtSDTNV);
            gbThongTinKhachHang.Controls.Add(txtHoTenNV);
            gbThongTinKhachHang.Controls.Add(txtDiaChiNV);
            gbThongTinKhachHang.Location = new Point(12, 22);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(958, 198);
            gbThongTinKhachHang.TabIndex = 1;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin nhân viên";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(826, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 30);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Admin", "User" });
            cboVaiTro.Location = new Point(455, 113);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(177, 28);
            cboVaiTro.TabIndex = 53;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(455, 74);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(177, 27);
            txtMatKhau.TabIndex = 52;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(455, 35);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(177, 27);
            txtTenDangNhap.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 115);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 50;
            label7.Text = "Vai trò:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 74);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 49;
            label6.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 35);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 48;
            label5.Text = "Tên đăng nhập:";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(826, 74);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(107, 30);
            btnHuyBo.TabIndex = 47;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(826, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(107, 30);
            btnLuu.TabIndex = 43;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(690, 118);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 30);
            btnXoa.TabIndex = 42;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(690, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 30);
            btnSua.TabIndex = 41;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(690, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 30);
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
            label1.Size = new Size(102, 20);
            label1.TabIndex = 30;
            label1.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 31;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 159);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 32;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 113);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 33;
            label4.Text = "CCCD:";
            // 
            // txtCCCDNV
            // 
            txtCCCDNV.Location = new Point(123, 113);
            txtCCCDNV.Name = "txtCCCDNV";
            txtCCCDNV.Size = new Size(177, 27);
            txtCCCDNV.TabIndex = 39;
            // 
            // txtSDTNV
            // 
            txtSDTNV.Location = new Point(123, 71);
            txtSDTNV.Name = "txtSDTNV";
            txtSDTNV.Size = new Size(177, 27);
            txtSDTNV.TabIndex = 38;
            // 
            // txtHoTenNV
            // 
            txtHoTenNV.Location = new Point(123, 32);
            txtHoTenNV.Name = "txtHoTenNV";
            txtHoTenNV.Size = new Size(177, 27);
            txtHoTenNV.TabIndex = 35;
            // 
            // txtDiaChiNV
            // 
            txtDiaChiNV.Location = new Point(123, 159);
            txtDiaChiNV.Name = "txtDiaChiNV";
            txtDiaChiNV.Size = new Size(509, 27);
            txtDiaChiNV.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNhanVien);
            groupBox1.Location = new Point(12, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 344);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, TenNV, DiaChiNV, SDTNV, CCCD, TenDangNhap, MatKhau, VaiTro });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 23);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(952, 318);
            dgvNhanVien.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Họ và tên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            // 
            // DiaChiNV
            // 
            DiaChiNV.DataPropertyName = "DiaChiNV";
            DiaChiNV.HeaderText = "Địa chỉ";
            DiaChiNV.MinimumWidth = 6;
            DiaChiNV.Name = "DiaChiNV";
            // 
            // SDTNV
            // 
            SDTNV.DataPropertyName = "SDTNV";
            SDTNV.HeaderText = "Số điện thoại";
            SDTNV.MinimumWidth = 6;
            SDTNV.Name = "SDTNV";
            // 
            // CCCD
            // 
            CCCD.DataPropertyName = "CCCD";
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            // 
            // VaiTro
            // 
            VaiTro.DataPropertyName = "VaiTro";
            VaiTro.HeaderText = "Vai trò";
            VaiTro.MinimumWidth = 6;
            VaiTro.Name = "VaiTro";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(12, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(647, 65);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 33);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 48;
            label8.Text = "Nhập họ tên:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(522, 24);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 30);
            btnTimKiem.TabIndex = 48;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(120, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(396, 27);
            txtTimKiem.TabIndex = 48;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXuat);
            groupBox3.Controls.Add(btnNhap);
            groupBox3.Location = new Point(673, 226);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(297, 65);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhập, Xuất dữ liệu";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(164, 23);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(107, 30);
            btnXuat.TabIndex = 49;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(28, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(107, 30);
            btnNhap.TabIndex = 48;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbThongTinKhachHang);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTinKhachHang;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCCCDNV;
        private TextBox txtSDTNV;
        private TextBox txtHoTenNV;
        private TextBox txtDiaChiNV;
        private ComboBox cboVaiTro;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn DiaChiNV;
        private DataGridViewTextBoxColumn SDTNV;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn VaiTro;
        private GroupBox groupBox2;
        private Label label8;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
    }
}