using BookStoreManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManager.Infrastructure.DataAccess
{
    internal class BookStoreManagerDbContext : DbContext
    {
        public BookStoreManagerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
