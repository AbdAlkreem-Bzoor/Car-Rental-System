using Car_Rental.Web.Models;
using FluentValidation;

namespace Car_Rental.Web.Validators
{
    public class UserSignInValidator : AbstractValidator<UserSignIn>
    {
        public UserSignInValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress();

            RuleFor(x => x.Password).StrongPassword();
        }
    }
}
