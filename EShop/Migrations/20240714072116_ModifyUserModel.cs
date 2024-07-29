using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class ModifyUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(5772), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(5910), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6041), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6172), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6410), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6547), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6678), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6810), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6962), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(7096), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(7228), "1403/04/24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(7359), "1403/04/24" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(5875), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6009), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6201), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6331), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6567), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6705), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6836), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(6965), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7114), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7250), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7381), "1403/04/21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "PersianDate" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 57, 200, DateTimeKind.Local).AddTicks(7511), "1403/04/21" });
        }
    }
}
