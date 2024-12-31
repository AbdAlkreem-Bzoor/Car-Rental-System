using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental.Db.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDateofBirthPropertyV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date of Birth",
                table: "Users",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date of Birth",
                table: "Users",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }
    }
}
