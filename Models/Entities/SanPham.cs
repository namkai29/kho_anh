using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLTH.Api.Models.Entities
{
    public class SanPham
    {
        [Key]
        public int SanphamID { get; set; }

        [Required]
        [StringLength(255)]
        [Column("Tensanpham", TypeName = "nvarchar(255)")]
        public string TenSanpham { get; set; }  // null-forgiving operator
        
        [Required,MaxLength(200)]
        public string ImageUrl { get; set; }

        // 3. Giá (DECIMAL, không dùng MONEY nếu không cần độ chính xác tài chính cao)
        // Nếu dùng money trong SQL Server, bạn nên dùng decimal trong C#
        [Column(TypeName = "decimal(13, 2)")] // Độ dài và độ chính xác phù hợp
        public decimal Gia { get; set; } // Giả định giá không được null

        // 4. Đơn vị (Không Null, NVARCHAR(50))
        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string DonVi { get; set; }

        // 5. Khóa ngoại đến Danh mục (Bắt buộc - NOT NULL)
        // EF Core sẽ tự hiểu đây là Khóa ngoại nếu có thuộc tính điều hướng (Navigation Property)
        public int DanhMucId { get; set; } // Bắt buộc (NOT NULL)

        // 6. Thuộc tính Điều hướng đến Danh mục
        // Đảm bảo tên lớp được định nghĩa
        public virtual DanhMuc Danhmuc { get; set; } // Bắt buộc phải có (NOT NULL)

        // 7. Khóa ngoại đến Cung cấp/Nhà cung cấp (Thêm theo yêu cầu ban đầu)
        // Đã thêm thuộc tính này để hoàn thành yêu cầu ban đầu
        public int CungCapId { get; set; } // Bắt buộc (NOT NULL)

        // 8. Thuộc tính Điều hướng đến Cung cấp
        public virtual CungCap Cungcap { get; set; }

        public static SanPham[] GetSeedData()
        {
            const string ImageUrl =
        }

    }

}