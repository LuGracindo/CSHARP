using BookStoreManager.Domain.Enums;

namespace BookStoreManager.Comunication.Requests
{
    public class RequestRegisterBookJson
    {       

        public string Title { get; set; } = string.Empty;

        public string Author {  get; set; } = string.Empty;

        public Genres Genre { get; set; }

        public Decimal Price { get; set; }

        public int Stock { get; set; }
    }
}