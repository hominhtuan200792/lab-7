namespace Quản_lý_sản_phẩm
{
    partial class FormThemSanPham
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
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboLoaiSP = new ComboBox();
            dtpNgayNhap = new DateTimePicker();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            ngaynhap = new Label();
            soluong = new Label();
            DonGia = new Label();
            LoaiSP = new Label();
            TenSP = new Label();
            ma = new Label();
            label1 = new Label();
            bttluu = new Button();
            bttthoat = new Button();
            label2 = new Label();
            chkConKinhDoanh = new CheckBox();
            khunganh = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            bttthemanh = new Button();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khunganh).BeginInit();
            SuspendLayout();
            // 
            // numDonGia
            // 
            numDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.Location = new Point(173, 235);
            numDonGia.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numDonGia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 29;
            numDonGia.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.ValueChanged += numDonGia_ValueChanged;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(173, 261);
            numSoLuong.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 28;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(172, 203);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(125, 28);
            cboLoaiSP.TabIndex = 27;
            cboLoaiSP.SelectedIndexChanged += cboLoaiSP_SelectedIndexChanged;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(172, 294);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.TabIndex = 26;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(173, 173);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(125, 27);
            txtTenSP.TabIndex = 25;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(173, 140);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 24;
            // 
            // ngaynhap
            // 
            ngaynhap.AutoSize = true;
            ngaynhap.Location = new Point(85, 299);
            ngaynhap.Name = "ngaynhap";
            ngaynhap.Size = new Size(81, 20);
            ngaynhap.TabIndex = 23;
            ngaynhap.Text = "Ngày nhập";
            // 
            // soluong
            // 
            soluong.AutoSize = true;
            soluong.Location = new Point(85, 267);
            soluong.Name = "soluong";
            soluong.Size = new Size(72, 20);
            soluong.TabIndex = 22;
            soluong.Text = "Số Lượng";
            // 
            // DonGia
            // 
            DonGia.AutoSize = true;
            DonGia.Location = new Point(85, 237);
            DonGia.Name = "DonGia";
            DonGia.Size = new Size(63, 20);
            DonGia.TabIndex = 21;
            DonGia.Text = "Đơn Giá";
            // 
            // LoaiSP
            // 
            LoaiSP.AutoSize = true;
            LoaiSP.Location = new Point(85, 205);
            LoaiSP.Name = "LoaiSP";
            LoaiSP.Size = new Size(57, 20);
            LoaiSP.TabIndex = 20;
            LoaiSP.Text = "Loại SP";
            // 
            // TenSP
            // 
            TenSP.AutoSize = true;
            TenSP.Location = new Point(85, 173);
            TenSP.Name = "TenSP";
            TenSP.Size = new Size(52, 20);
            TenSP.TabIndex = 19;
            TenSP.Text = "Tên SP";
            // 
            // ma
            // 
            ma.AutoSize = true;
            ma.Location = new Point(85, 144);
            ma.Name = "ma";
            ma.Size = new Size(46, 20);
            ma.TabIndex = 18;
            ma.Text = "MãSP";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 33;
            // 
            // bttluu
            // 
            bttluu.Location = new Point(328, 353);
            bttluu.Name = "bttluu";
            bttluu.Size = new Size(94, 29);
            bttluu.TabIndex = 31;
            bttluu.Text = "Lưu";
            bttluu.UseVisualStyleBackColor = true;
            bttluu.Click += button1_Click;
            // 
            // bttthoat
            // 
            bttthoat.Location = new Point(172, 353);
            bttthoat.Name = "bttthoat";
            bttthoat.Size = new Size(94, 29);
            bttthoat.TabIndex = 32;
            bttthoat.Text = "Thoát";
            bttthoat.UseVisualStyleBackColor = true;
            bttthoat.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 95);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 34;
            label2.Text = "THÊM SẢN PHẨM";
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Checked = true;
            chkConKinhDoanh.CheckState = CheckState.Checked;
            chkConKinhDoanh.Location = new Point(172, 327);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(134, 24);
            chkConKinhDoanh.TabIndex = 30;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // khunganh
            // 
            khunganh.Location = new Point(445, 123);
            khunganh.Name = "khunganh";
            khunganh.Size = new Size(295, 228);
            khunganh.SizeMode = PictureBoxSizeMode.StretchImage;
            khunganh.TabIndex = 35;
            khunganh.TabStop = false;
            khunganh.Click += khunganh_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // bttthemanh
            // 
            bttthemanh.Location = new Point(545, 218);
            bttthemanh.Name = "bttthemanh";
            bttthemanh.Size = new Size(94, 29);
            bttthemanh.TabIndex = 36;
            bttthemanh.Text = "Thêm ảnh";
            bttthemanh.UseVisualStyleBackColor = true;
            bttthemanh.Click += themanh_Click;
            // 
            // FormThemSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttthemanh);
            Controls.Add(label2);
            Controls.Add(bttthoat);
            Controls.Add(bttluu);
            Controls.Add(label1);
            Controls.Add(numDonGia);
            Controls.Add(numSoLuong);
            Controls.Add(cboLoaiSP);
            Controls.Add(dtpNgayNhap);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(ngaynhap);
            Controls.Add(soluong);
            Controls.Add(DonGia);
            Controls.Add(LoaiSP);
            Controls.Add(TenSP);
            Controls.Add(ma);
            Controls.Add(chkConKinhDoanh);
            Controls.Add(khunganh);
            Name = "FormThemSanPham";
            Text = "FormThemSanPham";
            Load += FormThemSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)khunganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkConKinhDoanh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboLoaiSP;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label ngaynhap;
        private Label soluong;
        private Label DonGia;
        private Label LoaiSP;
        private Label TenSP;
        private Label ma;
        private Label label1;
        private Button bttluu;
        private Button bttthoat;
        private Label label2;
        private PictureBox khunganh;
        private OpenFileDialog openFileDialog1;
        private Button bttthemanh;
    }
}