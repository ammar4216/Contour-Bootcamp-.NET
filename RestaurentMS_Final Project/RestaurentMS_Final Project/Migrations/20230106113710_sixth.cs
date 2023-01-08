using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMS_Final_Project.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuItemPrice",
                table: "OrderItem",
                newName: "OrderItemPrice");

            migrationBuilder.RenameColumn(
                name: "MenuItemName",
                table: "OrderItem",
                newName: "OrderItemName");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "GST",
                table: "orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "GST",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderItemPrice",
                table: "OrderItem",
                newName: "MenuItemPrice");

            migrationBuilder.RenameColumn(
                name: "OrderItemName",
                table: "OrderItem",
                newName: "MenuItemName");
        }
    }
}
