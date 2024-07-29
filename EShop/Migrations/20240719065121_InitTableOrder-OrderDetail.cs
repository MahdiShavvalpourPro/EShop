using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class InitTableOrderOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFinally = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9143), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9275), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9403), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9548), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9797), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9933), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(64), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(196), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(360), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(493), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(621), "1403/04/29" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(803), "1403/04/29" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(2807), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(2955), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(3088), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(3221), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(3464), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(3632), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(3765), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(3898), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(4059), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(4198), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(4332), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 9, 40, 372, DateTimeKind.Local).AddTicks(4464), "1403/04/24" });
        }
    }
}
