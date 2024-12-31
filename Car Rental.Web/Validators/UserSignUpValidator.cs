using Car_Rental.Web.Models;
using FluentValidation;

namespace Car_Rental.Web.Validators
{
    public class UserSignUpValidator : AbstractValidator<UserSignUp>
    {
        public UserSignUpValidator()
        {
            RuleFor(x => x.FirstName).ValidName();
            RuleFor(x => x.LastName).ValidName();

            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress();

            RuleFor(x => x.Password).StrongPassword();
            RuleFor(x => x.ConfirmPassword).StrongPassword().Equal(x => x.Password);

            RuleFor(x => x.PhoneNumber).ValidPhoneNumber();

            RuleFor(x => x.DateOfBirth);

            RuleFor(x => x.AddressLine1).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(x => x.AddressLine2);

            RuleFor(x => x.City).NotNull().NotEmpty();

            RuleFor(x => x.Country).NotNull().NotEmpty();

            RuleFor(x => x.DriversLicenseNumber).NotNull().NotEmpty();
        }
    }
}
