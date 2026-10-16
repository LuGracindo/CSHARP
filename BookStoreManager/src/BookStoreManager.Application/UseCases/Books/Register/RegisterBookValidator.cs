using BookStoreManager.Comunication.Requests;
using FluentValidation;

namespace BookStoreManager.Application.UseCases.Books.Register
{
    public class RegisterBookValidator : AbstractValidator<RequestRegisterBookJson>
    {
        public RegisterBookValidator() 
        {
            RuleFor(book => book.Title).NotEmpty().WithMessage("Titulo Obrigatório").Length(2, 120).WithMessage("O Titulo deve ter entre 2 e 120 caracteres.");
            RuleFor(book => book.Author).NotEmpty().WithMessage("Nome do Autor Obrigatório").Length(2, 120).WithMessage("O nome do Autor deve ter entre 2 e 120 caracteres.");
            RuleFor(book => book.Price).GreaterThanOrEqualTo(0).WithMessage("O preço deve ser maior ou igual a zero.");
            RuleFor(book => book.Stock).GreaterThanOrEqualTo(0).WithMessage("A quantidade deve ser maior ou igual a zero.");
            RuleFor(book => book.Genre).IsInEnum().WithMessage("Gênero Inválido");
        }
    }
}
