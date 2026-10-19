using BookStoreManager.Domain.Repositories;
using BookStoreManager.Domain.Repositories.Books;
using BookStoreManager.Exception;
using BookStoreManager.Exception.ExceptionsBase;

namespace BookStoreManager.Application.UseCases.Books.Delete
{
    public class DeleteBookByIdUseCase : IDeleteBookByIdUseCase
    {
        private readonly IBooksRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBookByIdUseCase(IBooksRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(long id)
        {
            var book = await _repository.GetByIdTracked(id);

            if (book is null)
                throw new NotFoundException(ResourceErrorMessages.BOOK_NOT_FOUND);

            _repository.Delete(book);

            await _unitOfWork.Commit();
        }
    }
}