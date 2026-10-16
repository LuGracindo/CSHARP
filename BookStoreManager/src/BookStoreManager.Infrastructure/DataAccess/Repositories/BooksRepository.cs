using BookStoreManager.Domain.Entities;
using BookStoreManager.Domain.Repositories.Books;

namespace BookStoreManager.Infrastructure.DataAccess.Repositories
{
    internal class BooksRepository : IBooksRepository
    {
        private readonly BookStoreManagerDbContext _dbContext;

        public BooksRepository(BookStoreManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Book book)
        {
            await _dbContext.Books.AddAsync(book);
        }
    }
}
