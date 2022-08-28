using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depfaculty_Program_UniProgramId",
                table: "Depfaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_DepUser_Program_UniProgramId",
                table: "DepUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SemOffering_Program_UniProgramId",
                table: "SemOffering");

            migrationBuilder.DropIndex(
                name: "IX_SemOffering_UniProgramId",
                table: "SemOffering");

            migrationBuilder.DropIndex(
                name: "IX_DepUser_UniProgramId",
                table: "DepUser");

            migrationBuilder.DropIndex(
                name: "IX_Depfaculty_UniProgramId",
                table: "Depfaculty");

            migrationBuilder.DropColumn(
                name: "UniProgramId",
                table: "SemOffering");

            migrationBuilder.DropColumn(
                name: "IsDaleted",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "UniProgramId",
                table: "DepUser");

            migrationBuilder.DropColumn(
                name: "UniProgramId",
                table: "Depfaculty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniProgramId",
                table: "SemOffering",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDaleted",
                table: "Program",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UniProgramId",
                table: "DepUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UniProgramId",
                table: "Depfaculty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SemOffering_UniProgramId",
                table: "SemOffering",
                column: "UniProgramId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepUser_UniProgramId",
                table: "DepUser",
                column: "UniProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Depfaculty_UniProgramId",
                table: "Depfaculty",
                column: "UniProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Depfaculty_Program_UniProgramId",
                table: "Depfaculty",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepUser_Program_UniProgramId",
                table: "DepUser",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SemOffering_Program_UniProgramId",
                table: "SemOffering",
                column: "UniProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
