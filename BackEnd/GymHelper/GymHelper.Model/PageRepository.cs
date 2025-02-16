using CoworkingManager.Core;
using CoworkingManager.Model;

namespace CoworkingManager.Persistence.Repositories
{
    public class PageRepository : Repository<Page>
    {
        public PageRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
