using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathPropertyCarEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image Path",
                table: "Cars",
                type: "VARCHAR",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image Path",
                table: "Cars");
        }
    }
}
