using GymHelper.Core;
using GymHelper.Model;

namespace GymHelper.Persistence.Repositories
{
    public class LogRepository : Repository<Log>
    {
        public LogRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
