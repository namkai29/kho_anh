using BTLTH.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BTLTH.Api.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }

        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<CungCap> CungCaps { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDH> ChiTietDHs{ get; set; }

    }   

}
