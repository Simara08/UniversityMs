using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class Usererror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DocLogs_DocLogsId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DocTranskript_TranskriptId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DocLogsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TranskriptId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DocLogsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TranskriptId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocLogsId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TranskriptId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DocLogsId",
                table: "AspNetUsers",
                column: "DocLogsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TranskriptId",
                table: "AspNetUsers",
                column: "TranskriptId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DocLogs_DocLogsId",
                table: "AspNetUsers",
                column: "DocLogsId",
                principalTable: "DocLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DocTranskript_TranskriptId",
                table: "AspNetUsers",
                column: "TranskriptId",
                principalTable: "DocTranskript",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
