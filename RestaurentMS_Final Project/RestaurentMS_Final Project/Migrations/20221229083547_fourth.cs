using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMSFinalProject.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenuCategoryDescription",
                table: "menuCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuCategoryDescription",
                table: "menuCategories");
        }
    }
}
