namespace EShop.Models.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }
    }
}
