using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context;

public class IFSPStoreDbContext : DbContext
{
    public IFSPStoreDbContext(DbContextOptions<IFSPStoreDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>(new CategoryMap().Configure);
        modelBuilder.Entity<City>(new CityMap().Configure);
        modelBuilder.Entity<Customer>(new CustomerMap().Configure);
        modelBuilder.Entity<Product>(new ProductMap().Configure);
        modelBuilder.Entity<Sale>(new SaleMap().Configure);
        modelBuilder.Entity<SaleItem>(new SaleItemMap().Configure);
        modelBuilder.Entity<User>(new UserMap().Configure);
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<User> Users { get; set; }
}