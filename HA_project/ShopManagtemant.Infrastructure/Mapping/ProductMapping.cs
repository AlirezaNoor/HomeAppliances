using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagmant.Domin.Product;

namespace ShopManagtemant.Infrastructure.Mapping
{
    public class ProductMapping:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.Discription).HasMaxLength(500).IsRequired();
            builder.Property(x => x.slug).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(900).IsRequired();
            builder.Property(x => x.Shortdiscription).HasMaxLength(400).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(200).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Metadiscrption).HasMaxLength(200).IsRequired();
            builder.Property(x => x.code).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.categoryname).WithMany(x => x.product).HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.ProductPictures).WithOne(x => x.product).HasForeignKey(x => x.ProductId);



        }
    }
}
