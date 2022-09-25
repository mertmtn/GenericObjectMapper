using GenericObjectMapper.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GenericObjectMapper.DataAccess.Concrete.EntityFramework
{
    public class NorthwindDbContext : DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
        }
      
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>()
        //                                .HasMany(c => c.Products)
        //                                .WithOne(a => a.Category)
        //                                .HasForeignKey(a => a.CategoryId);
        //    modelBuilder.Seed();
        //}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
