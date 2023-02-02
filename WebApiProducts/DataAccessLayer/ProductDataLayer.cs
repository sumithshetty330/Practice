using System.Data.Entity;
using WebAppApi.Models;

namespace WebApiProducts.ProductsDLL

{
    public class ProductsDataLayer : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("ProductsTable");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
    }
}

