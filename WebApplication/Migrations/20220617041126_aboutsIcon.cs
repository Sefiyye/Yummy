using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class aboutsIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle1",
                table: "AboutLists");

            migrationBuilder.DropColumn(
                name: "Subtitle2",
                table: "AboutLists");

            migrationBuilder.DropColumn(
                name: "Subtitle3",
                table: "AboutLists");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "AboutLists",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "AboutLists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "AboutLists");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "AboutLists");

            migrationBuilder.AddColumn<string>(
                name: "Subtitle1",
                table: "AboutLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle2",
                table: "AboutLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle3",
                table: "AboutLists",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
