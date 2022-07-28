using DiscountManegmant.Domin.Colleague_DiscountAgg;
using DiscountManegmant.Domin.CustomerDiscountAgg;
using DiscountManegmant.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DiscountManegmant.Infrastructure.context
{
    public class CustomerDiscountContext:DbContext
    {
        public DbSet<CustomerDiscount> Customer { get; set; }
        public DbSet<ColleagueDiscount> colleague { get; set; }

        public CustomerDiscountContext(DbContextOptions<CustomerDiscountContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerDiscountMapping());
            modelBuilder.ApplyConfiguration(new colleagueMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
