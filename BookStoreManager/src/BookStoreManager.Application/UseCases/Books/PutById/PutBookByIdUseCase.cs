using AutoMapper;
using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;
using BookStoreManager.Domain.Repositories;
using BookStoreManager.Domain.Repositories.Books;
using BookStoreManager.Exception;
using BookStoreManager.Exception.ExceptionsBase;

namespace BookStoreManager.Application.UseCases.Books.PutById
{
    public class PutBookByIdUseCase : IPutBookByIdUseCase
    {
        private readonly IBooksRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PutBookByIdUseCase(IBooksRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ResponseShortGetAllBookJson> Execute(long id, RequestUpdateBookJson request)
        {
            Validate(request);

            var book = await _repository.GetByIdTracked(id);

            if (book is null)
                throw new NotFoundException(ResourceErrorMessages.BOOK_NOT_FOUND);

            _mapper.Map(request, book);

            _repository.Update(book);

            await _unitOfWork.Commit();

            return _mapper.Map<ResponseShortGetAllBookJson>(book);
        }

        private void Validate(RequestUpdateBookJson request)
        {
            var validator = new UpdateBookValidator();

            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var erroMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ErrorOnValidationException(erroMessages);
            }
        }
    }
}
