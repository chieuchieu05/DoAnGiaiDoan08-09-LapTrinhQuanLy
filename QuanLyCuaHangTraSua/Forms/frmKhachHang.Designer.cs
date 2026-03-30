namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmKhachHang
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
            picBackGround = new PictureBox();
            btnCRUD = new Button();
            btnNhapXuat = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label5 = new Label();
            txtSoTaiKhoanKH = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmailKH = new TextBox();
            txtSDTKH = new TextBox();
            txtHoTenKH = new TextBox();
            txtDiaChiKH = new TextBox();
            panelNhapXuat = new Panel();
            btnXuat = new Button();
            btnNhap = new Button();
            panelCRUD = new Panel();
            btnThem = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            gbDanhSachKhachHang = new GroupBox();
            dgvKhachHang = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            DiaChiKH = new DataGridViewTextBoxColumn();
            SDTKH = new DataGridViewTextBoxColumn();
            EmailKH = new DataGridViewTextBoxColumn();
            SoTaiKhoanKH = new DataGridViewTextBoxColumn();
            gbThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackGround).BeginInit();
            groupBox1.SuspendLayout();
            panelNhapXuat.SuspendLayout();
            panelCRUD.SuspendLayout();
            gbDanhSachKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // gbThongTinKhachHang
            // 
            gbThongTinKhachHang.BackColor = Color.LavenderBlush;
            gbThongTinKhachHang.Controls.Add(btnThoat);
            gbThongTinKhachHang.Controls.Add(picBackGround);
            gbThongTinKhachHang.Controls.Add(btnCRUD);
            gbThongTinKhachHang.Controls.Add(btnNhapXuat);
            gbThongTinKhachHang.Controls.Add(groupBox1);
            gbThongTinKhachHang.Controls.Add(label5);
            gbThongTinKhachHang.Controls.Add(txtSoTaiKhoanKH);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label2);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(txtEmailKH);
            gbThongTinKhachHang.Controls.Add(txtSDTKH);
            gbThongTinKhachHang.Controls.Add(txtHoTenKH);
            gbThongTinKhachHang.Controls.Add(txtDiaChiKH);
            gbThongTinKhachHang.Controls.Add(panelNhapXuat);
            gbThongTinKhachHang.Controls.Add(panelCRUD);
            gbThongTinKhachHang.Dock = DockStyle.Top;
            gbThongTinKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbThongTinKhachHang.ForeColor = Color.RosyBrown;
            gbThongTinKhachHang.Location = new Point(0, 0);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(1902, 290);
            gbThongTinKhachHang.TabIndex = 0;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.PowderBlue;
            btnThoat.ForeColor = Color.Teal;
            btnThoat.Location = new Point(1726, 196);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 58);
            btnThoat.TabIndex = 48;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // picBackGround
            // 
            picBackGround.Image = Properties.Resources.pngbackground;
            picBackGround.Location = new Point(1225, 18);
            picBackGround.Name = "picBackGround";
            picBackGround.Size = new Size(404, 264);
            picBackGround.SizeMode = PictureBoxSizeMode.Zoom;
            picBackGround.TabIndex = 54;
            picBackGround.TabStop = false;
            // 
            // btnCRUD
            // 
            btnCRUD.BackColor = Color.PowderBlue;
            btnCRUD.ForeColor = Color.Teal;
            btnCRUD.Location = new Point(1726, 32);
            btnCRUD.Name = "btnCRUD";
            btnCRUD.Size = new Size(138, 57);
            btnCRUD.TabIndex = 50;
            btnCRUD.Text = "CRUD";
            btnCRUD.UseVisualStyleBackColor = false;
            btnCRUD.Click += btnCRUD_Click;
            // 
            // btnNhapXuat
            // 
            btnNhapXuat.BackColor = Color.PowderBlue;
            btnNhapXuat.ForeColor = Color.Teal;
            btnNhapXuat.Location = new Point(1726, 109);
            btnNhapXuat.Name = "btnNhapXuat";
            btnNhapXuat.Size = new Size(138, 61);
            btnNhapXuat.TabIndex = 52;
            btnNhapXuat.Text = "Nhập - Xuất";
            btnNhapXuat.UseVisualStyleBackColor = false;
            btnNhapXuat.Click += btnNhapXuat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Location = new Point(12, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(908, 65);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.RosyBrown;
            label6.Location = new Point(9, 33);
            label6.Name = "label6";
            label6.Size = new Size(114, 23);
            label6.TabIndex = 48;
            label6.Text = "Nhập họ tên:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(784, 25);
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
            txtTimKiem.Size = new Size(637, 30);
            txtTimKiem.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.RosyBrown;
            label5.Location = new Point(796, 109);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 45;
            label5.Text = "Số tài khoản:";
            // 
            // txtSoTaiKhoanKH
            // 
            txtSoTaiKhoanKH.Location = new Point(942, 102);
            txtSoTaiKhoanKH.Name = "txtSoTaiKhoanKH";
            txtSoTaiKhoanKH.Size = new Size(167, 30);
            txtSoTaiKhoanKH.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 30;
            label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(796, 48);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 31;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(22, 109);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 32;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(483, 48);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 33;
            label4.Text = "Email:";
            // 
            // txtEmailKH
            // 
            txtEmailKH.Location = new Point(565, 45);
            txtEmailKH.Name = "txtEmailKH";
            txtEmailKH.Size = new Size(204, 30);
            txtEmailKH.TabIndex = 39;
            // 
            // txtSDTKH
            // 
            txtSDTKH.Location = new Point(942, 42);
            txtSDTKH.Name = "txtSDTKH";
            txtSDTKH.Size = new Size(167, 30);
            txtSDTKH.TabIndex = 38;
            // 
            // txtHoTenKH
            // 
            txtHoTenKH.Location = new Point(195, 45);
            txtHoTenKH.Name = "txtHoTenKH";
            txtHoTenKH.Size = new Size(252, 30);
            txtHoTenKH.TabIndex = 35;
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(195, 109);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(574, 30);
            txtDiaChiKH.TabIndex = 36;
            // 
            // panelNhapXuat
            // 
            panelNhapXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNhapXuat.Controls.Add(btnXuat);
            panelNhapXuat.Controls.Add(btnNhap);
            panelNhapXuat.Location = new Point(1481, 118);
            panelNhapXuat.Name = "panelNhapXuat";
            panelNhapXuat.Size = new Size(229, 52);
            panelNhapXuat.TabIndex = 51;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.PowderBlue;
            btnXuat.ForeColor = Color.Teal;
            btnXuat.Location = new Point(118, 11);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(93, 30);
            btnXuat.TabIndex = 49;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.PowderBlue;
            btnNhap.ForeColor = Color.Teal;
            btnNhap.Location = new Point(3, 11);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(93, 30);
            btnNhap.TabIndex = 48;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // panelCRUD
            // 
            panelCRUD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelCRUD.Controls.Add(btnThem);
            panelCRUD.Controls.Add(btnSua);
            panelCRUD.Controls.Add(btnHuyBo);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnLuu);
            panelCRUD.Location = new Point(1145, 35);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(565, 41);
            panelCRUD.TabIndex = 49;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PowderBlue;
            btnThem.ForeColor = Color.Teal;
            btnThem.Location = new Point(3, 7);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 30);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.PowderBlue;
            btnSua.ForeColor = Color.Teal;
            btnSua.Location = new Point(118, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 30);
            btnSua.TabIndex = 41;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.PowderBlue;
            btnHuyBo.ForeColor = Color.Teal;
            btnHuyBo.Location = new Point(455, 7);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(92, 30);
            btnHuyBo.TabIndex = 47;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.PowderBlue;
            btnXoa.ForeColor = Color.Teal;
            btnXoa.Location = new Point(228, 7);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 30);
            btnXoa.TabIndex = 42;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.PowderBlue;
            btnLuu.ForeColor = Color.Teal;
            btnLuu.Location = new Point(342, 7);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(92, 30);
            btnLuu.TabIndex = 43;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // gbDanhSachKhachHang
            // 
            gbDanhSachKhachHang.BackColor = Color.Transparent;
            gbDanhSachKhachHang.Controls.Add(dgvKhachHang);
            gbDanhSachKhachHang.Dock = DockStyle.Fill;
            gbDanhSachKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            gbDanhSachKhachHang.ForeColor = Color.RosyBrown;
            gbDanhSachKhachHang.Location = new Point(0, 290);
            gbDanhSachKhachHang.Name = "gbDanhSachKhachHang";
            gbDanhSachKhachHang.Size = new Size(1902, 743);
            gbDanhSachKhachHang.TabIndex = 1;
            gbDanhSachKhachHang.TabStop = false;
            gbDanhSachKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.LavenderBlush;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { ID, TenKH, DiaChiKH, SDTKH, EmailKH, SoTaiKhoanKH });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(3, 26);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1896, 714);
            dgvKhachHang.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            // 
            // DiaChiKH
            // 
            DiaChiKH.DataPropertyName = "DiaChiKH";
            DiaChiKH.HeaderText = "Địa chỉ";
            DiaChiKH.MinimumWidth = 6;
            DiaChiKH.Name = "DiaChiKH";
            // 
            // SDTKH
            // 
            SDTKH.DataPropertyName = "SDTKH";
            SDTKH.HeaderText = "Số điện thoại";
            SDTKH.MinimumWidth = 6;
            SDTKH.Name = "SDTKH";
            // 
            // EmailKH
            // 
            EmailKH.DataPropertyName = "EmailKH";
            EmailKH.HeaderText = "Email";
            EmailKH.MinimumWidth = 6;
            EmailKH.Name = "EmailKH";
            // 
            // SoTaiKhoanKH
            // 
            SoTaiKhoanKH.DataPropertyName = "SoTaiKhoanKH";
            SoTaiKhoanKH.HeaderText = "Số tài khoản";
            SoTaiKhoanKH.MinimumWidth = 6;
            SoTaiKhoanKH.Name = "SoTaiKhoanKH";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(gbDanhSachKhachHang);
            Controls.Add(gbThongTinKhachHang);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KHÁCH HÀNG";
            WindowState = FormWindowState.Maximized;
            Load += frmKhachHang_Load;
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBackGround).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelNhapXuat.ResumeLayout(false);
            panelCRUD.ResumeLayout(false);
            gbDanhSachKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTinKhachHang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmailKH;
        private TextBox txtSDTKH;
        private TextBox txtHoTenKH;
        private TextBox txtDiaChiKH;
        private GroupBox gbDanhSachKhachHang;
        private DataGridView dgvKhachHang;
        private Label label5;
        private TextBox txtSoTaiKhoanKH;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn DiaChiKH;
        private DataGridViewTextBoxColumn SDTKH;
        private DataGridViewTextBoxColumn EmailKH;
        private DataGridViewTextBoxColumn SoTaiKhoanKH;
        private GroupBox groupBox1;
        private Label label6;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Panel panelNhapXuat;
        private Button btnXuat;
        private Button btnNhap;
        private Panel panelCRUD;
        private Button btnThem;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnLuu;
        private PictureBox picBackGround;
        private Button btnThoat;
        private Button btnCRUD;
        private Button btnNhapXuat;
    }
}