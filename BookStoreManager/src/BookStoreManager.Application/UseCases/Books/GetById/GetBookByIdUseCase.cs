using AutoMapper;
using BookStoreManager.Comunication.Responses;
using BookStoreManager.Domain.Repositories.Books;
using BookStoreManager.Exception;

namespace BookStoreManager.Application.UseCases.Books.GetById
{
    public class GetBookByIdUseCase : IGetBookByIdUseCase
    {
        private readonly IBooksRepository _repository;
        private readonly IMapper _mapper;

        public GetBookByIdUseCase(IBooksRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;            
        }

        public async Task<ResponseShortGetAllBookJson> Execute(long id)
        {
            var result = await _repository.GetById(id);

            if (result is null)
                throw new NotFoundException(ResourceErrorMessages.BOOK_NOT_FOUND);

            return _mapper.Map<ResponseShortGetAllBookJson>(result);

        }

    }
}
