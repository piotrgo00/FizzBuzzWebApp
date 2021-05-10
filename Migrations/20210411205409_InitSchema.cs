using Microsoft.EntityFrameworkCore.Migrations;

namespace zad3FizzBuzzWebApp.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "List1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num = table.Column<int>(nullable: false),
                    Outcome = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "List1");
        }
    }
}
