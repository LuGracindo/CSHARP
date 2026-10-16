using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;

namespace BookStoreManager.Application.UseCases.Books.Register
{
    public interface IRegisterBookUseCase
    {
        Task<ResponseRegisterBookJson> Execute(RequestRegisterBookJson request);
    }
}
