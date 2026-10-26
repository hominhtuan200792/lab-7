using LAB6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quản_lý_sản_phẩm
{
    public partial class FormSuaSanPham : Form
    {
        private Product sanPhamCanSua;

        public FormSuaSanPham()
        {
            InitializeComponent();
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.SelectedIndex = 0;

            numDonGia.Minimum = 1000;
            numDonGia.Maximum = 1000000000;
            numDonGia.Increment = 1000;
            numDonGia.ThousandsSeparator = true;
            dtpNgayNhap.MaxDate = DateTime.Today;
        }

        public FormSuaSanPham(Product sp) : this()
        {
            if (sp == null) throw new ArgumentNullException(nameof(sp));
            sanPhamCanSua = sp;

            txtMaSP.Text = sp.MaSP;
            txtMaSP.Enabled = false;
            txtTenSP.Text = sp.TenSP;
            cboLoaiSP.Text = sp.LoaiSP;
            numDonGia.Value = Math.Min(
                numDonGia.Maximum,
                Math.Max(numDonGia.Minimum, sp.DonGia));

            numSoLuong.Value = Math.Min(
                numSoLuong.Maximum,
                Math.Max(numSoLuong.Minimum, sp.SoLuong));

            dtpNgayNhap.Value = sp.NgayNhap;
            chkConKinhDoanh.Checked = sp.ConKinhDoanh;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                return;
            }

            if (sanPhamCanSua == null)
            {
                MessageBox.Show("Không có sản phẩm để cập nhật.");
                return;
            }
            sanPhamCanSua.TenSP = txtTenSP.Text.Trim();
            sanPhamCanSua.LoaiSP = cboLoaiSP.Text;
            sanPhamCanSua.DonGia = numDonGia.Value;
            sanPhamCanSua.SoLuong = (int)numSoLuong.Value;
            sanPhamCanSua.NgayNhap = dtpNgayNhap.Value.Date;
            sanPhamCanSua.ConKinhDoanh = chkConKinhDoanh.Checked;

            MessageBox.Show("Cập nhật sản phẩm thành công!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool ValidateInput()
        {
            error.Clear();
            bool ok = true;

            string ma = txtMaSP.Text.Trim();
            if (ma == "")
            {
                error.SetError(txtMaSP, "Mã sản phẩm không được rỗng");
                ok = false;
            }
            if (txtTenSP.Text.Trim() == "")
            {
                error.SetError(txtTenSP, "Tên sản phẩm không được rỗng");
                ok = false;
            }

            if (cboLoaiSP.SelectedIndex < 0)
            {
                error.SetError(cboLoaiSP, "Vui lòng chọn loại sản phẩm");
                ok = false;
            }

            if (numDonGia.Value <= 0)
            {
                error.SetError(numDonGia, "Đơn giá phải lớn hơn 0");
                ok = false;
            }

            if (numSoLuong.Value < 0)
            {
                error.SetError(numSoLuong, "Số lượng phải lớn hơn hoặc bằng 0");
                ok = false;
            }

            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                error.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại");
                ok = false;
            }

            return ok;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            khunganhsua.SizeMode = PictureBoxSizeMode.Zoom;
            khunganhsua.SizeMode = PictureBoxSizeMode.Zoom; khunganhsua.Dock = DockStyle.Fill;
            khunganhsua.ImageLocation = @"C:\Images\sanpham.jpg";
        }

        private void doianh_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Chọn ảnh sản phẩm";
                openFile.Filter = "File ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    sanPhamCanSua.DuongDanAnh = openFile.FileName;
                }
            }
        }

        private void huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuaSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}

