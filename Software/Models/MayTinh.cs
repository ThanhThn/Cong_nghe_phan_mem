namespace Software.Models
{
    public class MayTinh
    {
        public string MaMT { get; set; }
        public int TinhTrang { get; set; }

        public ICollection<HoaDon> HoaDons { get; set; }
    }

}
