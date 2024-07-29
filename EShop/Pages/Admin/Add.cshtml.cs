using EShop.Data;
using EShop.Models.Dto;
using EShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EShop.Pages.Admin
{
    public class AddModel : PageModel
    {
        private readonly AppDbContext _context;

        public AddModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AddEditProductDto ProductDto { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var item = new Item()
            {
                Price = ProductDto.Price,
                QuantityInStock = ProductDto.QuantityInStock
            };
            _context.Add(item);
            _context.SaveChanges();

            var product = new Product()
            {
                Name = ProductDto.Name,
                Item = item,
                Description = ProductDto.Description
            };
            _context.Add(product);
            _context.SaveChanges();

            product.ItemId = product.Id;
            _context.SaveChanges();

            if (ProductDto.Picture != null && ProductDto.Picture.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", product.Id + Path.GetExtension(ProductDto.Picture.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ProductDto.Picture.CopyTo(stream);
                }

            }

            return RedirectToPage("Index");

        }
    }
}
