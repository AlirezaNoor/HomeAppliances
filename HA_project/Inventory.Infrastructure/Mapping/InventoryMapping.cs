using Domin.Inventory.InventoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Infrastructure.Mapping
{
    public class InventoryMapping:IEntityTypeConfiguration<Domin.Inventory.InventoryAgg.Inventory>
    {
        public void Configure(EntityTypeBuilder<Domin.Inventory.InventoryAgg.Inventory> builder)
        {
            builder.ToTable("Inventory");
            builder.HasKey(x => x.Id);
            builder.OwnsMany(x => x.inventoryOperation, ModelBuilder =>
            {
                ModelBuilder.ToTable("InventoryOperation");
                ModelBuilder.HasKey(x => x.id);
                ModelBuilder.WithOwner(x => x.Inventory).HasForeignKey(x => x.InventoryId);
            });
        }
    }
}
