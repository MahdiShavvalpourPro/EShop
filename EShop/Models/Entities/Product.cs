namespace EShop.Models.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        //public List<Category> Categories { get; set; }



        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }
        public Item Item { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
