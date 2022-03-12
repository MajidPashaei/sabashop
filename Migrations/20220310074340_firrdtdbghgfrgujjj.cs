using Microsoft.EntityFrameworkCore.Migrations;

namespace sabashop.Migrations
{
    public partial class firrdtdbghgfrgujjj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrandFatherId",
                table: "tbl_Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GrandFatherName",
                table: "tbl_Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrandFatherId",
                table: "tbl_Categories");

            migrationBuilder.DropColumn(
                name: "GrandFatherName",
                table: "tbl_Categories");
        }
    }
}
