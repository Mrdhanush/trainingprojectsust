using Microserviceproject.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace Microserviceproject.Services.CouponAPI.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "T11t",
                DiscountAmount = 10,
                MinAmount = 10,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "T012",
                DiscountAmount = 10,
                MinAmount = 10
            });
        }
    }
}
