using GymHelper.Model;
using Microsoft.EntityFrameworkCore;


namespace GymHelper.Infrastructure.DataAcess
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=gymhelper-db;Port=5432;Database=GymHelper;Username=gymhelper;Password=gympassword";

            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
