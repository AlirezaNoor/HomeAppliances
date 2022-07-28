using Inventory.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Context
{
    public class InventoryContext:DbContext
    {
        public DbSet<Domin.Inventory.InventoryAgg.Inventory> inventory { get; set; }
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InventoryMapping());
            base.OnModelCreating(modelBuilder);
        }

    }
}
