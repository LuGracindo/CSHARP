namespace BookStoreManager.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
