namespace LAB6
{
    partial class frmproduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproduct));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            làmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            donHangToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            Them = new ToolStripButton();
            sua = new ToolStripButton();
            xoa = new ToolStripButton();
            lammoi = new ToolStripButton();
            txtTimKiem = new ToolStripTextBox();
            timkiem = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            trangthai = new ToolStripStatusLabel();
            hangcon = new ToolStripStatusLabel();
            thongtinsanpham = new GroupBox();
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
            danhsachsanpham = new DataGridView();
            chitietsp = new ContextMenuStrip(components);
            sửaToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            xemChiTiếtToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            khunganh = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            thongtinsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhsachsanpham).BeginInit();
            chitietsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khunganh).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, quảnLýToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1054, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { làmMớiToolStripMenuItem, thoátToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // làmMớiToolStripMenuItem
            // 
            làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            làmMớiToolStripMenuItem.Size = new Size(150, 26);
            làmMớiToolStripMenuItem.Text = "Làm mới";
            làmMớiToolStripMenuItem.Click += làmMớiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(150, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { donHangToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(75, 24);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // donHangToolStripMenuItem
            // 
            donHangToolStripMenuItem.Name = "donHangToolStripMenuItem";
            donHangToolStripMenuItem.Size = new Size(157, 26);
            donHangToolStripMenuItem.Text = "Đơn hàng";
            donHangToolStripMenuItem.Click += donHangToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giớiThiệuToolStripMenuItem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(79, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(139, 26);
            giớiThiệuToolStripMenuItem.Text = "Liên hệ";
            giớiThiệuToolStripMenuItem.Click += giớiThiệuToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Them, sua, xoa, lammoi, txtTimKiem, timkiem });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Margin = new Padding(1);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1054, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // Them
            // 
            Them.AutoSize = false;
            Them.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Them.Font = new Font("Segoe UI", 20F);
            Them.Image = (Image)resources.GetObject("Them.Image");
            Them.ImageTransparentColor = Color.Magenta;
            Them.Name = "Them";
            Them.Size = new Size(29, 24);
            Them.Text = "Thêm";
            Them.Click += Them_Click;
            // 
            // sua
            // 
            sua.DisplayStyle = ToolStripItemDisplayStyle.Image;
            sua.Image = (Image)resources.GetObject("sua.Image");
            sua.ImageTransparentColor = Color.Magenta;
            sua.Name = "sua";
            sua.Size = new Size(29, 24);
            sua.Text = "toolStripButton1";
            sua.ToolTipText = "sửa";
            sua.Click += sua_Click;
            // 
            // xoa
            // 
            xoa.AutoSize = false;
            xoa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            xoa.Image = (Image)resources.GetObject("xoa.Image");
            xoa.ImageTransparentColor = Color.Magenta;
            xoa.Name = "xoa";
            xoa.Size = new Size(29, 24);
            xoa.Text = "toolStripButton1";
            xoa.ToolTipText = "xóa";
            xoa.Click += xoa_Click;
            // 
            // lammoi
            // 
            lammoi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            lammoi.Image = (Image)resources.GetObject("lammoi.Image");
            lammoi.ImageTransparentColor = Color.Magenta;
            lammoi.Name = "lammoi";
            lammoi.Size = new Size(29, 24);
            lammoi.Text = "Làm mới";
            lammoi.Click += lammoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoSize = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 27);
            // 
            // timkiem
            // 
            timkiem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            timkiem.Image = (Image)resources.GetObject("timkiem.Image");
            timkiem.ImageTransparentColor = Color.Magenta;
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(29, 24);
            timkiem.Text = "toolStripButton1";
            timkiem.ToolTipText = "tìm kiếm";
            timkiem.Click += Timkiem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { trangthai, hangcon });
            statusStrip1.Location = new Point(0, 598);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1054, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // trangthai
            // 
            trangthai.Name = "trangthai";
            trangthai.Size = new Size(133, 20);
            trangthai.Text = "Trạng thái thao tác";
            trangthai.Click += trangthai_Click;
            // 
            // hangcon
            // 
            hangcon.Name = "hangcon";
            hangcon.Size = new Size(132, 20);
            hangcon.Text = "số lượng hàng còn";
            hangcon.Click += hangcon_Click;
            // 
            // thongtinsanpham
            // 
            thongtinsanpham.Controls.Add(numDonGia);
            thongtinsanpham.Controls.Add(numSoLuong);
            thongtinsanpham.Controls.Add(cboLoaiSP);
            thongtinsanpham.Controls.Add(chkConKinhDoanh);
            thongtinsanpham.Controls.Add(dtpNgayNhap);
            thongtinsanpham.Controls.Add(txtTenSP);
            thongtinsanpham.Controls.Add(txtMaSP);
            thongtinsanpham.Controls.Add(label6);
            thongtinsanpham.Controls.Add(label5);
            thongtinsanpham.Controls.Add(DonGia);
            thongtinsanpham.Controls.Add(LoaiSP);
            thongtinsanpham.Controls.Add(TenSP);
            thongtinsanpham.Controls.Add(ma);
            thongtinsanpham.Location = new Point(12, 68);
            thongtinsanpham.Name = "thongtinsanpham";
            thongtinsanpham.Size = new Size(423, 246);
            thongtinsanpham.TabIndex = 3;
            thongtinsanpham.TabStop = false;
            thongtinsanpham.Text = "Thông Tin Sản Phẩm";
            thongtinsanpham.Enter += thongtinsanpham_Enter;
            // 
            // numDonGia
            // 
            numDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.Location = new Point(113, 126);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 17;
            numDonGia.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            numDonGia.ValueChanged += numDonGia_ValueChanged;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(113, 152);
            numSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 16;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(112, 94);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(125, 28);
            cboLoaiSP.TabIndex = 15;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Location = new Point(112, 218);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(134, 24);
            chkConKinhDoanh.TabIndex = 14;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(112, 185);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.TabIndex = 13;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(113, 64);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(125, 27);
            txtTenSP.TabIndex = 11;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(113, 31);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 190);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 158);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Số Lượng";
            // 
            // DonGia
            // 
            DonGia.AutoSize = true;
            DonGia.Location = new Point(25, 128);
            DonGia.Name = "DonGia";
            DonGia.Size = new Size(63, 20);
            DonGia.TabIndex = 3;
            DonGia.Text = "Đơn Giá";
            // 
            // LoaiSP
            // 
            LoaiSP.AutoSize = true;
            LoaiSP.Location = new Point(25, 96);
            LoaiSP.Name = "LoaiSP";
            LoaiSP.Size = new Size(57, 20);
            LoaiSP.TabIndex = 2;
            LoaiSP.Text = "Loại SP";
            // 
            // TenSP
            // 
            TenSP.AutoSize = true;
            TenSP.Location = new Point(25, 64);
            TenSP.Name = "TenSP";
            TenSP.Size = new Size(52, 20);
            TenSP.TabIndex = 1;
            TenSP.Text = "Tên SP";
            // 
            // ma
            // 
            ma.AutoSize = true;
            ma.Location = new Point(25, 35);
            ma.Name = "ma";
            ma.Size = new Size(50, 20);
            ma.TabIndex = 0;
            ma.Text = "Mã SP";
            // 
            // danhsachsanpham
            // 
            danhsachsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhsachsanpham.Location = new Point(12, 320);
            danhsachsanpham.Name = "danhsachsanpham";
            danhsachsanpham.ReadOnly = true;
            danhsachsanpham.RowHeadersWidth = 51;
            danhsachsanpham.Size = new Size(1030, 275);
            danhsachsanpham.TabIndex = 4;
            danhsachsanpham.CellContentClick += danhsachsanpham_CellContentClick;
            danhsachsanpham.SelectionChanged += danhsachsanpham_SelectionChanged;
            // 
            // chitietsp
            // 
            chitietsp.ImageScalingSize = new Size(20, 20);
            chitietsp.Items.AddRange(new ToolStripItem[] { sửaToolStripMenuItem, xóaToolStripMenuItem, xemChiTiếtToolStripMenuItem });
            chitietsp.Name = "chitietsp";
            chitietsp.Size = new Size(163, 76);
            chitietsp.Text = "Chi Tiết Sản Phẩm";
            // 
            // sửaToolStripMenuItem
            // 
            sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            sửaToolStripMenuItem.Size = new Size(162, 24);
            sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(162, 24);
            xóaToolStripMenuItem.Text = "Xóa";
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            xemChiTiếtToolStripMenuItem.Size = new Size(162, 24);
            xemChiTiếtToolStripMenuItem.Text = "Xem Chi Tiết";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // khunganh
            // 
            khunganh.Location = new Point(480, 14);
            khunganh.Name = "khunganh";
            khunganh.Size = new Size(400, 300);
            khunganh.SizeMode = PictureBoxSizeMode.StretchImage;
            khunganh.TabIndex = 8;
            khunganh.TabStop = false;
            khunganh.Click += pictureBox2_Click;
            // 
            // frmproduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 624);
            Controls.Add(danhsachsanpham);
            Controls.Add(thongtinsanpham);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(khunganh);
            MainMenuStrip = menuStrip1;
            Name = "frmproduct";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            thongtinsanpham.ResumeLayout(false);
            thongtinsanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhsachsanpham).EndInit();
            chitietsp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)khunganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton Them;
        private ToolStripButton sua;
        private ToolStripButton xoa;
        private ToolStripButton lammoi;
        private ToolStripButton timkiem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel trangthai;
        private ToolStripStatusLabel hangcon;
        private GroupBox thongtinsanpham;
        private DataGridView danhsachsanpham;
        private ContextMenuStrip chitietsp;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem làmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private TextBox txtTenSP;
       
        private TextBox txtMaSP;
        private Label label6;
        private Label label5;
        private Label DonGia;
        private Label LoaiSP;
        private Label TenSP;
        private Label ma;
        private DateTimePicker dtpNgayNhap;
        private CheckBox chkConKinhDoanh;
        private ErrorProvider errorProvider1;
        private NumericUpDown numSoLuong;
        private ComboBox cboLoaiSP;
        private NumericUpDown numDonGia;
        private ToolStripMenuItem donHangToolStripMenuItem;
        private ToolStripTextBox txtTimKiem;
        public PictureBox khunganh;
    }
}
