using EShop.Data;
using EShop.Data.Repositories;
using EShop.Models.Dto;
using EShop.Models.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EShop.Controllers
{
    public class AccountController : Controller
    {
        #region Constructor

        private readonly IUserRepository _userRepository;

        public AccountController(AppDbContext context, IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion

        #region SingUp

        [HttpPost]
        public IActionResult SingUp(UserSingUpDto userDto)
        {
            if (ModelState.IsValid)
            {
                if (_userRepository.UserExists(userDto.PhoneNumber) == false)
                {
                    _userRepository.AddUser(new Models.Entities.User()
                    {
                        FirstName = userDto.FirstName,
                        LastName = userDto.LastName,
                        Username = userDto.PhoneNumber,
                        Password = userDto.Password,
                        Email = userDto.Email,
                        PhoneNumber = userDto.PhoneNumber
                    });
                    return View("SuccessRegister", userDto);
                }
                else
                {
                    ModelState.AddModelError("PhoneNumber", "کاربری با این شماره قبلا در سایت ثبت نام کرده است");
                    return View(userDto);
                }
            }
            return View(userDto);
        }

        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }

        #endregion

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto model)
        {
            if (!ModelState.IsValid)
                return View();

            var user = _userRepository.Get(model.PhoneNumber, model.Password);
            if (user == null)
            {
                ModelState.AddModelError("Global", "اطلاعات صحیح نمی باشد");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.FirstName+" "+user.LastName),
                new Claim(ClaimTypes.MobilePhone,user.PhoneNumber!),
                new Claim("IsAdmin",user.IsAdmin.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties
            {
                IsPersistent = model.RememberMe
            };

            await HttpContext.SignInAsync(principal, properties);

            return Redirect("/");
        }

        #endregion

        #region Logout

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Account/Login");
        }



        #endregion

    }
}
