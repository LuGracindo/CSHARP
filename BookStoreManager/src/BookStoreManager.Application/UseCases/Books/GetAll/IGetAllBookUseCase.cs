using BookStoreManager.Comunication.Responses;

namespace BookStoreManager.Application.UseCases.Books.GetAll
{
    public interface IGetAllBookUseCase
    {
        Task<ResponseGetAllBookJson> Execute();
    }
}
