using EShop.Data;
using EShop.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EShop.Pages.Admin
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public AddEditProductDto ProductDto { get; set; }
        private readonly AppDbContext _context;
        public EditModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            ProductDto = _context.Products
                 .Include(p => p.Item)
                 .Where(x => x.Id == id)
                 .Select(x => new AddEditProductDto()
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Description = x.Description,
                     Price = x.Item.Price,
                     QuantityInStock = x.Item.QuantityInStock
                 })
                 .FirstOrDefault()!;

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var product = _context.Products.Find(ProductDto.Id);
            var item = _context.Items.FirstOrDefault(p => p.Id == product!.ItemId);

            product.Name = ProductDto.Name;
            product.Description = ProductDto.Description;
            item.Price = ProductDto.Price;
            item.QuantityInStock = ProductDto.QuantityInStock;
            if (ProductDto.Picture.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", product.Id + Path.GetExtension(ProductDto.Picture.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ProductDto.Picture.CopyTo(stream);
                }

            }

            _context.SaveChanges();


            return RedirectToPage("Index");
        }

    }
}
