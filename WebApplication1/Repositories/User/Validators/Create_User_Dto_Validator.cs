using FluentValidation;
using WebApplication1.Repositories.User.DTO;

namespace WebApplication1.Repositories.User.Validators
{
    public class Create_User_Dto_Validator : AbstractValidator<Create_User_Dto>
    {
        public Create_User_Dto_Validator()
        {
            RuleFor(x => x.LOGIN)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(x => x.IMIE)
              .NotEmpty()
              .MaximumLength(15);

            RuleFor(x => x.NAZWISKO)
              .NotEmpty()
              .MaximumLength(30);


            RuleFor(x => x.ADRES)
                  .MaximumLength(25);

            RuleFor(x => x.MIASTO)
                .MaximumLength(15);
        }
    }
}
