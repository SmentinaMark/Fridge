using FridgeAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FridgeAPI.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Fridge> Fridges { get; set; } = null!;
        public DbSet<Fridge_Model> FridgeModels { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Fridge_Product> Fridge_Products { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fridge_FridgeProduct_Product
            modelBuilder
             .Entity<Fridge>()
             .HasMany(c => c.Products)
             .WithMany(s => s.Fridges)
             .UsingEntity<Fridge_Product>(
                j => j
                 .HasOne(pt => pt.Product)
                 .WithMany(t => t.Fridge_Products)
                 .HasForeignKey(pt => pt.ProductId),
             j => j
                 .HasOne(pt => pt.Fridge)
                 .WithMany(p => p.Fridge_Products)
                 .HasForeignKey(pt => pt.FridgeId),
             j =>
             {
                 j.Property(pt => pt.Quantity).HasDefaultValue(0);
                 j.HasKey(t => new { t.FridgeId, t.ProductId });
                 j.ToTable(nameof(Fridge_Product));
             });
            #endregion
        }
    }
}
