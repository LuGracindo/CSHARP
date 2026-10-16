using BookStoreManager.Domain.Entities;

namespace BookStoreManager.Domain.Repositories.Books
{
    public interface IBooksRepository
    {
        Task Add(Book book);
    }
}
