using EShop.Data;
using EShop.Models.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EShop.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Products.Include(p => p.Item);

        }

        public void OnPost()
        {
        }

    }
}
