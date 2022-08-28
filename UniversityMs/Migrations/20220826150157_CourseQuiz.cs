using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class CourseQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseSectionId",
                table: "CourseQuiz");

            migrationBuilder.AlterColumn<int>(
                name: "SectionCourseStrucId",
                table: "CourseQuiz",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SectionCourseStrucId",
                table: "CourseQuiz",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CourseSectionId",
                table: "CourseQuiz",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
