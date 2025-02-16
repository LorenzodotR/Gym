using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GymHelper.Model;
using GymHelper.Core;

namespace GymHelper.Persistence
{
    public class DataContext : DbContext
    {
        internal DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = ServiceProviderFactory.ServiceProvider.GetService<IConfiguration>();
            if (configuration["EntityFrameworkTracer"].ToString().ToLower() == "true")
            {
                var loggerFactory = new LoggerFactory();
                loggerFactory.AddProvider(new LoggerProvider());
                optionsBuilder.UseLoggerFactory(loggerFactory);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}