using Microsoft.EntityFrameworkCore.Migrations;

namespace zad3FizzBuzzWebApp.Migrations
{
    public partial class UserNameListMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "List1",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "List1");
        }
    }
}
