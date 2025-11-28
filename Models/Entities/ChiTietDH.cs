using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLTH.Api.Models.Entities
{
    public class ChiTietDH
    {
        // 1. Khóa Chính (Primary Key) VÀ Khóa Ngoại (Foreign Key)
        // [Key] sẽ được thiết lập bằng Fluent API
        // Đây là cách duy nhất để có 1-1 hợp lệ
        public int DonHangId { get; set; }

        // 2. Thuộc tính Điều hướng ngược (Không cho phép NULL)
        // Liên kết 1-1 với DonHang
        public virtual DonHang Donhang { get; set; } = null!;

        // 3. Thông tin chi tiết (Ví dụ: Tổng giá trị, trạng thái)
        [Column(TypeName = "decimal(13, 2)")]
        public decimal TongGiaTri { get; set; }

        [StringLength(50)]
        public string? TrangThaiThanhToan { get; set; }

        // ❌ ĐÃ LOẠI BỎ: ChiTietDHId và SanPhamId
    }

}