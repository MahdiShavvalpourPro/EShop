using EShop.Data;
using EShop.Models.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

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

        public async Task<IActionResult> OnPostMakeAdminAsync([FromBody] MyUserModel model)
        {
            var getUser = _context.Users.Find(model.id);
            getUser.IsAdmin = true;
            _context.SaveChanges();

            var user = User as ClaimsPrincipal;

            var newClaim = new Claim("IsAdmin", getUser.IsAdmin.ToString());

            var oldClaim = user.FindFirst("IsAdmin");

            if (oldClaim != null)
            {
                var identity = user.Identity as ClaimsIdentity;
                identity.RemoveClaim(oldClaim);
                identity.AddClaim(newClaim);
            }

            var authProperties = new AuthenticationProperties { IsPersistent = true };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, user, authProperties);

            return RedirectToPage("/Admin");
        }

        public async Task<IActionResult> OnPostRemoveAdminAsync([FromBody] MyUserModel model)
        {
            var getUser = _context.Users.Find(model.id);
            if (getUser == null)
                return NotFound();
            getUser.IsAdmin = false;
            _context.SaveChanges();

            var user = User as ClaimsPrincipal;

            var newClaim = new Claim("IsAdmin", getUser.IsAdmin.ToString());

            var oldClaim = user.FindFirst("IsAdmin");

            if (oldClaim != null)
            {
                var identity = user.Identity as ClaimsIdentity;
                identity.RemoveClaim(oldClaim);
                identity.AddClaim(newClaim);
            }

            var authProperties = new AuthenticationProperties { IsPersistent = true };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, user, authProperties);

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
        //public static void UpdateClaim(bool item,string claimName, string oldClaimName)
        //{
        //    var user = User as ClaimsPrincipal;

        //    var newClaim = new Claim(claimName, item.ToString());

        //    var oldClaim = user.FindFirst(oldClaimName);

        //    if (oldClaim != null)
        //    {
        //        var identity = user.Identity as ClaimsIdentity;
        //        identity.RemoveClaim(oldClaim);
        //        identity.AddClaim(newClaim);
        //    }

        //    var authProperties = new AuthenticationProperties { IsPersistent = true };
        //    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, user, authProperties);
        //}
        public int id { get; set; }
    }
}
