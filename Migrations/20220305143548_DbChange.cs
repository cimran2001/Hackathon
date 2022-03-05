using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackathon.Migrations
{
    public partial class DbChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AppliedHA",
                table: "Irrigations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "NumberOfTimes",
                table: "Irrigations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppliedHA",
                table: "Irrigations");

            migrationBuilder.DropColumn(
                name: "NumberOfTimes",
                table: "Irrigations");
        }
    }
}
