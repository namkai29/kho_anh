using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLTH.Api.Models.Entities
{
    public class DanhMuc
    {
        [Key]
        public int DanhmucID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string TenDanhMuc { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string? MoTa { get; set; }

        //Collect Navigation (Khong tạo ra PK)
        //vì 1 category có nhiều product lên tạo được list cả Products
        public virtual List<SanPham> SanPhams { get; set; }

    }

}