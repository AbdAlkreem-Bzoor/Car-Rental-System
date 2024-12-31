using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental.Db.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image Path",
                table: "Cars",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End Date", "Start Date" },
                values: new object[] { new DateTime(2025, 1, 4, 12, 48, 52, 320, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 12, 29, 12, 48, 52, 318, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End Date", "Start Date" },
                values: new object[] { new DateTime(2025, 1, 2, 12, 48, 52, 320, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 12, 30, 12, 48, 52, 320, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End Date", "Start Date" },
                values: new object[] { new DateTime(2025, 1, 7, 12, 48, 52, 320, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 12, 31, 12, 48, 52, 320, DateTimeKind.Local).AddTicks(9323) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image Path",
                table: "Cars",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End Date", "Start Date" },
                values: new object[] { new DateTime(2025, 1, 4, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3201), new DateTime(2024, 12, 29, 11, 7, 35, 466, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End Date", "Start Date" },
                values: new object[] { new DateTime(2025, 1, 2, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 12, 30, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End Date", "Start Date" },
                values: new object[] { new DateTime(2025, 1, 7, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 12, 31, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3950) });
        }
    }
}
