using BanThietBiDiDong.API.Data.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BanThietBiDiDong.API.Data.Configurations
{
    public class RatingProductConfiguration : IEntityTypeConfiguration<RatingProduct>
    {
        public void Configure(EntityTypeBuilder<RatingProduct> builder)
        {
            builder.HasOne(x=>x.product).WithMany(x=>x.ratingProducts).HasForeignKey(x=>x.productId);
        }
    }
}
