using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLTH.Api.Models.Entities
{
    public class KhachHang
    {
        [Key]
        public int KhachHangID { get; set; }

        [Required]
        [StringLength(255)]
        [Column("TenKhachHang", TypeName = "nvarchar(255)")]
        public string HoTen { get; set; } = null!; // Thêm null-forgiving operator

        [StringLength(100)]
        public string? TenLienHe { get; set; }

        [StringLength(255)]
        public string? DiaChi { get; set; }

        [StringLength(100)]
        public string? ThanhPho { get; set; }

        // ---------------------------------------------------------------------
        // ✅ THAY THẾ: Thêm thuộc tính điều hướng đến Đơn Hàng (One-to-Many)
        // Một khách hàng có thể có nhiều đơn hàng
        public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
        // ---------------------------------------------------------------------

        // ❌ Loại bỏ: DanhMucId và CungCapId vì chúng không hợp lý trong mô hình này.
    }

}