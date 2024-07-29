using EShop.Data;
using EShop.Models.Dto;
using EShop.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EShop.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            if (products is null)
            {
                return Content("Product Is Not Exists");
            }
            return View(products);
        }

        [AllowAnonymous]
        public ActionResult Detail(int id)
        {
            var product = _context.Products
                .Include(x => x.Item)
                .SingleOrDefault(x => x.Id == id);

            if (product is null)
                return NotFound();

            var categories = _context.Products
                .Where(x => x.Id == id)
                .SelectMany(c => c.CategoryToProducts)
                .Select(ca => ca.Category)
                .ToList();

            var productDetails = new DetailProduct()
            {
                Product = product,
                Categories = categories
            };

            return View(productDetails);
        }

        public ActionResult AddToCart(int itemId)
        {
            var product = _context.Products.Include(p => p.Item).SingleOrDefault(p => p.ItemId == itemId);
            if (product != null)
            {
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
                var order = _context.Orders.FirstOrDefault(o => o.UserId == userId && !o.IsFinally);
                if (order != null)
                {
                    var orderDetail =
                        _context.OrderDetails.FirstOrDefault(d =>
                            d.OrderId == order.OrderId && d.ProductId == product.Id);
                    if (orderDetail != null)
                    {
                        orderDetail.Count += 1;
                    }
                    else
                    {
                        _context.OrderDetails.Add(new OrderDetail()
                        {
                            OrderId = order.OrderId,
                            ProductId = product.Id,
                            Price = product.Item.Price,
                            Count = 1
                        });
                    }
                }
                else
                {
                    order = new Order()
                    {
                        IsFinally = false,
                        CreateDate = DateTime.Now,
                        UserId = userId
                    };
                    _context.Orders.Add(order);
                    _context.SaveChanges();
                    _context.OrderDetails.Add(new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        ProductId = product.Id,
                        Price = product.Item.Price,
                        Count = 1
                    });
                }

                _context.SaveChanges();
            }
            return RedirectToAction("ShowCart");
        }

        public ActionResult RemoveItemCart(int detailId)
        {
            var orderDetail = _context.OrderDetails.Find(detailId);
            _context.Remove(orderDetail);
            _context.SaveChanges();


            return RedirectToAction("ShowCart");
        }

        public ActionResult ShowCart()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            var order = _context.Orders.Where(o => o.UserId == userId && !o.IsFinally)
                .Include(o => o.OrderDetails)
                .ThenInclude(c => c.Product).FirstOrDefault();
            return View(order);
        }

        [Route("Group/{id}/{name}")]
        public ActionResult ShowProductByGroup(int id, string name)
        {
            var products = _context.CategoryToProducts
              .Where(x => x.CategoryId == id).Include(x => x.Product)
              .Select(x => x.Product)
              .ToList();

            (List<Product>, string) data = (products, name);

            return View(data);
        }


    }
}
