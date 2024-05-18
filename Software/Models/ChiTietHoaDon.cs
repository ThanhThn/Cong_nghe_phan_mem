namespace Software.Models
{
    public class ChiTietHoaDon
    {
        public string MaHD { get; set; }
        public int MaMon { get; set; }
        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }
        public decimal DonGia { get; set; }

        public HoaDon HoaDon { get; set; }
        public ThucDon ThucDon { get; set; }
    }

}
