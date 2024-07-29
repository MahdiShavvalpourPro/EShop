using System.ComponentModel;

namespace EShop.Models.Dto
{
    public class AddEditProductDto
    {
        public int Id { get; set; }
        [DisplayName("نام محصول")]
        public string Name { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [DisplayName("قیمت")]
        public decimal Price { get; set; }
        [DisplayName("تعداد")]
        public decimal QuantityInStock { get; set; }
        [DisplayName("تصویر کالا")]
        public IFormFile Picture { get; set; }
    }

}
