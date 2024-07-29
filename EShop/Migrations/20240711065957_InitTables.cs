using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class InitTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersianDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    QuantityInStock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersianDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersianDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersianDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryToProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryToProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryToProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryToProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "ModificationDate", "Name", "PersianDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(5875), "this curse will be asp.net 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core", "1403/04/21" },
                    { 2, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6009), "this curse will be JS Base", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Java Script", "1403/04/21" },
                    { 3, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6201), "hyper text transfer protocol", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Html", "1403/04/21" },
                    { 4, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6331), "high level language", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", "1403/04/21" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "PersianDate", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6567), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1403/04/21", 85000m, 12m },
                    { 2, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1403/04/21", 1200000m, 3m },
                    { 3, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6836), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1403/04/21", 500000m, 7m },
                    { 4, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6965), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1403/04/21", 465200m, 21m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "ItemId", "ModificationDate", "Name", "PersianDate", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7114), "این دوره شامل پروژه عملی است", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دوره پروژه محور JS", "1403/04/21", 150000m },
                    { 2, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7250), "این دوره شامل پروژه عملی است", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دوره پیشرفته Asp", "1403/04/21", 300000m },
                    { 3, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7381), "از هیچی به 100 برس", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مبانی Csharp", "1403/04/21", 0m },
                    { 4, new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7511), "از هیچی به 100 برس", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صفر تا 100 دوره html", "1403/04/21", 95000m }
                });

            migrationBuilder.InsertData(
                table: "CategoryToProducts",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 2, 4, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 1 },
                    { 5, 2, 2 },
                    { 6, 3, 2 },
                    { 7, 1, 1 },
                    { 8, 4, 2 },
                    { 9, 1, 3 },
                    { 10, 2, 3 },
                    { 11, 3, 3 },
                    { 12, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryToProducts_CategoryId",
                table: "CategoryToProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryToProducts_ProductId",
                table: "CategoryToProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ItemId",
                table: "Products",
                column: "ItemId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryToProducts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
