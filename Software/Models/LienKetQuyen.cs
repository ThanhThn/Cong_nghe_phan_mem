namespace Software.Models
{
    public class LienKetQuyen
    {
        public int MaChucNang { get; set; }
        public int MaQuyen { get; set; }

        public ChucNang ChucNang { get; set; }
        public Quyen Quyen { get; set; }
    }

}
