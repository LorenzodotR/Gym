using GymHelper.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GymHelper.Persistence
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args = null)
        {
            IConfiguration configuration = ServiceProviderFactory.ServiceProvider.GetService<IConfiguration>();

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            var contextSection = configuration.GetSection("ConnectionStrings")?.GetSection("Context");
            if (contextSection == null)
            {
                throw new ArgumentException("ConnectionStrings Context not found");
            }

            string connectionString = contextSection.GetSection("connectionString")?.Value;
            if (contextSection == null)
            {
                throw new ArgumentException("connectionString not found");
            }

            optionsBuilder.UseNpgsql(
                connectionString,
                builder => builder.EnableRetryOnFailure(2, TimeSpan.FromSeconds(3), null));

            DataContext dataContext = new DataContext(optionsBuilder.Options);
            dataContext.Database.SetCommandTimeout(600);

            return dataContext;
        }
    }
}