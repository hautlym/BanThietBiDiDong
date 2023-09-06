using BanThietBiDiDong.API.Data.Configurations;
using BanThietBiDiDong.API.Data.Enitites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BanThietBiDiDong.API.Data
{
    public class BanThietBiDiDongDBContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public BanThietBiDiDongDBContext(DbContextOptions options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new ProductConfigurations());
            builder.ApplyConfiguration(new ProductImageConfiguration());
            builder.ApplyConfiguration(new RatingProductConfiguration());

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.RoleId, x.UserId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
          //  base.OnModelCreating(builder);
        }
        public DbSet<Product> products { get; set; }
        public DbSet<ActivityLog> activityLogs { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
        public DbSet<RatingProduct> ratingProducts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Voucher> vouchers { get; set; }
    }
}
