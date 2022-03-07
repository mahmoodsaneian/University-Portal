using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityPortal.Migrations
{
    public partial class AddPostColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Post",
                table: "Managers");
        }
    }
}
