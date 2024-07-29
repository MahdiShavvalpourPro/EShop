using EShop.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);


            builder.Property(x => x.PersianDate).HasMaxLength(10);

        }
    }
}
