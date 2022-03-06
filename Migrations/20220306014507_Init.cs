using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackathon.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutumnPloughings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Depth = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutumnPloughings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Constants",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cultivations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    NumberOfTimes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultivations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Efficiencies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tons = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Efficiencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Farmers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fertilizings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Integrity = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Irrigations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    NumberOfTimes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Irrigations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plantings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlantPopulation = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seedings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntervalCM = table.Column<long>(type: "bigint", nullable: false),
                    Standart = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seedings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpringPloughings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Depth = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpringPloughings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Spraying = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FarmerId = table.Column<long>(type: "bigint", nullable: true),
                    NumberOfFields = table.Column<long>(type: "bigint", nullable: false),
                    HA = table.Column<double>(type: "float", nullable: false),
                    AutumnPloughingId = table.Column<long>(type: "bigint", nullable: true),
                    SpringPloughingId = table.Column<long>(type: "bigint", nullable: true),
                    SeedingId = table.Column<long>(type: "bigint", nullable: true),
                    PlantingId = table.Column<long>(type: "bigint", nullable: true),
                    IrrigationId = table.Column<long>(type: "bigint", nullable: true),
                    CultivationId = table.Column<long>(type: "bigint", nullable: true),
                    FertilizingId = table.Column<long>(type: "bigint", nullable: true),
                    ToppingId = table.Column<long>(type: "bigint", nullable: true),
                    EfficiencyId = table.Column<long>(type: "bigint", nullable: true),
                    QualityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Farms_AutumnPloughings_AutumnPloughingId",
                        column: x => x.AutumnPloughingId,
                        principalTable: "AutumnPloughings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Cultivations_CultivationId",
                        column: x => x.CultivationId,
                        principalTable: "Cultivations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Efficiencies_EfficiencyId",
                        column: x => x.EfficiencyId,
                        principalTable: "Efficiencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Farmers_FarmerId",
                        column: x => x.FarmerId,
                        principalTable: "Farmers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Fertilizings_FertilizingId",
                        column: x => x.FertilizingId,
                        principalTable: "Fertilizings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Irrigations_IrrigationId",
                        column: x => x.IrrigationId,
                        principalTable: "Irrigations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Plantings_PlantingId",
                        column: x => x.PlantingId,
                        principalTable: "Plantings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Qualities_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Qualities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Seedings_SeedingId",
                        column: x => x.SeedingId,
                        principalTable: "Seedings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_SpringPloughings_SpringPloughingId",
                        column: x => x.SpringPloughingId,
                        principalTable: "SpringPloughings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Farms_Toppings_ToppingId",
                        column: x => x.ToppingId,
                        principalTable: "Toppings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Farms_AutumnPloughingId",
                table: "Farms",
                column: "AutumnPloughingId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_CultivationId",
                table: "Farms",
                column: "CultivationId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_EfficiencyId",
                table: "Farms",
                column: "EfficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_FarmerId",
                table: "Farms",
                column: "FarmerId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_FertilizingId",
                table: "Farms",
                column: "FertilizingId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_IrrigationId",
                table: "Farms",
                column: "IrrigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_PlantingId",
                table: "Farms",
                column: "PlantingId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_QualityId",
                table: "Farms",
                column: "QualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_SeedingId",
                table: "Farms",
                column: "SeedingId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_SpringPloughingId",
                table: "Farms",
                column: "SpringPloughingId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_ToppingId",
                table: "Farms",
                column: "ToppingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constants");

            migrationBuilder.DropTable(
                name: "Farms");

            migrationBuilder.DropTable(
                name: "AutumnPloughings");

            migrationBuilder.DropTable(
                name: "Cultivations");

            migrationBuilder.DropTable(
                name: "Efficiencies");

            migrationBuilder.DropTable(
                name: "Farmers");

            migrationBuilder.DropTable(
                name: "Fertilizings");

            migrationBuilder.DropTable(
                name: "Irrigations");

            migrationBuilder.DropTable(
                name: "Plantings");

            migrationBuilder.DropTable(
                name: "Qualities");

            migrationBuilder.DropTable(
                name: "Seedings");

            migrationBuilder.DropTable(
                name: "SpringPloughings");

            migrationBuilder.DropTable(
                name: "Toppings");
        }
    }
}
