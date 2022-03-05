using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackathon.Migrations
{
    public partial class ReferencesFix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AppliedHA",
                table: "Cultivations",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NumberOfTimes",
                table: "Cultivations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppliedHA",
                table: "Cultivations");

            migrationBuilder.DropColumn(
                name: "NumberOfTimes",
                table: "Cultivations");
        }
    }
}
