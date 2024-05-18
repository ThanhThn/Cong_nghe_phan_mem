namespace Software.Models
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public DateTime ThoiGian { get; set; }
        public decimal TongTien { get; set; }
        public string MaMT { get; set; }

        public MayTinh MayTinh { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

}
