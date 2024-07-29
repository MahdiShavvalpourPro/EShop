using EShop.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Config
{
    public partial class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired();
            builder.Property(x => x.Name)
                .HasMaxLength(60);
            builder.Property(x => x.Price)
                .IsRequired();
            builder.Property(x => x.Description).
                HasMaxLength(800);

            builder.Property(e => e.Price)
                .HasPrecision(18, 2);


            builder.Property(x => x.PersianDate)
                .HasMaxLength(10);

        }
    }
}
