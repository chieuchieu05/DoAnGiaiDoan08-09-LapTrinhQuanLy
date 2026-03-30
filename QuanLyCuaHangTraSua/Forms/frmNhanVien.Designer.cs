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
            picStaff = new PictureBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnThoat = new Button();
            btnNhapXuat = new Button();
            btnCRUD = new Button();
            cboVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCCCDNV = new TextBox();
            txtSDTNV = new TextBox();
            txtHoTenNV = new TextBox();
            txtDiaChiNV = new TextBox();
            panelNhapXuat = new Panel();
            btnXuat = new Button();
            btnNhap = new Button();
            panelCRUD = new Panel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
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
            gbThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStaff).BeginInit();
            groupBox2.SuspendLayout();
            panelNhapXuat.SuspendLayout();
            panelCRUD.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // gbThongTinKhachHang
            // 
            gbThongTinKhachHang.Controls.Add(picStaff);
            gbThongTinKhachHang.Controls.Add(groupBox2);
            gbThongTinKhachHang.Controls.Add(btnThoat);
            gbThongTinKhachHang.Controls.Add(btnNhapXuat);
            gbThongTinKhachHang.Controls.Add(btnCRUD);
            gbThongTinKhachHang.Controls.Add(cboVaiTro);
            gbThongTinKhachHang.Controls.Add(txtMatKhau);
            gbThongTinKhachHang.Controls.Add(txtTenDangNhap);
            gbThongTinKhachHang.Controls.Add(label7);
            gbThongTinKhachHang.Controls.Add(label6);
            gbThongTinKhachHang.Controls.Add(label5);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label2);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(txtCCCDNV);
            gbThongTinKhachHang.Controls.Add(txtSDTNV);
            gbThongTinKhachHang.Controls.Add(txtHoTenNV);
            gbThongTinKhachHang.Controls.Add(txtDiaChiNV);
            gbThongTinKhachHang.Controls.Add(panelNhapXuat);
            gbThongTinKhachHang.Controls.Add(panelCRUD);
            gbThongTinKhachHang.Dock = DockStyle.Top;
            gbThongTinKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbThongTinKhachHang.ForeColor = Color.RosyBrown;
            gbThongTinKhachHang.Location = new Point(0, 0);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(1902, 324);
            gbThongTinKhachHang.TabIndex = 1;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin nhân viên";
            // 
            // picStaff
            // 
            picStaff.Image = Properties.Resources.staff;
            picStaff.Location = new Point(1173, 24);
            picStaff.Name = "picStaff";
            picStaff.Size = new Size(488, 300);
            picStaff.SizeMode = PictureBoxSizeMode.Zoom;
            picStaff.TabIndex = 58;
            picStaff.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.ForeColor = Color.RosyBrown;
            groupBox2.Location = new Point(17, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(955, 65);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.RosyBrown;
            label8.Location = new Point(9, 33);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 48;
            label8.Text = "Nhập họ tên:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(842, 24);
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
            txtTimKiem.Size = new Size(709, 27);
            txtTimKiem.TabIndex = 48;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.PowderBlue;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Teal;
            btnThoat.Location = new Point(1713, 228);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 58);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhapXuat
            // 
            btnNhapXuat.BackColor = Color.PowderBlue;
            btnNhapXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhapXuat.ForeColor = Color.Teal;
            btnNhapXuat.Location = new Point(1713, 137);
            btnNhapXuat.Name = "btnNhapXuat";
            btnNhapXuat.Size = new Size(123, 60);
            btnNhapXuat.TabIndex = 57;
            btnNhapXuat.Text = "Nhập - Xuất";
            btnNhapXuat.UseVisualStyleBackColor = false;
            btnNhapXuat.Click += btnNhapXuat_Click;
            // 
            // btnCRUD
            // 
            btnCRUD.BackColor = Color.PowderBlue;
            btnCRUD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCRUD.ForeColor = Color.Teal;
            btnCRUD.Location = new Point(1713, 45);
            btnCRUD.Name = "btnCRUD";
            btnCRUD.Size = new Size(123, 57);
            btnCRUD.TabIndex = 56;
            btnCRUD.Text = "CRUD";
            btnCRUD.UseVisualStyleBackColor = false;
            btnCRUD.Click += btnCRUD_Click;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Admin", "User" });
            cboVaiTro.Location = new Point(986, 98);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(144, 28);
            cboVaiTro.TabIndex = 53;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(986, 45);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(144, 27);
            txtMatKhau.TabIndex = 52;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(582, 45);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(264, 27);
            txtTenDangNhap.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.RosyBrown;
            label7.Location = new Point(881, 108);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 50;
            label7.Text = "Vai trò:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.RosyBrown;
            label6.Location = new Point(880, 48);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 49;
            label6.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.RosyBrown;
            label5.Location = new Point(457, 45);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 48;
            label5.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(28, 48);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 30;
            label1.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(27, 108);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 31;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(28, 159);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 32;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(457, 108);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 33;
            label4.Text = "CCCD:";
            // 
            // txtCCCDNV
            // 
            txtCCCDNV.Location = new Point(582, 105);
            txtCCCDNV.Name = "txtCCCDNV";
            txtCCCDNV.Size = new Size(264, 27);
            txtCCCDNV.TabIndex = 39;
            // 
            // txtSDTNV
            // 
            txtSDTNV.Location = new Point(159, 105);
            txtSDTNV.Name = "txtSDTNV";
            txtSDTNV.Size = new Size(177, 27);
            txtSDTNV.TabIndex = 38;
            // 
            // txtHoTenNV
            // 
            txtHoTenNV.Location = new Point(159, 45);
            txtHoTenNV.Name = "txtHoTenNV";
            txtHoTenNV.Size = new Size(266, 27);
            txtHoTenNV.TabIndex = 35;
            // 
            // txtDiaChiNV
            // 
            txtDiaChiNV.Location = new Point(159, 159);
            txtDiaChiNV.Name = "txtDiaChiNV";
            txtDiaChiNV.Size = new Size(687, 27);
            txtDiaChiNV.TabIndex = 36;
            // 
            // panelNhapXuat
            // 
            panelNhapXuat.Controls.Add(btnXuat);
            panelNhapXuat.Controls.Add(btnNhap);
            panelNhapXuat.Location = new Point(1426, 137);
            panelNhapXuat.Name = "panelNhapXuat";
            panelNhapXuat.Size = new Size(258, 69);
            panelNhapXuat.TabIndex = 55;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.PowderBlue;
            btnXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuat.ForeColor = Color.Teal;
            btnXuat.Location = new Point(133, 10);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(102, 42);
            btnXuat.TabIndex = 49;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.PowderBlue;
            btnNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.ForeColor = Color.Teal;
            btnNhap.Location = new Point(16, 10);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(102, 42);
            btnNhap.TabIndex = 48;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // panelCRUD
            // 
            panelCRUD.Controls.Add(btnThem);
            panelCRUD.Controls.Add(btnSua);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnLuu);
            panelCRUD.Controls.Add(btnHuyBo);
            panelCRUD.Location = new Point(1167, 40);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(517, 62);
            panelCRUD.TabIndex = 54;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PowderBlue;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.Teal;
            btnThem.Location = new Point(6, 7);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(87, 42);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.PowderBlue;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.Teal;
            btnSua.Location = new Point(111, 7);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(87, 42);
            btnSua.TabIndex = 41;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.PowderBlue;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Teal;
            btnXoa.Location = new Point(215, 7);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(87, 42);
            btnXoa.TabIndex = 42;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.PowderBlue;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Teal;
            btnLuu.Location = new Point(318, 7);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(87, 42);
            btnLuu.TabIndex = 43;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.PowderBlue;
            btnHuyBo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.Teal;
            btnHuyBo.Location = new Point(417, 7);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(87, 42);
            btnHuyBo.TabIndex = 47;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNhanVien);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1902, 709);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.LavenderBlush;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, TenNV, DiaChiNV, SDTNV, CCCD, TenDangNhap, MatKhau, VaiTro });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 23);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1896, 683);
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
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groupBox1);
            Controls.Add(gbThongTinKhachHang);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStaff).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelNhapXuat.ResumeLayout(false);
            panelCRUD.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
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
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnNhapXuat;
        private Button btnCRUD;
        private Panel panelNhapXuat;
        private Panel panelCRUD;
        private PictureBox picStaff;
    }
}