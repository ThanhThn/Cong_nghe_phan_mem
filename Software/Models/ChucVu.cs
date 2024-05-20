using System.ComponentModel.DataAnnotations;

namespace Software.Models
{
    public class ChucVu
    {
        [Key]
        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public ICollection<NhanVien>? NhanViens { get; set; }
    }

}
