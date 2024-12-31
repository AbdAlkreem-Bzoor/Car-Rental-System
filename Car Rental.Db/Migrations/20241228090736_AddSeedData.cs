using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Rental.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date of Birth",
                table: "Users",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start Date",
                table: "Rentals",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End Date",
                table: "Rentals",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<string>(
                name: "License Plate",
                table: "Cars",
                type: "VARCHAR(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Daily Rate", "Image Path", "Is Available", "License Plate", "Manufacturer", "Model", "Type", "Year" },
                values: new object[,]
                {
                    { 1, "Silver", 50m, "", true, "XYZ1234", "Toyota", "Camry", "Sedan", 2020 },
                    { 2, "Black", 45m, "", true, "ABC5678", "Honda", "Civic", "Sedan", 2019 },
                    { 3, "Red", 75m, "", true, "LMN9876", "Ford", "Mustang", "Coupe", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address Line 1", "Address Line 2", "City", "Country", "Date of Birth", "Driver's License Number", "Email", "First Name", "Last Name", "Password", "Phone Number" },
                values: new object[,]
                {
                    { 1, "123 Main St", null, "Amman", "Jordan", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1234567", "john.doe@example.com", "John", "Doe", "password123", "123-456-7890" },
                    { 2, "456 Oak St", "Apt 7", "Cairo", "Egypt", new DateTime(1985, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "B7654321", "jane.smith@example.com", "Jane", "Smith", "password456", "987-654-3210" },
                    { 3, "789 Pine St", null, "Nablus", "Palestine", new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "C2345678", "alice.johnson@example.com", "Alice", "Johnson", "password789", "555-111-2222" }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CarId", "End Date", "Start Date", "Status", "Total Amount", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 4, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3201), new DateTime(2024, 12, 29, 11, 7, 35, 466, DateTimeKind.Local).AddTicks(2328), "Pending", 350m, 1 },
                    { 2, 2, new DateTime(2025, 1, 2, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 12, 30, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3938), "Confirmed", 225m, 2 },
                    { 3, 3, new DateTime(2025, 1, 7, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 12, 31, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3950), "Active", 750m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date of Birth",
                table: "Users",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start Date",
                table: "Rentals",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End Date",
                table: "Rentals",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<string>(
                name: "License Plate",
                table: "Cars",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)");
        }
    }
}
