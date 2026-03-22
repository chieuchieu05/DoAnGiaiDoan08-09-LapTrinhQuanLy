namespace QuanLyCuaHangTraSua.Forms
{
    partial class frmCongThuc
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnTacVu = new Button();
            panelTacVu = new Panel();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            numDinhLuong = new NumericUpDown();
            cboNguyenLieu = new ComboBox();
            cboTenSanPham = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvCongThuc = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            TenNL = new DataGridViewTextBoxColumn();
            DinhLuong = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panelTacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDinhLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCongThuc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnTacVu);
            groupBox1.Controls.Add(panelTacVu);
            groupBox1.Controls.Add(numDinhLuong);
            groupBox1.Controls.Add(cboNguyenLieu);
            groupBox1.Controls.Add(cboTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin công thức";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(564, 95);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(85, 29);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(473, 95);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(85, 29);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTacVu
            // 
            btnTacVu.Location = new Point(382, 95);
            btnTacVu.Name = "btnTacVu";
            btnTacVu.Size = new Size(85, 29);
            btnTacVu.TabIndex = 13;
            btnTacVu.Text = "Tác vụ";
            btnTacVu.UseVisualStyleBackColor = true;
            btnTacVu.Click += btnTacVu_Click;
            // 
            // panelTacVu
            // 
            panelTacVu.Controls.Add(btnLuu);
            panelTacVu.Controls.Add(btnXoa);
            panelTacVu.Controls.Add(btnSua);
            panelTacVu.Controls.Add(btnThem);
            panelTacVu.Location = new Point(6, 72);
            panelTacVu.Name = "panelTacVu";
            panelTacVu.Size = new Size(370, 72);
            panelTacVu.TabIndex = 8;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(278, 23);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(85, 29);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(187, 23);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(96, 23);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(5, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // numDinhLuong
            // 
            numDinhLuong.Location = new Point(820, 33);
            numDinhLuong.Name = "numDinhLuong";
            numDinhLuong.Size = new Size(150, 27);
            numDinhLuong.TabIndex = 7;
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(479, 29);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(230, 28);
            cboNguyenLieu.TabIndex = 6;
            // 
            // cboTenSanPham
            // 
            cboTenSanPham.FormattingEnabled = true;
            cboTenSanPham.Location = new Point(125, 26);
            cboTenSanPham.Name = "cboTenSanPham";
            cboTenSanPham.Size = new Size(232, 28);
            cboTenSanPham.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(728, 35);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Định lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 35);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Nguyên liệu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCongThuc);
            groupBox2.Location = new Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(982, 326);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách công thức";
            // 
            // dgvCongThuc
            // 
            dgvCongThuc.AllowUserToAddRows = false;
            dgvCongThuc.AllowUserToDeleteRows = false;
            dgvCongThuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCongThuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCongThuc.Columns.AddRange(new DataGridViewColumn[] { colID, TenSP, TenNL, DinhLuong });
            dgvCongThuc.Dock = DockStyle.Bottom;
            dgvCongThuc.Location = new Point(3, 26);
            dgvCongThuc.MultiSelect = false;
            dgvCongThuc.Name = "dgvCongThuc";
            dgvCongThuc.RowHeadersWidth = 51;
            dgvCongThuc.Size = new Size(976, 297);
            dgvCongThuc.TabIndex = 17;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Sản phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            // 
            // TenNL
            // 
            TenNL.DataPropertyName = "TenNL";
            TenNL.HeaderText = "Nguyên liệu";
            TenNL.MinimumWidth = 6;
            TenNL.Name = "TenNL";
            // 
            // DinhLuong
            // 
            DinhLuong.DataPropertyName = "DinhLuong";
            DinhLuong.HeaderText = "Định lượng";
            DinhLuong.MinimumWidth = 6;
            DinhLuong.Name = "DinhLuong";
            // 
            // frmCongThuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 503);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmCongThuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Công Thức";
            Load += frmCongThuc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelTacVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDinhLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCongThuc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvCongThuc;
        private Label label1;
        private Panel panelTacVu;
        private NumericUpDown numDinhLuong;
        private ComboBox cboNguyenLieu;
        private ComboBox cboTenSanPham;
        private Label label3;
        private Label label2;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTacVu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn TenNL;
        private DataGridViewTextBoxColumn DinhLuong;
    }
}