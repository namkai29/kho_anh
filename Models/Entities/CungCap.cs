using System.ComponentModel.DataAnnotations;

namespace BTLTH.Api.Models.Entities
{
    public class CungCap
    {
        [Key]
        public int CungCapId { get; set; } // Quy ước đặt tên C# là PascalCase (CungCapID -> CungCapId)


        [Required]
        [StringLength(255)] // Nên giới hạn độ dài
        public string TenDayDu { get; set; } = null!;

        // 3. Tên liên hệ (Cho phép NULL)
        [StringLength(100)]
        public string? TenLienHe { get; set; } // Quy ước PascalCase

        // 4. Địa chỉ, Thành phố, Quốc gia (Cho phép NULL)
        [StringLength(255)]
        public string? DiaChi { get; set; } // Quy ước PascalCase

        [StringLength(100)]
        public string? ThanhPho { get; set; } // Quy ước PascalCase

        [StringLength(100)]
        public string? QuocGia { get; set; } // Quy ước PascalCase

        // 5. Số điện thoại (Dienthoai)
        [Required] // Bắt buộc
        [MaxLength(20)] // Giới hạn độ dài, sử dụng MaxLength hoặc StringLength
        public string DienThoai { get; set; } = null!; // Quy ước PascalCase & null-forgiving

        // 6. Thuộc tính Điều hướng (Collection Navigation)
        // Dùng ICollection<T> hoặc List<T> đều được, nhưng ICollection<T> là giao diện chung
        // Nên khởi tạo (initialize) để tránh lỗi NullReferenceException khi thêm sản phẩm mới
        public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>(); // Quy ước PascalCase
    }

}