using BanThietBiDiDong.API.Data.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BanThietBiDiDong.API.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasOne(x=>x.Product).WithMany(x=>x.productImgs).HasForeignKey(x=>x.ProductId);
        }
    }
}
