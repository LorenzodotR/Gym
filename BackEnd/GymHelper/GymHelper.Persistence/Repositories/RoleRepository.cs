using GymHelper.Core;
using GymHelper.Model;

namespace GymHelper.Persistence.Repositories
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
