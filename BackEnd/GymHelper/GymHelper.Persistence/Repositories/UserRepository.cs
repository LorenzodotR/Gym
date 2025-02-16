using GymHelper.Core;
using GymHelper.Model;
using Microsoft.EntityFrameworkCore;

namespace GymHelper.Persistence.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override IQueryable<User> GetAll()
        {
            return base.GetAll();
        }

        public User? Get(Guid userId)
        {
            //return base.GetAll();
            return null;
        }
    }
}
