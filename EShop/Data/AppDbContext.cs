using EShop.Data.Config;
using EShop.Models.Entities;
using Microsoft.EntityFrameworkCore;
using static EShop.Data.Config.ProductConfig;

namespace EShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ItemConfig());
            modelBuilder.ApplyConfiguration(new CategoryToProductConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            #region Seed Data
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Asp.Net Core",
                    Description = "this curse will be asp.net 8"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Java Script",
                    Description = "this curse will be JS Base"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Html",
                    Description = "hyper text transfer protocol"
                },
                new Category()
                {
                    Id = 4,
                    Name = "C#",
                    Description = "high level language"
                }
                );

            modelBuilder.Entity<Item>().HasData(
       new Item()
       {
           Id = 1,
           Price = 85000m,
           QuantityInStock = 12,
       },
       new Item()
       {
           Id = 2,
           Price = 1200000m,
           QuantityInStock = 3,
       },
       new Item()
       {
           Id = 3,
           Price = 500000m,
           QuantityInStock = 7,
       },
       new Item()
       {
           Id = 4,
           Price = 465200m,
           QuantityInStock = 21,
       }
   );

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 1,
                ItemId = 2,
                Name = "دوره پروژه محور JS",
                Price = 150000,
                Description = "این دوره شامل پروژه عملی است"
            }, new Product()
            {
                Id = 2,
                ItemId = 1,
                Name = "دوره پیشرفته Asp",
                Price = 300000,
                Description = "این دوره شامل پروژه عملی است"
            }, new Product()
            {
                Id = 3,
                ItemId = 4,
                Name = "مبانی Csharp",
                Price = 0,
                Description = "از هیچی به 100 برس"
            }, new Product()
            {
                Id = 4,
                ItemId = 3,
                Name = "صفر تا 100 دوره html",
                Price = 95000,
                Description = "از هیچی به 100 برس"
            });


            modelBuilder.Entity<CategoryToProduct>().HasData(
                new CategoryToProduct() { Id = 1, CategoryId = 3, ProductId = 1 },
                new CategoryToProduct() { Id = 2, CategoryId = 4, ProductId = 1 },
                new CategoryToProduct() { Id = 3, CategoryId = 1, ProductId = 2 },
                new CategoryToProduct() { Id = 4, CategoryId = 2, ProductId = 1 },
                new CategoryToProduct() { Id = 5, CategoryId = 2, ProductId = 2 },
                new CategoryToProduct() { Id = 6, CategoryId = 3, ProductId = 2 },
                new CategoryToProduct() { Id = 7, CategoryId = 1, ProductId = 1 },
                new CategoryToProduct() { Id = 8, CategoryId = 4, ProductId = 2 },
                new CategoryToProduct() { Id = 9, CategoryId = 1, ProductId = 3 },
                new CategoryToProduct() { Id = 10, CategoryId = 2, ProductId = 3 },
                new CategoryToProduct() { Id = 11, CategoryId = 3, ProductId = 3 },
                new CategoryToProduct() { Id = 12, CategoryId = 4, ProductId = 3 });


            #endregion
            //modelBuilder.ApplyConfiguration(new BaseEntityConfig());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }
        //public DbSet<Cart> Carts { get; set; }




    }
}
