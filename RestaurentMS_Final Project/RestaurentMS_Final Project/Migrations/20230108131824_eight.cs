using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMS_Final_Project.Migrations
{
    public partial class eight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderItemName",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "orders",
                newName: "FinalTotal");

            migrationBuilder.RenameColumn(
                name: "OrderItemPrice",
                table: "OrderDetail",
                newName: "Total");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "OrderDetail",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ItemPrice",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "FinalTotal",
                table: "orders",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "OrderDetail",
                newName: "OrderItemPrice");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "OrderItemName",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
