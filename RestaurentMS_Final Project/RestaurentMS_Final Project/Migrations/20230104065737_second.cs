using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMS_Final_Project.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menuCategories_menuItems_MenuItemId",
                table: "menuCategories");

            migrationBuilder.DropIndex(
                name: "IX_menuCategories_MenuItemId",
                table: "menuCategories");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "menuCategories");

            migrationBuilder.CreateIndex(
                name: "IX_menuItems_menuCategoryId",
                table: "menuItems",
                column: "menuCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_menuItems_menuCategories_menuCategoryId",
                table: "menuItems",
                column: "menuCategoryId",
                principalTable: "menuCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menuItems_menuCategories_menuCategoryId",
                table: "menuItems");

            migrationBuilder.DropIndex(
                name: "IX_menuItems_menuCategoryId",
                table: "menuItems");

            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "menuCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_menuCategories_MenuItemId",
                table: "menuCategories",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_menuCategories_menuItems_MenuItemId",
                table: "menuCategories",
                column: "MenuItemId",
                principalTable: "menuItems",
                principalColumn: "Id");
        }
    }
}
