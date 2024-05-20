using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Software.Models
{
    public class TaiKhoanNhanVien
    {
        [Key]
        public int MaTK { get; set; }
        public string TenTK { get; set; }
        public string MaKhau { get; set; }
        public string MaNV { get; set; }
        public NhanVien? NhanVien { get; set; }
        public ICollection<PhanQuyen>? PhanQuyens { get; set; }
    }



}
