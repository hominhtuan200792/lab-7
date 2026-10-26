using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace lab_7_vle
{
    public partial class frmQLHocSinh : Form
    {
        QLHSDataContext db = new QLHSDataContext();     

        public frmQLHocSinh()
        {
            InitializeComponent();
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            // đặt DisplayMember, ValueMember TRƯỚC khi gán DataSource
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = db.Lops.ToList();

            fillHocSinhByLop();
        }

        // Lấy danh sách học sinh theo lớp đang chọn, tên gần đúng
        private void fillHocSinhByLop()
        {
            if (cboLop.SelectedValue == null)
                return;

            string maLop = cboLop.SelectedValue.ToString();
            string ten = txtTenHS.Text.Trim();

            var dsHocSinh = db.HocSinhs.Where(p => p.MaLop == maLop && p.TenHS.Contains(ten));
            dgvHocSinh.DataSource = dsHocSinh
                .Select(p => new { p.MaHS, p.TenHS, p.Lop.TenLop, p.DTB })
                .ToList();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillHocSinhByLop();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            fillHocSinhByLop();
        }

        // Kiểm tra dữ liệu nhập, dùng chung cho Thêm và Sửa
        private bool KiemTraDuLieu(out float dtb)
        {
            dtb = 0;
            if (txtMaHS.Text.Trim() == "" || txtTenHS.Text.Trim() == "")
            {
                MessageBox.Show("Mã học sinh và tên học sinh không được để trống.");
                return false;
            }
            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Hãy chọn lớp.");
                return false;
            }
            string s = txtDiemTB.Text.Trim().Replace(',', '.');
            if (!float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out dtb)
                || dtb < 0 || dtb > 10)
            {
                MessageBox.Show("Điểm trung bình phải là số từ 0 đến 10.");
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float dtb;
            if (!KiemTraDuLieu(out dtb))
                return;

            string maHS = txtMaHS.Text.Trim();
            if (db.HocSinhs.Any(p => p.MaHS == maHS))
            {
                MessageBox.Show("Mã học sinh này đã tồn tại.");
                return;
            }

            // 1. Tạo đối tượng
            HocSinh hs = new HocSinh
            {
                MaHS = maHS,
                TenHS = txtTenHS.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                DiaChi = txtDiaChi.Text.Trim(),
                MaLop = cboLop.SelectedValue.ToString(),
                DTB = dtb
            };

            try
            {
                // 2. Thêm   3. Cập nhật
                db.HocSinhs.InsertOnSubmit(hs);
                db.SubmitChanges();
                fillHocSinhByLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được: " + ex.Message);
                db = new QLHSDataContext();   // bỏ lệnh thêm đang treo
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float dtb;
            if (!KiemTraDuLieu(out dtb))
                return;

            string maHS = txtMaHS.Text.Trim();

            // 1. Tìm đối tượng cần sửa
            HocSinh hs = db.HocSinhs.SingleOrDefault(p => p.MaHS == maHS);
            if (hs == null)
            {
                MessageBox.Show("Không tìm thấy học sinh có mã " + maHS);
                return;
            }

            try
            {
                // 2. Sửa
                hs.MaLop = cboLop.SelectedValue.ToString();
                hs.TenHS = txtTenHS.Text.Trim();
                hs.NgaySinh = dtpNgaySinh.Value;
                hs.DiaChi = txtDiaChi.Text.Trim();
                hs.DTB = dtb;

                // 3. Cập nhật
                db.SubmitChanges();
                fillHocSinhByLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không sửa được: " + ex.Message);
                db = new QLHSDataContext();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text.Trim();

            // 1. Tìm đối tượng cần xóa
            HocSinh hs = db.HocSinhs.SingleOrDefault(p => p.MaHS == maHS);
            if (hs == null)
            {
                MessageBox.Show("Không tìm thấy học sinh có mã " + maHS);
                return;
            }

            if (MessageBox.Show("Xóa học sinh " + hs.TenHS + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // 2. Xóa   3. Cập nhật
                db.HocSinhs.DeleteOnSubmit(hs);
                db.SubmitChanges();
                fillHocSinhByLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được: " + ex.Message);
                db = new QLHSDataContext();
            }
        }

        // Bấm vào một dòng trong lưới thì đưa dữ liệu lên các ô nhập (PDF không có, nhưng tiện dùng)
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maHS = dgvHocSinh.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
            HocSinh hs = db.HocSinhs.SingleOrDefault(p => p.MaHS == maHS);
            if (hs == null) return;

            txtMaHS.Text = hs.MaHS;
            txtTenHS.Text = hs.TenHS;
            if (hs.NgaySinh.HasValue)
                dtpNgaySinh.Value = hs.NgaySinh.Value;
            txtDiaChi.Text = hs.DiaChi;
            txtDiemTB.Text = hs.DTB.HasValue ? hs.DTB.Value.ToString("0.##") : "";
        }
    }
}