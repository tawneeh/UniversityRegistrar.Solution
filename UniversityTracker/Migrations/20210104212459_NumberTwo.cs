using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityTracker.Migrations
{
    public partial class NumberTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "StudentName");
        }
    }
}
