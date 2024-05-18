namespace Software.Models
{
    public class ChucNang
    {
        public int MaChucNang { get; set; }
        public string DuongDanChucNang { get; set; }

        public ICollection<LienKetQuyen> LienKetQuyens { get; set; }
    }

}
