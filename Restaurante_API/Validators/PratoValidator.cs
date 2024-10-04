using FluentValidation;
using Restaurante_API.Models;

namespace Restaurante_API.Validators
{
    public class PratoValidator : AbstractValidator<Pratos>
    {
        public PratoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O nome do prato é obrigatório.")
                .Length(3, 100).WithMessage("O nome deve ter entre 3 a 100 caracteres");

            RuleFor(p => p.Preco)
                .GreaterThan(0).WithMessage("O preço do prato deve ser maior que zero.");
        }
    }
}
