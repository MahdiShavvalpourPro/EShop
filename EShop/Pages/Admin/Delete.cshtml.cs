using EShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EShop.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;
        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public int Id { get; set; }
        public async Task<IActionResult> OnPost(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return new JsonResult(new { success = true });
        }
    }
}
