using EShop.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Config
{
    public partial class ProductConfig
    {
        public class CategoryToProductConfig : IEntityTypeConfiguration<CategoryToProduct>
        {
            public void Configure(EntityTypeBuilder<CategoryToProduct> builder)
            {
                builder.HasOne(x => x.Product)
                     .WithMany(x => x.CategoryToProducts);

                builder.HasOne(x => x.Category)
                     .WithMany(x => x.CategoryToProducts);
            }
        }
    }
}
