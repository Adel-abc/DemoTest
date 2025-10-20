using System.Reflection.Metadata.Ecma335;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.ApplicationDbContextFolder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ArtPieces> ArtPieces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasMany(x => x.ArtPieces).WithOne(x => x.Customer);
            modelBuilder.Entity<Category>().HasMany(x => x.ArtPieces).WithMany(x => x.Categories);
            modelBuilder.Entity<Customer>().HasOne(x => x.LoyaltyCard).WithOne(x => x.Custoemr);

            modelBuilder.Entity<Customer>().HasData
            (
                new Customer { Id = 1, Name = "Osama", EmailAddress = "osama@gamil.com", Phone = "0123456789" }
            );
            modelBuilder.Entity<LoyaltyCard>().HasData
            (
                new LoyaltyCard { Id = 1, CardNumber = "085274", Balance = 100, CustomerID = 1 }
            );
            modelBuilder.Entity<Category>().HasData
            (
                new Category { Id = 1, Name = "Fun" }
            );
            modelBuilder.Entity<ArtPieces>().HasData
            (
                new ArtPieces { Id = 1, Title = "Test", Description = "test", Price = 100, CustomerID = 1 }
            );
        }

    }
}
