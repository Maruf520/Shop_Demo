using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_Demo.Migrations
{
    public partial class firsts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Instock",
                table: "Pies",
                newName: "InStock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InStock",
                table: "Pies",
                newName: "Instock");
        }
    }
}
