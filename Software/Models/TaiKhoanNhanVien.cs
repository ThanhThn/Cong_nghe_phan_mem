namespace Software.Models
{
    public class TaiKhoanNhanVien
    {
        public int MaTK { get; set; }
        public string TenTK { get; set; }
        public string MaKhau { get; set; }
        public string MaNV { get; set; }

        public NhanVien NhanVien { get; set; }
        public ICollection<PhanQuyen> PhanQuyens { get; set; }
    }


}
