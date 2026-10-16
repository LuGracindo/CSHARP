namespace BookStoreManager.Comunication.Responses
{
    public class ResponseRegisterBookJson
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}
