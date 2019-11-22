using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations
{
    public partial class JoinMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Faculty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Course",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_FacultyId",
                table: "Course",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Faculty_FacultyId",
                table: "Course",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Faculty_FacultyId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_FacultyId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Course");
        }
    }
}
