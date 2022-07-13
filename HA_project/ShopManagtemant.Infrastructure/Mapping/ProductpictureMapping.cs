using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagmant.Domin.ProductPicture;

namespace ShopManagtemant.Infrastructure.Mapping
{
    public class ProductpictureMapping:IEntityTypeConfiguration<ProductPicture>
    {
        public void Configure(EntityTypeBuilder<ProductPicture> builder)
        {
            builder.ToTable("ProductPictures");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Picture).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.PictureTitle).IsRequired().HasMaxLength(200);
            builder.Property(x => x.PictureAlt).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.product).WithMany(x => x.ProductPictures).HasForeignKey(x => x.ProductId);

        }
    }
}
