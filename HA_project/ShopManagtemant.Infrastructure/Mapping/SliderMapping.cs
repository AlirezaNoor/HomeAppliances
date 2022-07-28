using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagmant.Domin.Slid;

namespace ShopManagtemant.Infrastructure.Mapping
{
    public class SliderMapping:IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.ToTable("Slider");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Btntitle).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ISRemove).IsRequired();
            builder.Property(x => x.discription).IsRequired().HasMaxLength(800);
            builder.Property(x => x.headingTitle).IsRequired().HasMaxLength(200);
            builder.Property(x => x.slidePicture).IsRequired().HasMaxLength(10000);
            builder.Property(x => x.Link).IsRequired().HasMaxLength(100);





        }
    }
}
