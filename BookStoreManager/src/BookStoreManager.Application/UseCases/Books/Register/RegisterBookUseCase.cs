using AutoMapper;
using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;
using BookStoreManager.Domain.Entities;
using BookStoreManager.Domain.Repositories;
using BookStoreManager.Domain.Repositories.Books;
using BookStoreManager.Exception.ExceptionsBase;

namespace BookStoreManager.Application.UseCases.Books.Register
{
    public class RegisterBookUseCase : IRegisterBookUseCase
    {
        private readonly IBooksRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RegisterBookUseCase(IBooksRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ResponseRegisterBookJson> Execute(RequestRegisterBookJson request)
        {

            Validate(request);

            var entity = _mapper.Map<Book>(request);

            await _repository.Add(entity);

            await _unitOfWork.Commit();

            return _mapper.Map<ResponseRegisterBookJson>(entity);

        }

        private void Validate(RequestRegisterBookJson request)
        {
            var validator = new RegisterBookValidator();

            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var erroMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ErrorOnValidationException(erroMessages);
            }
        }
    }
}
