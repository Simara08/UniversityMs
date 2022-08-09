using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityMs.Migrations
{
    public partial class FexriMezunlarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mezunlar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    LeftImg = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ImgTitle = table.Column<string>(nullable: true),
                    ImgDesc = table.Column<string>(nullable: true),
                    WikiLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mezunlar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mezunlar");
        }
    }
}
