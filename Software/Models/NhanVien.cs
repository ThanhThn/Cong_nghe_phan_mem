namespace Software.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNhanVien { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string ChungMinhThu { get; set; }
        public int MaChucVu { get; set; }

        public ChucVu ChucVu { get; set; }

        public TaiKhoanNhanVien TaiKhoanNhanVien { get; set; }
    }



}
