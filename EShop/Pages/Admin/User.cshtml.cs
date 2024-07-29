using EShop.Data;
using EShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EShop.Pages.Admin
{
    public class UserModel : PageModel
    {
        [BindProperty]
        public int UserId { get; set; }
        public IEnumerable<User> Users { get; set; }
        private readonly AppDbContext _context;

        public UserModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Users = _context.Users.ToList();
        }

        public IActionResult OnPostMakeAdmin([FromBody] int id)
        {
            var user = _context.Users.Find(id);
            user.IsAdmin = true;
            _context.SaveChanges();
            return RedirectToPage("/Admin");
        }

        public IActionResult OnPostRemoveAdmin(int userId)
        {
            return RedirectToPage("/Admin");
        }

        public IActionResult OnPostEdit(int userId)
        {
            return RedirectToPage("/Edit", new { id = userId });
        }

        public IActionResult OnPostDelete(int userId)
        {
            return RedirectToPage("/Admin");
        }
    }

}
