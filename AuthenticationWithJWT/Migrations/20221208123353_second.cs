using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthenticationWithJWT.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyRole",
                table: "identityAuthDBs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyRole",
                table: "identityAuthDBs");
        }
    }
}
