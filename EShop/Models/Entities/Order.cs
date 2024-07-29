using System.ComponentModel.DataAnnotations;

namespace EShop.Models.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public bool IsFinally { get; set; }


        public User Users { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }



    }
}
