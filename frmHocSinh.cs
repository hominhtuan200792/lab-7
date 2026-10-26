using Microsoft.Data.SqlClient;
using System.Globalization;

namespace lab 7 vle
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object? sender, EventArgs e)
        {
            try
            {
                loadLop();
                loadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL:\n" + ex.Message);
            }
        }

        // Đổ danh sách mã lớp vào combobox
        void loadLop()
        {
            cboMaLop.Items.Clear();
            using (SqlConnection con = new SqlConnection(KetNoi.Chuoi))
            using (SqlCommand cmd = new SqlCommand("SELECT MaLop FROM Lop", con))
            {
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        cboMaLop.Items.Add(dr.GetString(0));
                }
            }
        }

        // Hiển thị danh sách học sinh
        void loadDanhSach()
        {
            lvHocSinh.Items.Clear();
            using (SqlConnection con = new SqlConnection(KetNoi.Chuoi))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop FROM HocSinh", con))
            {
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string ma = dr.GetString(0);
                        ListViewItem lvi = new ListViewItem(ma);
                        lvi.Tag = ma;
                        lvi.SubItems.Add(dr.GetString(1));
                        lvi.SubItems.Add(dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy"));
                        lvi.SubItems.Add(dr.IsDBNull(3) ? "" : dr.GetString(3));
                        lvi.SubItems.Add(dr.IsDBNull(4) ? "" : dr.GetFloat(4).ToString("0.##", CultureInfo.InvariantCulture));
                        lvi.SubItems.Add(dr.IsDBNull(5) ? "" : dr.GetString(5));
                        lvHocSinh.Items.Add(lvi);
                    }
                }
            }
        }

        // Chọn một dòng thì đưa dữ liệu xuống các ô nhập
        private void lvHocSinh_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;
            txtMaHS.Text = e.Item.Text;
            txtTenHS.Text = e.Item.SubItems[1].Text;
            if (DateTime.TryParseExact(e.Item.SubItems[2].Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ns))
                dtpNgaySinh.Value = ns;
            txtDiaChi.Text = e.Item.SubItems[3].Text;
            txtDTB.Text = e.Item.SubItems[4].Text;
            cboMaLop.Text = e.Item.SubItems[5].Text;
        }

        // Đọc các ô nhập thành tham số SQL, trả về null nếu dữ liệu sai
        SqlParameter[]? TaoThamSo(string maHS)
        {
            string ten = txtTenHS.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Tên học sinh không được để trống.");
                return null;
            }

            object dtb = DBNull.Value;
            string s = txtDTB.Text.Trim().Replace(',', '.');
            if (s != "")
            {
                if (!float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out float d)
                    || d < 0 || d > 10)
                {
                    MessageBox.Show("ĐTB phải là số từ 0 đến 10.");
                    return null;
                }
                dtb = d;
            }

            string diaChi = txtDiaChi.Text.Trim();
            return new SqlParameter[]
            {
                new SqlParameter("@MaHS", maHS),
                new SqlParameter("@TenHS", ten),
                new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
                new SqlParameter("@DiaChi", diaChi == "" ? DBNull.Value : diaChi),
                new SqlParameter("@DTB", dtb),
                new SqlParameter("@MaLop", cboMaLop.Text == "" ? DBNull.Value : cboMaLop.Text)
            };
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string maHS = txtMaHS.Text.Trim();
            if (maHS == "")
            {
                MessageBox.Show("Mã học sinh không được để trống.");
                return;
            }
            SqlParameter[]? ps = TaoThamSo(maHS);
            if (ps == null) return;

            try
            {
                KetNoi.ChayLenh(
                    "INSERT INTO HocSinh(MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) " +
                    "VALUES (@MaHS, @TenHS, @NgaySinh, @DiaChi, @DTB, @MaLop)", ps);
                loadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(KetNoi.ThongBaoLoi(ex));
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (lvHocSinh.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một học sinh để sửa.");
                return;
            }
            string maHS = lvHocSinh.SelectedItems[0].Tag!.ToString()!;
            SqlParameter[]? ps = TaoThamSo(maHS);
            if (ps == null) return;

            try
            {
                KetNoi.ChayLenh(
                    "UPDATE HocSinh SET TenHS = @TenHS, NgaySinh = @NgaySinh, DiaChi = @DiaChi, " +
                    "DTB = @DTB, MaLop = @MaLop WHERE MaHS = @MaHS", ps);
                loadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(KetNoi.ThongBaoLoi(ex));
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (lvHocSinh.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một học sinh để xóa.");
                return;
            }
            string maHS = lvHocSinh.SelectedItems[0].Tag!.ToString()!;

            if (MessageBox.Show("Xóa học sinh " + maHS + "?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                KetNoi.ChayLenh("DELETE FROM HocSinh WHERE MaHS = @MaHS",
                                new SqlParameter("@MaHS", maHS));
                loadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(KetNoi.ThongBaoLoi(ex));
            }
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}