using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Software.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNhanVien { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string ChungMinhThu { get; set; }
        public int MaChucVu { get; set; }

        [ForeignKey("MaChucVu")]
        public ChucVu? ChucVu { get; set; }

        public TaiKhoanNhanVien? TaiKhoan{ get; set; }
    }



}
