using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace BanThietBiDiDong.API.Data
{
    public class ThietBiDiDongDbContextFactory : IDesignTimeDbContextFactory<BanThietBiDiDongDBContext>
    {
        public BanThietBiDiDongDBContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json")
                .Build();
            var builder = new DbContextOptionsBuilder<BanThietBiDiDongDBContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new BanThietBiDiDongDBContext(builder.Options);
        }
    }
}
