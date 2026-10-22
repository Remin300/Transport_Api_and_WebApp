using FluentValidation;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.Zlecenia.DTO;

namespace WebApplication1.Repositories.Zlecenia.Validators
{
    public class Create_Zlecenie_Dto_Validator : AbstractValidator<Create_Zlecenie_Dto>
    {

        public Create_Zlecenie_Dto_Validator()
        {
            RuleFor(x => x.IdZleceniodawcy)
                .NotNull();

            RuleFor(x => x.DataZlecenia)
                .NotNull();

            RuleFor(x => x.IdKategoria)
              .NotNull();

            
        }
    }
}
