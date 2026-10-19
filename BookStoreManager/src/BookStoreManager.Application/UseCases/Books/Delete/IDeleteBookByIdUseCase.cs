namespace BookStoreManager.Application.UseCases.Books.Delete
{
    public interface IDeleteBookByIdUseCase
    {
        Task Execute(long id);
    }
}
