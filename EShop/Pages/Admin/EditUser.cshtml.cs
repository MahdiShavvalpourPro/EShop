using EShop.Data;
using EShop.Models;
using EShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EShop.Pages.Admin
{
    public class EditUserModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public User User { get; set; }
        public EditUserModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            User = _context.Users.Find(id);
        }

        public IActionResult OnPost()
        {
            var findUser = _context.Users.Find(User.Id);

            findUser.FirstName = User.FirstName;
            findUser.LastName = User.LastName;
            findUser.PhoneNumber = User.PhoneNumber;
            findUser.Email = User.Email;
            findUser.Password = User.Password;

            _context.SaveChanges();

            return RedirectToPage("User");

        }
    }
}
