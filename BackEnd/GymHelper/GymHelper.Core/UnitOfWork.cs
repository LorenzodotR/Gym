using Microsoft.EntityFrameworkCore;

namespace GymHelper.Core
{
    public abstract class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork(DbContext context)
        {
            this.Context = context;
        }

        public void Dispose()
        {
        }

        public object Context { get; private set; }
        protected DbContext DbContext
        {
            get
            {
                return Context as DbContext;
            }
        }

        public bool HasChanges
        {
            get
            {
                return DbContext.ChangeTracker.HasChanges();
            }
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await DbContext.SaveChangesAsync();
        }
    }
}
