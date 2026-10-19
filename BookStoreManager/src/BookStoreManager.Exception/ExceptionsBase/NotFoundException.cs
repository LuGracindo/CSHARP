using BookStoreManager.Exception.ExceptionsBase;

public class NotFoundException : BookStoreManagerException
{
    public string ErrorMessage { get; set; }

    public NotFoundException(string message)
    {
        ErrorMessage = message;
    }
}