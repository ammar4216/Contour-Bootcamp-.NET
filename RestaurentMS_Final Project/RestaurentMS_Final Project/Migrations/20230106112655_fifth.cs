using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMS_Final_Project.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItemOrder");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "orders");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    ordersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_menuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "menuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_orders_ordersId",
                        column: x => x.ordersId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_MenuItemId",
                table: "OrderItem",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ordersId",
                table: "OrderItem",
                column: "ordersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MenuItemOrder",
                columns: table => new
                {
                    menuItemId = table.Column<int>(type: "int", nullable: false),
                    ordersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemOrder", x => new { x.menuItemId, x.ordersId });
                    table.ForeignKey(
                        name: "FK_MenuItemOrder_menuItems_menuItemId",
                        column: x => x.menuItemId,
                        principalTable: "menuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItemOrder_orders_ordersId",
                        column: x => x.ordersId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemOrder_ordersId",
                table: "MenuItemOrder",
                column: "ordersId");
        }
    }
}
