using Microsoft.EntityFrameworkCore.Migrations;

namespace sabashop.Migrations
{
    public partial class firrdtdbt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "tbl_Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "tbl_Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "tbl_Users");

            migrationBuilder.DropColumn(
                name: "State",
                table: "tbl_Users");
        }
    }
}
