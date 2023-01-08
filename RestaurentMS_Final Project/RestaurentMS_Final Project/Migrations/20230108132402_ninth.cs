using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMS_Final_Project.Migrations
{
    public partial class ninth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_menuItems_MenuItemId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_orders_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "orderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderId",
                table: "orderDetail",
                newName: "IX_orderDetail_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_MenuItemId",
                table: "orderDetail",
                newName: "IX_orderDetail_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetail_menuItems_MenuItemId",
                table: "orderDetail",
                column: "MenuItemId",
                principalTable: "menuItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetail_orders_OrderId",
                table: "orderDetail",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetail_menuItems_MenuItemId",
                table: "orderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetail_orders_OrderId",
                table: "orderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail");

            migrationBuilder.RenameTable(
                name: "orderDetail",
                newName: "OrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetail_OrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetail_MenuItemId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_menuItems_MenuItemId",
                table: "OrderDetail",
                column: "MenuItemId",
                principalTable: "menuItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_orders_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
