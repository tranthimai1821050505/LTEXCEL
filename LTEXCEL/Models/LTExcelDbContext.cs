using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTEXCEL.Models
{
    public partial class LTExcelDbContext : DbContext
    {
        public LTExcelDbContext()
            : base("name=LTExcelDbContext")
        {
        }

      public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKhachHang)
                .IsUnicode(false);
            modelBuilder.Entity<KhachHang>()
               .Property(e => e.MaKhachHang)
               .IsUnicode(false);
        }
    }
}
