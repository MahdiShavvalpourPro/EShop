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

        public IActionResult OnPostMakeAdmin([FromBody] MyUserModel model)
        {
            var user = _context.Users.Find(model.id);
            user.IsAdmin = true;
            _context.SaveChanges();
            return RedirectToPage("/Admin");
        }

        public IActionResult OnPostRemoveAdmin([FromBody] MyUserModel model)
        {
            var user = _context.Users.Find(model.id);
            if (user == null)
                return NotFound();
            user.IsAdmin = false;
            _context.SaveChanges();
            return RedirectToPage("/Admin");
        }

        public IActionResult OnPostEdit(int userId)
        {
            return RedirectToPage("/Edit", new { id = userId });
        }

        public IActionResult OnPostDelete([FromBody] MyUserModel model)
        {
            var user = _context.Users.Find(model.id);
            if (user == null)
                return NotFound();
            _context.Remove(user);
            _context.SaveChanges();
            return RedirectToPage("/Admin");
        }
    }
    public class MyUserModel
    {
        public int id { get; set; }
    }
}
