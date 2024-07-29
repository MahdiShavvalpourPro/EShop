using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class ModifyUserModel_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 54, 31, 676, DateTimeKind.Local).AddTicks(7885));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 51, 14, 864, DateTimeKind.Local).AddTicks(7359));
        }
    }
}
