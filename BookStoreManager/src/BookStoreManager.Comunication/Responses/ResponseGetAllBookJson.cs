using BookStoreManager.Domain.Enums;

namespace BookStoreManager.Comunication.Responses
{
    public class ResponseGetAllBookJson
    {
        public List<ResponseShortGetAllBookJson> Books { get; set; } = [];
    }

    public class ResponseShortGetAllBookJson
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;

        public Genres Genre { get; set; }

        public Decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
