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
            btnHuyBo = new Button();
            label5 = new Label();
            txtSoTaiKhoanKH = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmailKH = new TextBox();
            txtSDTKH = new TextBox();
            txtHoTenKH = new TextBox();
            txtDiaChiKH = new TextBox();
            gbDanhSachKhachHang = new GroupBox();
            dgvKhachHang = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            DiaChiKH = new DataGridViewTextBoxColumn();
            SDTKH = new DataGridViewTextBoxColumn();
            EmailKH = new DataGridViewTextBoxColumn();
            SoTaiKhoanKH = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            gbThongTinKhachHang.SuspendLayout();
            gbDanhSachKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gbThongTinKhachHang
            // 
            gbThongTinKhachHang.Controls.Add(btnThoat);
            gbThongTinKhachHang.Controls.Add(btnHuyBo);
            gbThongTinKhachHang.Controls.Add(label5);
            gbThongTinKhachHang.Controls.Add(txtSoTaiKhoanKH);
            gbThongTinKhachHang.Controls.Add(btnLuu);
            gbThongTinKhachHang.Controls.Add(btnXoa);
            gbThongTinKhachHang.Controls.Add(btnSua);
            gbThongTinKhachHang.Controls.Add(btnThem);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label2);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(txtEmailKH);
            gbThongTinKhachHang.Controls.Add(txtSDTKH);
            gbThongTinKhachHang.Controls.Add(txtHoTenKH);
            gbThongTinKhachHang.Controls.Add(txtDiaChiKH);
            gbThongTinKhachHang.Location = new Point(12, 12);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(958, 166);
            gbThongTinKhachHang.TabIndex = 0;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(826, 76);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(107, 30);
            btnHuyBo.TabIndex = 47;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 76);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 45;
            label5.Text = "Số tài khoản:";
            // 
            // txtSoTaiKhoanKH
            // 
            txtSoTaiKhoanKH.Location = new Point(455, 73);
            txtSoTaiKhoanKH.Name = "txtSoTaiKhoanKH";
            txtSoTaiKhoanKH.Size = new Size(177, 27);
            txtSoTaiKhoanKH.TabIndex = 46;
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
            label1.Size = new Size(114, 20);
            label1.TabIndex = 30;
            label1.Text = "Tên khách hàng:";
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
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 32;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 34);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 33;
            label4.Text = "Email:";
            // 
            // txtEmailKH
            // 
            txtEmailKH.Location = new Point(455, 31);
            txtEmailKH.Name = "txtEmailKH";
            txtEmailKH.Size = new Size(177, 27);
            txtEmailKH.TabIndex = 39;
            // 
            // txtSDTKH
            // 
            txtSDTKH.Location = new Point(123, 71);
            txtSDTKH.Name = "txtSDTKH";
            txtSDTKH.Size = new Size(177, 27);
            txtSDTKH.TabIndex = 38;
            // 
            // txtHoTenKH
            // 
            txtHoTenKH.Location = new Point(123, 32);
            txtHoTenKH.Name = "txtHoTenKH";
            txtHoTenKH.Size = new Size(177, 27);
            txtHoTenKH.TabIndex = 35;
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(123, 121);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(509, 27);
            txtDiaChiKH.TabIndex = 36;
            // 
            // gbDanhSachKhachHang
            // 
            gbDanhSachKhachHang.Controls.Add(dgvKhachHang);
            gbDanhSachKhachHang.Location = new Point(12, 255);
            gbDanhSachKhachHang.Name = "gbDanhSachKhachHang";
            gbDanhSachKhachHang.Size = new Size(958, 386);
            gbDanhSachKhachHang.TabIndex = 1;
            gbDanhSachKhachHang.TabStop = false;
            gbDanhSachKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { ID, TenKH, DiaChiKH, SDTKH, EmailKH, SoTaiKhoanKH });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(3, 23);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(952, 360);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Location = new Point(15, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 65);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 33);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 48;
            label6.Text = "Nhập họ tên:";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXuat);
            groupBox2.Controls.Add(btnNhap);
            groupBox2.Location = new Point(674, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 65);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập, Xuất dữ liệu";
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
            // btnThoat
            // 
            btnThoat.Location = new Point(826, 119);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 30);
            btnThoat.TabIndex = 48;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbDanhSachKhachHang);
            Controls.Add(gbThongTinKhachHang);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KHÁCH HÀNG";
            Load += frmKhachHang_Load;
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            gbDanhSachKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label5;
        private TextBox txtSoTaiKhoanKH;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn DiaChiKH;
        private DataGridViewTextBoxColumn SDTKH;
        private DataGridViewTextBoxColumn EmailKH;
        private DataGridViewTextBoxColumn SoTaiKhoanKH;
        private Button btnHuyBo;
        private GroupBox groupBox1;
        private Label label6;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
    }
}