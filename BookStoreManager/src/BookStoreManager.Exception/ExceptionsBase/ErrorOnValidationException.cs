namespace BookStoreManager.Exception.ExceptionsBase
{
    public class ErrorOnValidationException(List<string> errorMessages) : BookStoreManagerException
    {
        public List<string> Errors { get; set; } = errorMessages;

    }
}
