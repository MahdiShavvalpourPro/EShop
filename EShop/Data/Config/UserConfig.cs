using EShop.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(100);

            //builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(100);

            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.Username).HasMaxLength(200);

            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(20);

            builder.Property(x => x.PhoneNumber).HasMaxLength(11);

            builder.Property(x => x.Email).HasMaxLength(200);

            builder.Property(x => x.PersianDate).HasMaxLength(10);


        }
    }
}
