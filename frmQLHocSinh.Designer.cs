namespace lab_7_vle
{
    partial class frmQLHocSinh
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
            txtMaHS = new TextBox();
            cboLop = new ComboBox();
            txtTenHS = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtDiemTB = new TextBox();
            dgvHocSinh = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(210, 37);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(125, 27);
            txtMaHS.TabIndex = 0;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(210, 70);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(151, 28);
            cboLop.TabIndex = 1;
            // 
            // txtTenHS
            // 
            txtTenHS.Location = new Point(210, 104);
            txtTenHS.Name = "txtTenHS";
            txtTenHS.Size = new Size(125, 27);
            txtTenHS.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(154, 135);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(210, 166);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(210, 203);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(125, 27);
            txtDiemTB.TabIndex = 5;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Location = new Point(431, 12);
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocSinh.Size = new Size(357, 426);
            dgvHocSinh.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 40);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 7;
            label1.Text = "mã học sinh";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 73);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 8;
            label2.Text = "lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 107);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 9;
            label3.Text = "tên học sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 142);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 173);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 11;
            label5.Text = "địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 206);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 12;
            label6.Text = "điểm trung bình";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(83, 278);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(83, 336);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(241, 336);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 15;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(241, 278);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmQLHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHocSinh);
            Controls.Add(txtDiemTB);
            Controls.Add(txtDiaChi);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtTenHS);
            Controls.Add(cboLop);
            Controls.Add(txtMaHS);
            Name = "frmQLHocSinh";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHS;
        private ComboBox cboLop;
        private TextBox txtTenHS;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtDiaChi;
        private TextBox txtDiemTB;
        private DataGridView dgvHocSinh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnThem;
        private Button btnSua;
        private Button btnTim;
        private Button btnXoa;
    }
}
