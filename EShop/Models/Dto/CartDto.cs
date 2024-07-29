using EShop.Models.Entities;

namespace EShop.Models.Dto
{
    public class CartDto
    {
        public CartDto()
        {
            CartItems = new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
