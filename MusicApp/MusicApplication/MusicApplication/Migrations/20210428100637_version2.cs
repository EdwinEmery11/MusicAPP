using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicApplication.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Albums",
                newName: "Tracks");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Albums",
                newName: "Information");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Albums",
                newName: "Genre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tracks",
                table: "Albums",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "Information",
                table: "Albums",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Albums",
                newName: "Age");
        }
    }
}
