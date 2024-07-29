using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class AddCountFiledForTblOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 21, 1, 57, 735, DateTimeKind.Local).AddTicks(1755));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 20, 53, 9, 30, DateTimeKind.Local).AddTicks(2052));
        }
    }
}
