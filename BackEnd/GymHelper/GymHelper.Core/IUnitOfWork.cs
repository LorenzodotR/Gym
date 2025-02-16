namespace GymHelper.Core
{
    public interface IUnitOfWork
    {
        object Context { get; }

        void Save();
        Task<int> SaveAsync();
    }
}
