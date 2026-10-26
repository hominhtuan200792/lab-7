using Quản_lý_sản_phẩm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
namespace LAB6
{
    public partial class frmproduct : Form
    {
        internal static List<Product> product = new List<Product>();
        // Use a BindingSource to avoid CurrencyManager position issues
        private BindingSource productBinding = new BindingSource();

        public frmproduct()
        {
            InitializeComponent();

            if (txtTimKiem != null)
                txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.SelectedIndex = 0;

            numDonGia.DecimalPlaces = 0;
            numDonGia.ThousandsSeparator = true;

            numDonGia.Minimum = 1000;
            numDonGia.Maximum = 100000000;
            numDonGia.Increment = 1000;

            numSoLuong.Minimum = 1;
            numSoLuong.Maximum = 100000;

            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.MaxDate = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            productBinding.DataSource = product;
            danhsachsanpham.DataSource = productBinding;
            hangcon.Text = "Số lượng sản phẩm: " + product.Count;

            khunganh.SizeMode = PictureBoxSizeMode.Zoom;
            khunganh.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private Product GetSelectedProduct()
        {
            if (danhsachsanpham.CurrentRow == null) return null;
            return danhsachsanpham.CurrentRow.DataBoundItem as Product;
        }


        private void LoadProductToForm(Product p)
        {
            txtMaSP.Text = p.MaSP;
            txtTenSP.Text = p.TenSP;
            cboLoaiSP.SelectedItem = p.LoaiSP;
            var date = p.NgayNhap;
            if (date < dtpNgayNhap.MinDate) date = dtpNgayNhap.MinDate;
            else if (date > dtpNgayNhap.MaxDate) date = dtpNgayNhap.MaxDate;
            dtpNgayNhap.Value = date;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;
            errorProvider1.Clear();
            ShowImage(p.DuongDanAnh);
        }

        private void ShowImage(string path)
        {
            khunganh.Image = null;
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return;
            try
            {

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var tmp = Image.FromStream(fs))
                {
                    khunganh.Image = new Bitmap(tmp);
                }
            }
            catch { khunganh.Image = null; }
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = 1;
            numDonGia.Value = 100000;
            numSoLuong.Value = 1;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            khunganh.Image = null;
            errorProvider1.Clear();
            txtMaSP.Focus();
        }

        private void LoadSanPham()
        {
            ApplyFilter(txtTimKiem?.Text ?? string.Empty);
            CapNhatSoLuong();
        }

        private void ApplyFilter(string q)
        {
            List<Product> data;
            if (string.IsNullOrWhiteSpace(q))
            {
                data = product;
            }
            else
            {
                data = product.Where(p =>
                    (!string.IsNullOrEmpty(p.MaSP) && p.MaSP.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(p.TenSP) && p.TenSP.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(p.LoaiSP) && p.LoaiSP.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0)
                ).ToList();
            }

            // Use BindingSource to update the DataGridView safely
            productBinding.DataSource = null;
            productBinding.DataSource = data;
            danhsachsanpham.ClearSelection();


            if (string.IsNullOrWhiteSpace(q))
            {
                hangcon.Text = $"Hiển thị: {data.Count} sản phẩm";
            }
            else
            {
                hangcon.Text = $"🔍 Tìm thấy {data.Count} sản phẩm khớp với '{q}'";
            }
        }

        private void LamMoi()
        {
            if (txtTimKiem != null) txtTimKiem.Text = string.Empty;
            ClearInput();
            productBinding.DataSource = null;
            productBinding.DataSource = product;
            danhsachsanpham.ClearSelection();
            CapNhatSoLuong();
            hangcon.Text = $"✓ Đã làm mới | Tổng sản phẩm: {product.Count}";
        }

        private void XoaSanPham()
        {
            Product sp = GetSelectedProduct();
            if (sp == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm: " + sp.TenSP + " không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                product.Remove(sp);
                ClearInput();
                LoadSanPham();
                MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                hangcon.Text = $"✓ Đã xóa sản phẩm: {sp.TenSP} | Tổng sản phẩm: {product.Count}";
            }
        }

