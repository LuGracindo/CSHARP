using BookStoreManager.Domain.Repositories;

namespace BookStoreManager.Infrastructure.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreManagerDbContext _dbContext;

        public UnitOfWork(BookStoreManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
