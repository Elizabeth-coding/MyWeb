using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeb.Migrations
{
    public partial class What_To_Do : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "What_To_Do",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "What_To_Do",
                table: "Projects");
        }
    }
}
