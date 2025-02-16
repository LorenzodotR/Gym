using Microsoft.EntityFrameworkCore;
using GymHelper.Persistence.Repositories;

namespace GymHelper.Persistence
{
	public partial class UnitOfWork : Core.UnitOfWork
	{
		public UnitOfWork(DbContext context) : base(context)
        {
            Users = new UserRepository(this);
            Roles = new RoleRepository(this);
            Notifications = new NotificationRepository(this);
            Pages = new PageRepository(this);
            Logs = new LogRepository(this);
        }

        public void ExecuteSql(string sql, params object[] parameters)
        {
            DbContext.Database.ExecuteSqlRaw(sql, parameters);
        }

        public UserRepository Users { get; }
        public RoleRepository Roles { get; }
        public NotificationRepository Notifications { get; }
        public PageRepository Pages { get; }
        public LogRepository Logs { get; }
    }
}
