namespace EShop.Models.Entities
{
    public class CategoryToProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }


        //Navigation Property
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
