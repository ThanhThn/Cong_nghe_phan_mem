namespace Software.Models
{
    public class KhachHang
    {
        public int MaKH { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDT { get; set; }

        public ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
