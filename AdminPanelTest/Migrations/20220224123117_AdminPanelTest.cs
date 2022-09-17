using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminPanelTest.Migrations
{
    public partial class AdminPanelTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_section1s",
                table: "section1s");

            migrationBuilder.RenameTable(
                name: "section1s",
                newName: "Section1ss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section1ss",
                table: "Section1ss",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Section1ss",
                table: "Section1ss");

            migrationBuilder.RenameTable(
                name: "Section1ss",
                newName: "section1s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_section1s",
                table: "section1s",
                column: "Id");
        }
    }
}
