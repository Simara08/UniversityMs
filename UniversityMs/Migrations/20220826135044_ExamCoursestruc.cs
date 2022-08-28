using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class ExamCoursestruc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseSectionId",
                table: "ExamCourseStruc");

            migrationBuilder.AlterColumn<int>(
                name: "SectionCourseStrucId",
                table: "ExamCourseStruc",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SectionCourseStrucId",
                table: "ExamCourseStruc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CourseSectionId",
                table: "ExamCourseStruc",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
