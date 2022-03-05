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
                name: "AutumnPloughing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutumnPloughing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cultivation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultivation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Efficiency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tons = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Efficiency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Farmer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fertilizing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Integrity = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Irrigation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Irrigation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlantPopulation = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seeding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntervalCM = table.Column<long>(type: "bigint", nullable: false),
                    Standart = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seeding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpringPloughing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Depth = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpringPloughing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppliedHA = table.Column<double>(type: "float", nullable: false),
                    Spraying = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<long>(type: "bigint", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FarmerId = table.Column<int>(type: "int", nullable: false),
                    NumberOfField = table.Column<long>(type: "bigint", nullable: false),
                    HA = table.Column<double>(type: "float", nullable: false),
                    AutumnPloughingId = table.Column<int>(type: "int", nullable: false),
                    SpringPloughingId = table.Column<int>(type: "int", nullable: false),
                    SeedingId = table.Column<int>(type: "int", nullable: false),
                    PlantingId = table.Column<int>(type: "int", nullable: false),
                    IrrigationId = table.Column<int>(type: "int", nullable: false),
                    CultivationId = table.Column<int>(type: "int", nullable: false),
                    FertilizingId = table.Column<int>(type: "int", nullable: false),
                    ToppingId = table.Column<int>(type: "int", nullable: false),
                    EfficiencyId = table.Column<int>(type: "int", nullable: false),
                    QualityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Farms_AutumnPloughing_AutumnPloughingId",
                        column: x => x.AutumnPloughingId,
                        principalTable: "AutumnPloughing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Cultivation_CultivationId",
                        column: x => x.CultivationId,
                        principalTable: "Cultivation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Efficiency_EfficiencyId",
                        column: x => x.EfficiencyId,
                        principalTable: "Efficiency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Farmer_FarmerId",
                        column: x => x.FarmerId,
                        principalTable: "Farmer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Fertilizing_FertilizingId",
                        column: x => x.FertilizingId,
                        principalTable: "Fertilizing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Irrigation_IrrigationId",
                        column: x => x.IrrigationId,
                        principalTable: "Irrigation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Planting_PlantingId",
                        column: x => x.PlantingId,
                        principalTable: "Planting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Quality_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Quality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Seeding_SeedingId",
                        column: x => x.SeedingId,
                        principalTable: "Seeding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_SpringPloughing_SpringPloughingId",
                        column: x => x.SpringPloughingId,
                        principalTable: "SpringPloughing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farms_Topping_ToppingId",
                        column: x => x.ToppingId,
                        principalTable: "Topping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Farms");

            migrationBuilder.DropTable(
                name: "AutumnPloughing");

            migrationBuilder.DropTable(
                name: "Cultivation");

            migrationBuilder.DropTable(
                name: "Efficiency");

            migrationBuilder.DropTable(
                name: "Farmer");

            migrationBuilder.DropTable(
                name: "Fertilizing");

            migrationBuilder.DropTable(
                name: "Irrigation");

            migrationBuilder.DropTable(
                name: "Planting");

            migrationBuilder.DropTable(
                name: "Quality");

            migrationBuilder.DropTable(
                name: "Seeding");

            migrationBuilder.DropTable(
                name: "SpringPloughing");

            migrationBuilder.DropTable(
                name: "Topping");
        }
    }
}
