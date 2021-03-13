using Market.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Market.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"data Source=(localdb)\MSSQLLocalDB;initial catalog=Northwind;integrated security=true");
        }
    }
}
