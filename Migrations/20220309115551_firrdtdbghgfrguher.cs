using Microsoft.EntityFrameworkCore.Migrations;

namespace sabashop.Migrations
{
    public partial class firrdtdbghgfrguher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Logotitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Logotitles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tbl_Logotitles",
                columns: new[] { "Id", "Logo", "Title" },
                values: new object[] { 1, "default", "Shop" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Logotitles");
        }
    }
}
