using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8449.CodeEsTEAM.WebApp.Migrations
{
    public partial class LinkToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkName",
                table: "Courses");
        }
    }
}
