using System.ComponentModel.DataAnnotations;

namespace Software.Models
{
    public class Quyen
    {
        [Key]
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }

        public ICollection<LienKetQuyen>? LienKetQuyens { get; set; }
        public ICollection<PhanQuyen>? PhanQuyens { get; set; }
    }

}
