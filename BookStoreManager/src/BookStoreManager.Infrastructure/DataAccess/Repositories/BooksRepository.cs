using BookStoreManager.Domain.Entities;
using BookStoreManager.Domain.Repositories.Books;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Book>> GetAll()
        {
            return await _dbContext.Books.AsNoTracking().ToListAsync();
        }

        public async Task<Book?> GetById(long id)
        {
            return await _dbContext.Books.AsNoTracking().FirstOrDefaultAsync(book => book.Id == id);
        }

        public async Task<Book?> GetByIdTracked(long id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(book => book.Id == id);
        }

        public void Update(Book book)
        {
            _dbContext.Books.Update(book);
        }
        public void Delete(Book book)
        {
            _dbContext.Books.Remove(book);
        }

    }
}
