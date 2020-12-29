using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeb.Migrations
{
    public partial class What_Are_You_Passonaite_About : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "What_Are_You_Passionate_About",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "What_Are_You_Passionate_About",
                table: "Projects");
        }
    }
}
