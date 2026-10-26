using LAB6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Quản_lý_sản_phẩm
{
    public partial class FormThemSanPham : Form
    {
        public FormThemSanPham()
        {
            InitializeComponent();

            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.SelectedIndex = 0;
            numDonGia.ThousandsSeparator = true;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
        string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập mã và tên sản phẩm!");
                return;
            }

            foreach (Product sp in frmproduct.product)
            {
                if (sp.MaSP.Equals(
                    txtMaSP.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!");
                    return;
                }
            }

            Product sanPhamMoi = new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value.Date,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = imagePath
            };

            frmproduct.product.Add(sanPhamMoi);

            MessageBox.Show("Thêm sản phẩm thành công!");

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
        private string imagePath = "";



        private void khunganh_Click(object sender, EventArgs e)
        {
            khunganh.SizeMode = PictureBoxSizeMode.Zoom;
            khunganh.SizeMode = PictureBoxSizeMode.Zoom; khunganh.Dock = DockStyle.Fill;
            khunganh.ImageLocation = @"C:\Images\sanpham.jpg";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void themanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                ShowImage(imagePath);
            }
        }

        private void ShowImage(string filePath)
        {
            try
            {
                khunganh.Image = Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void numDonGia_ValueChanged(object sender, EventArgs e)
        {
            decimal giaTri = numDonGia.Value;
            numDonGia.Text = giaTri.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));


        }

        private void FormThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

