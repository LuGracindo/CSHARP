using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;

namespace BookStoreManager.Application.UseCases.Books.GetById
{
    public interface IGetBookByIdUseCase
    {
        Task<ResponseShortGetAllBookJson> Execute(long id);
    }
}
