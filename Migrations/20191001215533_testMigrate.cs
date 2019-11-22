using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations
{
    public partial class testMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Faculty_UniversityId",
                table: "Faculty",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_Universities_UniversityId",
                table: "Faculty",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "UniversityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_Universities_UniversityId",
                table: "Faculty");

            migrationBuilder.DropIndex(
                name: "IX_Faculty_UniversityId",
                table: "Faculty");
        }
    }
}
