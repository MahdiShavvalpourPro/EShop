namespace EShop.Models.Entities
{
    public class CartItem : BaseEntity
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal GetTotalPrice()
        {
            return Item.Price * Quantity;
        }
    }
}
