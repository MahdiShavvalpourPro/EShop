using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 789, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 19, 10, 21, 19, 790, DateTimeKind.Local).AddTicks(803));
        }
    }
}
