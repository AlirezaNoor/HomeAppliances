﻿using Microsoft.EntityFrameworkCore;
using ShopManagmant.Domin.Product;
using ShopManagmant.Domin.ProductCategory;
using ShopManagtemant.Infrastructure.Mapping;

namespace ShopManagtemant.Infrastructure.ShopContext
{
    public class MyContext:DbContext
    {
        public DbSet<ProductCategores> Pgdbset { get; set; }
        public DbSet<Product> prioduct { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
