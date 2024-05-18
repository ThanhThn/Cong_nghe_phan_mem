namespace Software.Models
{
    public class ThucDon
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public decimal DonGia { get; set; }
        public byte[] AnhMon { get; set; }
        public bool TinhTrang { get; set; }
        public int MaLoaiMon { get; set; }

        public LoaiMon LoaiMon { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

}
