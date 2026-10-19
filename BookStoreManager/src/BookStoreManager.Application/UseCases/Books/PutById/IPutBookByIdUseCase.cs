using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;

namespace BookStoreManager.Application.UseCases.Books.PutById
{
    public interface IPutBookByIdUseCase
    {
        Task<ResponseShortGetAllBookJson> Execute(long id, RequestUpdateBookJson request);
    }
}
