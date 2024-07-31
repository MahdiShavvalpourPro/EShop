using Microsoft.AspNetCore.Mvc;

namespace EShop.Models.Dto
{
    public class UserSingUpWithEmailDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Repassword { get; set; }
    }

    public class UserSingUpWithPhoneNumberDto
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Repassword { get; set; }
    }

    public class UserSingUpDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Remote("VerifyPhoneNumber", "Account")]
        public string PhoneNumber { get; set; }
        //public string Username { get; set; }
        public string Password { get; set; }
        public string Repassword { get; set; }
    }
    public class UserLoginDto
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

}
