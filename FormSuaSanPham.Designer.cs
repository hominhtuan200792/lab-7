namespace Quản_lý_sản_phẩm
{
    public partial class FormSuaSanPham
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
            components = new System.ComponentModel.Container();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboLoaiSP = new ComboBox();
            chkConKinhDoanh = new CheckBox();
            dtpNgayNhap = new DateTimePicker();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            DonGia = new Label();
            LoaiSP = new Label();
            TenSP = new Label();
            ma = new Label();
            label1 = new Label();
            luu = new Button();
            huy = new Button();
            error = new ErrorProvider(components);
            khunganhsua = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            doianh = new Button();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khunganhsua).BeginInit();
            SuspendLayout();
            // 
            // numDonGia
            // 
            numDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.Location = new Point(195, 216);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 30;
            numDonGia.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(195, 242);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 29;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(194, 184);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(125, 28);
            cboLoaiSP.TabIndex = 28;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Location = new Point(194, 308);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(134, 24);
            chkConKinhDoanh.TabIndex = 27;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(194, 275);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.TabIndex = 26;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(195, 154);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(125, 27);
            txtTenSP.TabIndex = 25;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(195, 121);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 280);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 23;
            label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 248);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 22;
            label5.Text = "Số Lượng";
            // 
            // DonGia
            // 
            DonGia.AutoSize = true;
            DonGia.Location = new Point(107, 218);
            DonGia.Name = "DonGia";
            DonGia.Size = new Size(63, 20);
            DonGia.TabIndex = 21;
            DonGia.Text = "Đơn Giá";
            // 
            // LoaiSP
            // 
            LoaiSP.AutoSize = true;
            LoaiSP.Location = new Point(107, 186);
            LoaiSP.Name = "LoaiSP";
            LoaiSP.Size = new Size(57, 20);
            LoaiSP.TabIndex = 20;
            LoaiSP.Text = "Loại SP";
            // 
            // TenSP
            // 
            TenSP.AutoSize = true;
            TenSP.Location = new Point(107, 154);
            TenSP.Name = "TenSP";
            TenSP.Size = new Size(52, 20);
            TenSP.TabIndex = 19;
            TenSP.Text = "Tên SP";
            // 
            // ma
            // 
            ma.AutoSize = true;
            ma.Location = new Point(107, 125);
            ma.Name = "ma";
            ma.Size = new Size(46, 20);
            ma.TabIndex = 18;
            ma.Text = "MãSP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 88);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 31;
            label1.Text = "Sửa sản phẩm";
            // 
            // luu
            // 
            luu.Location = new Point(438, 373);
            luu.Name = "luu";
            luu.Size = new Size(94, 29);
            luu.TabIndex = 32;
            luu.Text = "Lưu";
            luu.UseVisualStyleBackColor = true;
            luu.Click += luu_Click;
            // 
            // huy
            // 
            huy.Location = new Point(234, 373);
            huy.Name = "huy";
            huy.Size = new Size(94, 29);
            huy.TabIndex = 33;
            huy.Text = "Hủy";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click_1;
            // 
            // error
            // 
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            error.ContainerControl = this;
            // 
            // khunganhsua
            // 
            khunganhsua.Location = new Point(476, 121);
            khunganhsua.Name = "khunganhsua";
            khunganhsua.Size = new Size(246, 187);
            khunganhsua.SizeMode = PictureBoxSizeMode.StretchImage;
            khunganhsua.TabIndex = 34;
            khunganhsua.TabStop = false;
            khunganhsua.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // doianh
            // 
            doianh.Location = new Point(553, 314);
            doianh.Name = "doianh";
            doianh.Size = new Size(94, 29);
            doianh.TabIndex = 35;
            doianh.Text = "Đổi ảnh";
            doianh.UseVisualStyleBackColor = true;
            doianh.Click += doianh_Click;
            // 
            // FormSuaSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(doianh);
            Controls.Add(khunganhsua);
            Controls.Add(huy);
            Controls.Add(luu);
            Controls.Add(label1);
            Controls.Add(numDonGia);
            Controls.Add(numSoLuong);
            Controls.Add(cboLoaiSP);
            Controls.Add(chkConKinhDoanh);
            Controls.Add(dtpNgayNhap);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DonGia);
            Controls.Add(LoaiSP);
            Controls.Add(TenSP);
            Controls.Add(ma);
            Name = "FormSuaSanPham";
            Text = "Sửa sản phẩm";
            Load += FormSuaSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ((System.ComponentModel.ISupportInitialize)khunganhsua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboLoaiSP;
        private CheckBox chkConKinhDoanh;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label6;
        private Label label5;
        private Label DonGia;
        private Label LoaiSP;
        private Label TenSP;
        private Label ma;
        private Label label1;
        private Button luu;
        private Button huy;
        private ErrorProvider error;
        private PictureBox khunganhsua;
        private OpenFileDialog openFileDialog1;
        private Button doianh;
    }
}