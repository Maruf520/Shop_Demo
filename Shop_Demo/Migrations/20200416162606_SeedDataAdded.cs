using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_Demo.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pies_Categories_CategoryId",
                table: "pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pies",
                table: "pies");

            migrationBuilder.RenameTable(
                name: "pies",
                newName: "Pies");

            migrationBuilder.RenameIndex(
                name: "IX_pies_CategoryId",
                table: "Pies",
                newName: "IX_Pies_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pies",
                table: "Pies",
                column: "PieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pies",
                table: "Pies");

            migrationBuilder.RenameTable(
                name: "Pies",
                newName: "pies");

            migrationBuilder.RenameIndex(
                name: "IX_Pies_CategoryId",
                table: "pies",
                newName: "IX_pies_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pies",
                table: "pies",
                column: "PieId");

            migrationBuilder.AddForeignKey(
                name: "FK_pies_Categories_CategoryId",
                table: "pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
