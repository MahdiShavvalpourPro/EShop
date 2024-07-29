namespace EShop.Models.Entities
{
    public class Item : BaseEntity
    {
        public decimal Price { get; set; }
        public decimal QuantityInStock { get; set; }

        

        public Product product { get; set; }

    }
}
