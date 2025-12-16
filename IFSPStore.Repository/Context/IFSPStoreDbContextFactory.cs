using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IFSPStore.Repository.Context
{
    public class IFSPStoreDbContextFactory : IDesignTimeDbContextFactory<IFSPStoreDbContext>
    {
        public IFSPStoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<IFSPStoreDbContext>();

            var connectionString = "Server=localhost;Port=3306;Database=IFSPStoreDB;User ID=developer;Password=123456789";

            optionsBuilder.UseMySQL(connectionString);

            return new IFSPStoreDbContext(optionsBuilder.Options);
        }
    }
}