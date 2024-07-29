using EShop.Models.Dto;
using EShop.Models.Entities;
using FluentValidation;

namespace EShop.Validation
{
    public partial class UserValidationWithEmail : AbstractValidator<UserSingUpWithEmailDto>
    {
        public UserValidationWithEmail()
        {
            //RuleFor(x => x.FirstName)
            //    .NotEmpty()
            //    .WithMessage("FirstName Is Required")
            //    .MaximumLength(100)
            //    .WithMessage("The length of name must be 100 characters");

            //RuleFor(x => x.LastName)
            //    .NotEmpty()
            //    .WithMessage("LastName Is Required")
            //    .MaximumLength(100)
            //    .WithMessage("The length of family must be 100 characters");

            //RuleFor(x => x.PhoneNumber)
            //   //.NotEmpty()
            //   //.WithMessage("PhoneNumber Is Required")
            //   .Length(11)
            //   .WithMessage("The length of mobile must be 11 characters")
            //   .Matches(@"^09\d{9}$")
            //   .WithMessage("Mobile number must start with '09' and be 11 digits long");

            RuleFor(x => x.Email)
               .NotEmpty()
               .WithMessage("Email Is Required")
               .MaximumLength(150)
               .WithMessage("The length of email must be 150 characters")
               .EmailAddress()
               .WithMessage("email is not valid");

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
