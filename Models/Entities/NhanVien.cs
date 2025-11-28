using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLTH.Api.Models.Entities
{
    public class NhanVien
    {
        [Key]
        public int NhanVienId { get; set; } // Khóa chính (Primary Key)

        // 2. Họ và Tên (Đặt thành 2 cột riêng, cả hai đều bắt buộc)
        [Required]
        [StringLength(100)]
        public string Ho { get; set; } = null!; // Bắt buộc, giới hạn 100 ký tự

        [Required]
        [StringLength(155)] // Tổng cộng 255 ký tự cho Họ và Tên là hợp lý
        public string Ten { get; set; } = null!; // Bắt buộc, giới hạn 155 ký tự

        // 3. Ngày Sinh: Sử dụng kiểu date
        [Required] // Ngày sinh nên là bắt buộc
        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        // 4. Địa chỉ (Thường có, giả định là không bắt buộc)
        [StringLength(500)]
        public string? DiaChi { get; set; }

        // 5. Ghi Chú: Dùng nvarchar(max) thay cho ntext
        [Column(TypeName = "nvarchar(max)")] // Tốt hơn ntext trong SQL Server hiện đại
        public string? GhiChu { get; set; } // Cho phép null

        // 6. Mối quan hệ: Thêm Collection Navigation để liên kết với các bảng con
        // Ví dụ: Một nhân viên xử lý nhiều đơn hàng (Nếu bạn có bảng DonHang)
        public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
    }

}