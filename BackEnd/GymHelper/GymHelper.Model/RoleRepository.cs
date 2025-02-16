using CoworkingManager.Core;
using CoworkingManager.Model;

namespace CoworkingManager.Persistence.Repositories
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
