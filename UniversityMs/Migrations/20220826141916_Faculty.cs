using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class Faculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseSectionId",
                table: "FacultyCourseStruc");

            migrationBuilder.AlterColumn<int>(
                name: "SectionCourseStrucId",
                table: "FacultyCourseStruc",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SectionCourseStrucId",
                table: "FacultyCourseStruc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CourseSectionId",
                table: "FacultyCourseStruc",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
