using EShop.Models.Entities;

namespace EShop.Models.Dto
{
    public class DetailProduct
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
