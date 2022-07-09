using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagmant.Domin.ProductCategory;

namespace ShopManagtemant.Infrastructure.Mapping
{
    internal class ProductCategoryMapping:IEntityTypeConfiguration<ProductCategores>
    {
        public void Configure(EntityTypeBuilder<ProductCategores> builder)
        {
            builder.ToTable("Productcategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Discription).HasMaxLength(500);
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.ImageTitle).HasMaxLength(200);
            builder.Property(x => x.Alt).HasMaxLength(200);
            builder.Property(x => x.Keywords).HasMaxLength(80).IsRequired();
            builder.Property(x => x.MetaDiscription).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(200).IsRequired();
            builder.HasMany(x => x.product).WithOne(x => x.categoryname).HasForeignKey(x => x.CategoryId);
        }
    }
}
