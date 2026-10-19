using BookStoreManager.Domain.Entities;

namespace BookStoreManager.Domain.Repositories.Books
{
    public interface IBooksRepository
    {
        Task Add(Book book);

        Task<List<Book>> GetAll();

        Task<Book?> GetById(long id);

        Task<Book?> GetByIdTracked(long id);

        void Update(Book book);

        void Delete(Book book);
    }
}
