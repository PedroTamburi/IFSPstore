using Microsoft.EntityFrameworkCore;
using IFSPstore.Domain.Entities;

namespace IFSPStoreRepository.Contest
{
    public class IFSPStoreContext : DbContext
    {
        public IFSPStoreContext() : base()
        {
            Database.EnsureCreated(); // create database if not exists
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=IFSPstore;user=root;password=");
        }

        public DbSet<City> Cities {get;set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales{ get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }



    }
}
