using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLTH.Api.Models.Entities
{
    public class DonHang
    {
        [Key]
        public int DonHangId { get; set; }

        // Khóa Ngoại 1-N: Khách Hàng (Đã được kiểm tra là hợp lý)
        [Required]
        public int KhachHangId { get; set; }
        public virtual KhachHang Khachhang { get; set; }

        // Khóa Ngoại 1-N: Nhân Viên (Đã được kiểm tra là hợp lý)
        [Required]
        public int NhanVienId { get; set; }
        public virtual NhanVien Nhanvien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDatHang { get; set; }

        // Mối quan hệ 1-1: Chỉ định Thuộc tính Điều hướng
        // Không cần Khóa Ngoại ở đây, vì Khóa Ngoại nằm trong ChiTietDH và sử dụng Khóa Chính của DonHang
        public virtual ChiTietDH ChiTietDonHang { get; set; }
    }

}