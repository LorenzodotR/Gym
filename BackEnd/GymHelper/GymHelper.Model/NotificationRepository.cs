using CoworkingManager.Core;
using CoworkingManager.Model;

namespace CoworkingManager.Persistence.Repositories
{
    public class NotificationRepository : Repository<Notification>
    {
        public NotificationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
