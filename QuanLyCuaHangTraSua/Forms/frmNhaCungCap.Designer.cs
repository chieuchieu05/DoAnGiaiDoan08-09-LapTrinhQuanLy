namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmNhaCungCap
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
            txtTimKiem = new TextBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            txtSDTNCC = new TextBox();
            dgvNhaCungCap = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNCC = new DataGridViewTextBoxColumn();
            DiaChiNCC = new DataGridViewTextBoxColumn();
            SDTNCC = new DataGridViewTextBoxColumn();
            EmailNCC = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtTenNCC = new TextBox();
            txtDiaChiNCC = new TextBox();
            gbThongTinKhachHang = new GroupBox();
            label4 = new Label();
            txtEmailNCC = new TextBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            groupBox1.SuspendLayout();
            gbThongTinKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(120, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(396, 27);
            txtTimKiem.TabIndex = 48;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 33);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 48;
            label8.Text = "Nhập họ tên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(12, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(647, 65);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
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
            label1.Size = new Size(127, 20);
            label1.TabIndex = 30;
            label1.Text = "Tên nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 31;
            label2.Text = "Số điện thoại ncc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 115);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 32;
            label3.Text = "Địa chỉ:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXuat);
            groupBox3.Controls.Add(btnNhap);
            groupBox3.Location = new Point(673, 191);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(297, 65);
            groupBox3.TabIndex = 8;
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
            // txtSDTNCC
            // 
            txtSDTNCC.Location = new Point(133, 71);
            txtSDTNCC.Name = "txtSDTNCC";
            txtSDTNCC.Size = new Size(177, 27);
            txtSDTNCC.TabIndex = 38;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.AllowUserToDeleteRows = false;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { ID, TenNCC, DiaChiNCC, SDTNCC, EmailNCC });
            dgvNhaCungCap.Dock = DockStyle.Fill;
            dgvNhaCungCap.Location = new Point(3, 23);
            dgvNhaCungCap.MultiSelect = false;
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.Size = new Size(952, 348);
            dgvNhaCungCap.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenNCC
            // 
            TenNCC.DataPropertyName = "TenNCC";
            TenNCC.HeaderText = "Họ và tên";
            TenNCC.MinimumWidth = 6;
            TenNCC.Name = "TenNCC";
            // 
            // DiaChiNCC
            // 
            DiaChiNCC.DataPropertyName = "DiaChiNCC";
            DiaChiNCC.HeaderText = "Địa chỉ";
            DiaChiNCC.MinimumWidth = 6;
            DiaChiNCC.Name = "DiaChiNCC";
            // 
            // SDTNCC
            // 
            SDTNCC.DataPropertyName = "SDTNCC";
            SDTNCC.HeaderText = "Số điện thoại";
            SDTNCC.MinimumWidth = 6;
            SDTNCC.Name = "SDTNCC";
            // 
            // EmailNCC
            // 
            EmailNCC.DataPropertyName = "EmailNCC";
            EmailNCC.HeaderText = "Email";
            EmailNCC.MinimumWidth = 6;
            EmailNCC.Name = "EmailNCC";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNhaCungCap);
            groupBox1.Location = new Point(12, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 374);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(133, 32);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(177, 27);
            txtTenNCC.TabIndex = 35;
            // 
            // txtDiaChiNCC
            // 
            txtDiaChiNCC.Location = new Point(133, 115);
            txtDiaChiNCC.Name = "txtDiaChiNCC";
            txtDiaChiNCC.Size = new Size(509, 27);
            txtDiaChiNCC.TabIndex = 36;
            // 
            // gbThongTinKhachHang
            // 
            gbThongTinKhachHang.Controls.Add(label4);
            gbThongTinKhachHang.Controls.Add(txtEmailNCC);
            gbThongTinKhachHang.Controls.Add(btnThoat);
            gbThongTinKhachHang.Controls.Add(btnHuyBo);
            gbThongTinKhachHang.Controls.Add(btnLuu);
            gbThongTinKhachHang.Controls.Add(btnXoa);
            gbThongTinKhachHang.Controls.Add(btnSua);
            gbThongTinKhachHang.Controls.Add(btnThem);
            gbThongTinKhachHang.Controls.Add(label1);
            gbThongTinKhachHang.Controls.Add(label2);
            gbThongTinKhachHang.Controls.Add(label3);
            gbThongTinKhachHang.Controls.Add(txtSDTNCC);
            gbThongTinKhachHang.Controls.Add(txtTenNCC);
            gbThongTinKhachHang.Controls.Add(txtDiaChiNCC);
            gbThongTinKhachHang.Location = new Point(12, 17);
            gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            gbThongTinKhachHang.Size = new Size(958, 168);
            gbThongTinKhachHang.TabIndex = 5;
            gbThongTinKhachHang.TabStop = false;
            gbThongTinKhachHang.Text = "Thông tin nhà cung cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 71);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 55;
            label4.Text = "Email:";
            // 
            // txtEmailNCC
            // 
            txtEmailNCC.Location = new Point(402, 67);
            txtEmailNCC.Name = "txtEmailNCC";
            txtEmailNCC.Size = new Size(177, 27);
            txtEmailNCC.TabIndex = 56;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(gbThongTinKhachHang);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà Cung Cấp";
            Load += frmNhaCungCap_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            groupBox1.ResumeLayout(false);
            gbThongTinKhachHang.ResumeLayout(false);
            gbThongTinKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Label label8;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox3;
        private Button btnXuat;
        private Button btnNhap;
        private TextBox txtSDTNCC;
        private DataGridView dgvNhaCungCap;
        private GroupBox groupBox1;
        private TextBox txtTenNCC;
        private TextBox txtDiaChiNCC;
        private GroupBox gbThongTinKhachHang;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNCC;
        private DataGridViewTextBoxColumn DiaChiNCC;
        private DataGridViewTextBoxColumn SDTNCC;
        private DataGridViewTextBoxColumn EmailNCC;
        private Label label4;
        private TextBox txtEmailNCC;
    }
}