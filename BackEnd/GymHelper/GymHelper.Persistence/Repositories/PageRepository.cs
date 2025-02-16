using GymHelper.Core;
using GymHelper.Model;

namespace GymHelper.Persistence.Repositories
{
    public class PageRepository : Repository<Page>
    {
        public PageRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
