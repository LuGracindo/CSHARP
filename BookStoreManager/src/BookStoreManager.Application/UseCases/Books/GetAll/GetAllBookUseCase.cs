using AutoMapper;
using BookStoreManager.Comunication.Responses;
using BookStoreManager.Domain.Repositories;
using BookStoreManager.Domain.Repositories.Books;

namespace BookStoreManager.Application.UseCases.Books.GetAll
{
    public class GetAllBookUseCase : IGetAllBookUseCase
    {
        private readonly IBooksRepository _repository;
        private readonly IMapper _mapper;

        public GetAllBookUseCase(IBooksRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResponseGetAllBookJson> Execute()
        {
            var result = await _repository.GetAll();

            return new ResponseGetAllBookJson
            {
                Books = _mapper.Map<List<ResponseShortGetAllBookJson>>(result)
            };
        }
    }
}
