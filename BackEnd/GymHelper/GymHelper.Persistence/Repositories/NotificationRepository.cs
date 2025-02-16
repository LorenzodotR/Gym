using GymHelper.Core;
using GymHelper.Model;

namespace GymHelper.Persistence.Repositories
{
    public class NotificationRepository : Repository<Notification>
    {
        public NotificationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