        private void SuaSanPham()
        {
            Product p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!");
                return;
            }
            using (FormSuaSanPham frm = new FormSuaSanPham(p))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadSanPham();
                    hangcon.Text = $"✓ Đã cập nhật sản phẩm: {p.TenSP}";
                }
            }
        }

        private void danhsachsanpham_SelectionChanged(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p != null)
            {
                LoadProductToForm(p);
                hangcon.Text = $"► Đang chọn: {p.MaSP} - {p.TenSP}";
            }
        }

        private void danhsachsanpham_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                danhsachsanpham.ClearSelection();
                danhsachsanpham.Rows[e.RowIndex].Selected = true;
            }
        }

        private void danhsachsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void danhsachsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Product p = danhsachsanpham.Rows[e.RowIndex].DataBoundItem as Product;
            if (p != null) LoadProductToForm(p);
        }

        private void cmsSua_Click(object sender, EventArgs e) { SuaSanPham(); }
        private void cmsXoa_Click(object sender, EventArgs e) { XoaSanPham(); }

        private void cmsXemChiTiet_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!");
                return;
            }
            MessageBox.Show(
                "Mã SP: " + p.MaSP + "\nTên SP: " + p.TenSP + "\nLoại: " + p.LoaiSP +
                "\nĐơn giá: " + p.DonGia.ToString("N0") + " VNĐ\nSố lượng: " + p.SoLuong +
                "\nNgày nhập: " + p.NgayNhap.ToShortDateString() +
                "\nTrạng thái: " + (p.ConKinhDoanh ? "Còn kinh doanh" : "Ngừng kinh doanh"),
                "Chi tiết sản phẩm");
        }


        private void Them_Click(object sender, EventArgs e)
        {
            using (FormThemSanPham frm = new FormThemSanPham())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadSanPham();
                    hangcon.Text = $"✓ Đã thêm sản phẩm thành công | Tổng sản phẩm: {product.Count}";
                }
            }
        }

        private void sua_Click(object sender, EventArgs e) { SuaSanPham(); }
        private void xoa_Click(object sender, EventArgs e) { XoaSanPham(); }

        private void lammoi_Click(object sender, EventArgs e) { LamMoi(); }
        private void tsbLamMoi_Click(object sender, EventArgs e) { LamMoi(); }
        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e) { LamMoi(); }

        private void Timkiem_Click(object sender, EventArgs e)
        {
            ApplyFilter(txtTimKiem?.Text ?? string.Empty);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(txtTimKiem.Text);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trước khi thêm ảnh!");
                return;
            }
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Chọn ảnh sản phẩm";
                openFile.Filter = "File ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    p.DuongDanAnh = openFile.FileName;
                    ShowImage(p.DuongDanAnh);
                }
            }
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void thongtinsanpham_Enter(object sender, EventArgs e) { }
        private void numDonGia_ValueChanged(object sender, EventArgs e)
        {
            decimal giaTri = 100000;
            numDonGia.Text = giaTri.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            numDonGia.Maximum = decimal.MaxValue;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            khunganh.SizeMode = PictureBoxSizeMode.Zoom;
            khunganh.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void MoLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở liên kết: " + ex.Message);
            }
        }
        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
        "Bấm Yes để mở Facebook, No để mở Zalo.",
        "Liên hệ tác giả",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
                MoLink("https://www.facebook.com/ran.la.1217/");
            else if (kq == DialogResult.No)
                MoLink("https://zalo.me/0398246072");
        }
        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool ok = true;

            string ma = txtMaSP.Text.Trim();
            if (ma == "")
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không được rỗng");
                ok = false;
            }
            else if (frmproduct.product.Any(p => p.MaSP.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại");
                ok = false;
            }

            if (txtTenSP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được rỗng");
                ok = false;
            }

            if (cboLoaiSP.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboLoaiSP, "Vui lòng chọn loại sản phẩm");
                ok = false;
            }

            if (numDonGia.Value <= 0)
            {
                errorProvider1.SetError(numDonGia, "Đơn giá phải lớn hơn 0");
                ok = false;
            }

            if (numSoLuong.Value < 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng phải lớn hơn hoặc bằng 0");
                ok = false;
            }

            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại");
                ok = false;
            }

            return ok;
        }

        private void hangcon_Click(object sender, EventArgs e)
        {

            CapNhatSoLuong();
        }
        private void CapNhatSoLuong()
        {
            int soLuong = product.Count;
            hangcon.Text = $"Số lượng sản phẩm: {soLuong}";
        }

        private void trangthai_Click(object sender, EventArgs e)
        {

        }


        private void HienThiThongBao(string thongBao)
        {
            trangthai.Text = thongBao;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            HienThiThongBao("Đã thêm sản phẩm thành công!");
        }

        private void donHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}