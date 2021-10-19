using Microsoft.EntityFrameworkCore.Migrations;

namespace M3NCORE_EF.CodeFirst.Migrations
{
    public partial class AddAgeinPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Player");
        }
    }
}
