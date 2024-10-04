using FluentValidation;
using Restaurante_API.Models;

namespace Restaurante_API.Validators
{
    public class RestauranteValidator : AbstractValidator<Restaurantes>
    {
        public RestauranteValidator()
        {
            RuleFor(r => r.Nome)
                .NotEmpty().WithMessage("O nome do restaurante é obrigátorio.")
                .Length(3, 100).WithMessage("O nome deve ter entre 3 e 100 caracteres.");

            RuleFor(r => r.Descricao)
                .MaximumLength(300).WithMessage("A descrição pode ter no máximo 300 caracteres");

            RuleFor(r => r.Numero)
                .MaximumLength(18).WithMessage("O número não pode ter mais do que 18 caracteres");

            RuleForEach(r => r.Pratos).SetValidator(new PratoValidator());
        }
    }
}
