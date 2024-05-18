namespace Software.Models
{
    public class Quyen
    {
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }

        public ICollection<LienKetQuyen> LienKetQuyens { get; set; }
        public ICollection<PhanQuyen> PhanQuyens { get; set; }
    }

}
