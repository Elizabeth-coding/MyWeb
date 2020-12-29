using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeb.Migrations
{
    public partial class Who_Are_You_Making_This_For : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Who_Are_You_Making_This_For",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Who_Are_You_Making_This_For",
                table: "Projects");
        }
    }
}
