using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Solution.Data.Configurations;
using Solution.Data.Entities;
namespace Solution.Data.EF
{
    public class clsDbContext : DbContext
    {
        public clsDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new Prd_DetailConfig());
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Prd_Detail> Prd_Details { get; set; }
    }
}
 