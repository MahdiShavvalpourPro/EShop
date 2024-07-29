using DNTPersianUtils.Core;

namespace EShop.Models.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            PersianDate = DateTime.Now.ToShortPersianDateString();
            CreationDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public string PersianDate { get; set; }
    }
}
