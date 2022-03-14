using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityPortal.Migrations
{
    public partial class add_noAction_on_teacher_delete2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId",
                table: "ClassRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId1",
                table: "ClassRooms");

            migrationBuilder.DropIndex(
                name: "IX_ClassRooms_TeacherId1",
                table: "ClassRooms");

            migrationBuilder.DropColumn(
                name: "TeacherId1",
                table: "ClassRooms");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId",
                table: "ClassRooms",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId",
                table: "ClassRooms");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId1",
                table: "ClassRooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassRooms_TeacherId1",
                table: "ClassRooms",
                column: "TeacherId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId",
                table: "ClassRooms",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Teachers_TeacherId1",
                table: "ClassRooms",
                column: "TeacherId1",
                principalTable: "Teachers",
                principalColumn: "TeacherId");
        }
    }
}
