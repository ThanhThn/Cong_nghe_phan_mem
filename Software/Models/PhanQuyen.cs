namespace Software.Models
{
    public class PhanQuyen
    {
        public int MaQuyen { get; set; }
        public int MaTK { get; set; }

        public Quyen Quyen { get; set; }
        public TaiKhoanNhanVien TaiKhoanNhanVien { get; set; }
    }

}
