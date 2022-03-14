using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityPortal.Migrations
{
    public partial class add_teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "ClassRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ClassRooms_TeacherId",
                table: "ClassRooms",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId",
                table: "ClassRooms",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId",
                table: "ClassRooms");

            migrationBuilder.DropIndex(
                name: "IX_ClassRooms_TeacherId",
                table: "ClassRooms");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "ClassRooms");
        }
    }
}
