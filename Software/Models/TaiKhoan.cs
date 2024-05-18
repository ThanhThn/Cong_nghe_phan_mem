namespace Software.Models
{
    public class TaiKhoan
    {
        public int MaTK { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public decimal SoDu { get; set; }
        public int MaKH { get; set; }

        public KhachHang KhachHang { get; set; }
    }

}
