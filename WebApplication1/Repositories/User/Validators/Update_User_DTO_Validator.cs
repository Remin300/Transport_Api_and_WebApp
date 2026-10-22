using FluentValidation;
using WebApplication1.Repositories.User.DTO;

namespace WebApplication1.Repositories.User.Validators
{
    public class Update_User_DTO_Validator : AbstractValidator<Update_User_DTO>
    {
        public   Update_User_DTO_Validator()
        {
            string validate_err = "";

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
