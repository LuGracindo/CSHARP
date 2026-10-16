using BookStoreManager.Domain.Enums;

namespace BookStoreManager.Domain.Entities
{
    public class Book
    {
        public long Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public Genres Genre { get; set; }

        public Decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
