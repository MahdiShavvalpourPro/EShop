using EShop.Models.Dto;
using FluentValidation;

namespace EShop.Validation
{
    public class UserValidationWithPhone : AbstractValidator<UserSingUpWithPhoneNumberDto>
    {
        public UserValidationWithPhone()
        {
            RuleFor(x => x.PhoneNumber)
               //.NotEmpty()
               //.WithMessage("PhoneNumber Is Required")
               .Length(11)
               .WithMessage("The length of mobile must be 11 characters")
               .Matches(@"^09\d{9}$")
               .WithMessage("Mobile number must start with '09' and be 11 digits long");

            RuleFor(x => x.Password)
              .NotEmpty()
              .WithMessage("Password Is Required")
              .MaximumLength(18)
              .WithMessage("The length of password must be 18 characters")
              .MinimumLength(8)
              .MinimumLength(8).WithMessage("رمز عبور باید حداقل ۸ کاراکتر باشد.")
              .Matches(@"[A-Z]").WithMessage("رمز عبور باید حداقل یک حرف بزرگ داشته باشد.")
              .Matches(@"[a-z]").WithMessage("رمز عبور باید حداقل یک حرف کوچک داشته باشد.")
              .Matches(@"\d").WithMessage("رمز عبور باید حداقل یک عدد داشته باشد.")
              .Matches(@"[\W_]").WithMessage("رمز عبور باید حداقل یک کاراکتر خاص داشته باشد.")
              .WithMessage("Mobile number must start with '09' and be 10 digits long");

            RuleFor(x => x.Repassword)
                .Equal(x => x.Password)
                .WithMessage("رمز عبور و تکرار آن باید یکسان باشد");
        }
    }
}
