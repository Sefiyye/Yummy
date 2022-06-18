using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class sliderTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle1",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Subtitle2",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "Subtitle1",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle2",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
