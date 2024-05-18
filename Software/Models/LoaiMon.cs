namespace Software.Models
{
    public class LoaiMon
    {
        public int MaLoaiMon { get; set; }
        public string TenLoaiMon { get; set; }

        public ICollection<ThucDon> ThucDons { get; set; }
    }

}
