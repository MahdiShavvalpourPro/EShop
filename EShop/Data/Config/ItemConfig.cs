using EShop.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Config
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(e => e.Price)
                .HasPrecision(18, 2);

            builder.Property(e => e.QuantityInStock)
               .HasPrecision(18, 2);


            builder.HasOne(x => x.product)
                .WithOne(x => x.Item);

        }
    }
}
