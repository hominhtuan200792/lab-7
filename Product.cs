using System;
using System.Collections.Generic;
using System.Text;

namespace Quản_lý_sản_phẩm
{
    public class Product
    {
        public string MaSP { get; set; } = "";
        public string TenSP { get; set; } = "";
        public string LoaiSP { get; set; } = "";
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool ConKinhDoanh { get; set; }
        public string DuongDanAnh { get; set; } = "";
    }
}
