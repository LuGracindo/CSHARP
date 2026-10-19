using BookStoreManager.Comunication.Requests;
using BookStoreManager.Exception;
using FluentValidation;

namespace BookStoreManager.Application.UseCases.Books.Register
{
    public class RegisterBookValidator : AbstractValidator<RequestRegisterBookJson>
    {
        public RegisterBookValidator() 
        {
            RuleFor(book => book.Title).NotEmpty().WithMessage(ResourceErrorMessages.TITLE_REQUIRED).Length(2, 120).WithMessage(ResourceErrorMessages.STRING_SIZE);
            RuleFor(book => book.Author).NotEmpty().WithMessage(ResourceErrorMessages.AUTHOR_REQUIRED).Length(2, 120).WithMessage(ResourceErrorMessages.AUTHOR_SIZE);
            RuleFor(book => book.Price).GreaterThanOrEqualTo(0).WithMessage(ResourceErrorMessages.PRICE_GREATER_OR_EQUAL_ZERO);
            RuleFor(book => book.Stock).GreaterThanOrEqualTo(0).WithMessage(ResourceErrorMessages.QTN_GREATER_OR_EQUAL_ZERO);
            RuleFor(book => book.Genre).IsInEnum().WithMessage(ResourceErrorMessages.INVALID_GENDER);
        }
    }
}
