using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental.Db.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    LicensePlate = table.Column<string>(name: "License Plate", type: "VARCHAR", nullable: false),
                    DailyRate = table.Column<decimal>(name: "Daily Rate", type: "DECIMAL(18,2)", nullable: false),
                    IsAvailable = table.Column<bool>(name: "Is Available", type: "BIT", nullable: false, defaultValue: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First Name", type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(320)", maxLength: 320, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone Number", type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    DateofBirth = table.Column<DateOnly>(name: "Date of Birth", type: "DATE", nullable: false),
                    AddressLine1 = table.Column<string>(name: "Address Line 1", type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    AddressLine2 = table.Column<string>(name: "Address Line 2", type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriversLicenseNumber = table.Column<string>(name: "Driver's License Number", type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(name: "Start Date", type: "DATETIME", nullable: false),
                    EndDate = table.Column<DateTime>(name: "End Date", type: "DATETIME", nullable: false),
                    TotalAmount = table.Column<decimal>(name: "Total Amount", type: "DECIMAL(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_License Plate",
                table: "Cars",
                column: "License Plate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_UserId",
                table: "Rentals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
