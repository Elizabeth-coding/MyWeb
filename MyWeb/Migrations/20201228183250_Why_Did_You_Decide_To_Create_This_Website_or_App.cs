using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeb.Migrations
{
    public partial class Why_Did_You_Decide_To_Create_This_Website_or_App : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Why_Did_You_Decide_To_Create_This_Website_or_App",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Why_Did_You_Decide_To_Create_This_Website_or_App",
                table: "Projects");
        }
    }
}
