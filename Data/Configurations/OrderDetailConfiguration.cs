using BanThietBiDiDong.API.Data.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BanThietBiDiDong.API.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x=>new { x.OrderId,x.ProductId});
            builder.HasOne(x=> x.Order).WithMany(x=>x.OrderDetails).HasForeignKey(x=>x.OrderId);
            builder.HasOne(x => x.Products).WithMany(x => x.orderDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
