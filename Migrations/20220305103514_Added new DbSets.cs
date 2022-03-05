using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackathon.Migrations
{
    public partial class AddednewDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Farms_AutumnPloughing_AutumnPloughingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Cultivation_CultivationId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Efficiency_EfficiencyId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Farmer_FarmerId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Fertilizing_FertilizingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Irrigation_IrrigationId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Planting_PlantingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Quality_QualityId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Seeding_SeedingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_SpringPloughing_SpringPloughingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Topping_ToppingId",
                table: "Farms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topping",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpringPloughing",
                table: "SpringPloughing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seeding",
                table: "Seeding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quality",
                table: "Quality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planting",
                table: "Planting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Irrigation",
                table: "Irrigation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fertilizing",
                table: "Fertilizing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Farmer",
                table: "Farmer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Efficiency",
                table: "Efficiency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cultivation",
                table: "Cultivation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutumnPloughing",
                table: "AutumnPloughing");

            migrationBuilder.RenameTable(
                name: "Topping",
                newName: "Toppings");

            migrationBuilder.RenameTable(
                name: "SpringPloughing",
                newName: "SpringPloughings");

            migrationBuilder.RenameTable(
                name: "Seeding",
                newName: "Seedings");

            migrationBuilder.RenameTable(
                name: "Quality",
                newName: "Qualities");

            migrationBuilder.RenameTable(
                name: "Planting",
                newName: "Plantings");

            migrationBuilder.RenameTable(
                name: "Irrigation",
                newName: "Irrigations");

            migrationBuilder.RenameTable(
                name: "Fertilizing",
                newName: "Fertilizings");

            migrationBuilder.RenameTable(
                name: "Farmer",
                newName: "Farmers");

            migrationBuilder.RenameTable(
                name: "Efficiency",
                newName: "Efficiencies");

            migrationBuilder.RenameTable(
                name: "Cultivation",
                newName: "Cultivations");

            migrationBuilder.RenameTable(
                name: "AutumnPloughing",
                newName: "AutumnPloughings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpringPloughings",
                table: "SpringPloughings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seedings",
                table: "Seedings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qualities",
                table: "Qualities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plantings",
                table: "Plantings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Irrigations",
                table: "Irrigations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fertilizings",
                table: "Fertilizings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Farmers",
                table: "Farmers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Efficiencies",
                table: "Efficiencies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cultivations",
                table: "Cultivations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutumnPloughings",
                table: "AutumnPloughings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_AutumnPloughings_AutumnPloughingId",
                table: "Farms",
                column: "AutumnPloughingId",
                principalTable: "AutumnPloughings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Cultivations_CultivationId",
                table: "Farms",
                column: "CultivationId",
                principalTable: "Cultivations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Efficiencies_EfficiencyId",
                table: "Farms",
                column: "EfficiencyId",
                principalTable: "Efficiencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Farmers_FarmerId",
                table: "Farms",
                column: "FarmerId",
                principalTable: "Farmers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Fertilizings_FertilizingId",
                table: "Farms",
                column: "FertilizingId",
                principalTable: "Fertilizings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Irrigations_IrrigationId",
                table: "Farms",
                column: "IrrigationId",
                principalTable: "Irrigations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Plantings_PlantingId",
                table: "Farms",
                column: "PlantingId",
                principalTable: "Plantings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Qualities_QualityId",
                table: "Farms",
                column: "QualityId",
                principalTable: "Qualities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Seedings_SeedingId",
                table: "Farms",
                column: "SeedingId",
                principalTable: "Seedings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_SpringPloughings_SpringPloughingId",
                table: "Farms",
                column: "SpringPloughingId",
                principalTable: "SpringPloughings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Toppings_ToppingId",
                table: "Farms",
                column: "ToppingId",
                principalTable: "Toppings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Farms_AutumnPloughings_AutumnPloughingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Cultivations_CultivationId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Efficiencies_EfficiencyId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Farmers_FarmerId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Fertilizings_FertilizingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Irrigations_IrrigationId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Plantings_PlantingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Qualities_QualityId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Seedings_SeedingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_SpringPloughings_SpringPloughingId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Toppings_ToppingId",
                table: "Farms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpringPloughings",
                table: "SpringPloughings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seedings",
                table: "Seedings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qualities",
                table: "Qualities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plantings",
                table: "Plantings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Irrigations",
                table: "Irrigations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fertilizings",
                table: "Fertilizings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Farmers",
                table: "Farmers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Efficiencies",
                table: "Efficiencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cultivations",
                table: "Cultivations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutumnPloughings",
                table: "AutumnPloughings");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "Topping");

            migrationBuilder.RenameTable(
                name: "SpringPloughings",
                newName: "SpringPloughing");

            migrationBuilder.RenameTable(
                name: "Seedings",
                newName: "Seeding");

            migrationBuilder.RenameTable(
                name: "Qualities",
                newName: "Quality");

            migrationBuilder.RenameTable(
                name: "Plantings",
                newName: "Planting");

            migrationBuilder.RenameTable(
                name: "Irrigations",
                newName: "Irrigation");

            migrationBuilder.RenameTable(
                name: "Fertilizings",
                newName: "Fertilizing");

            migrationBuilder.RenameTable(
                name: "Farmers",
                newName: "Farmer");

            migrationBuilder.RenameTable(
                name: "Efficiencies",
                newName: "Efficiency");

            migrationBuilder.RenameTable(
                name: "Cultivations",
                newName: "Cultivation");

            migrationBuilder.RenameTable(
                name: "AutumnPloughings",
                newName: "AutumnPloughing");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topping",
                table: "Topping",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpringPloughing",
                table: "SpringPloughing",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seeding",
                table: "Seeding",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quality",
                table: "Quality",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planting",
                table: "Planting",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Irrigation",
                table: "Irrigation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fertilizing",
                table: "Fertilizing",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Farmer",
                table: "Farmer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Efficiency",
                table: "Efficiency",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cultivation",
                table: "Cultivation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutumnPloughing",
                table: "AutumnPloughing",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_AutumnPloughing_AutumnPloughingId",
                table: "Farms",
                column: "AutumnPloughingId",
                principalTable: "AutumnPloughing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Cultivation_CultivationId",
                table: "Farms",
                column: "CultivationId",
                principalTable: "Cultivation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Efficiency_EfficiencyId",
                table: "Farms",
                column: "EfficiencyId",
                principalTable: "Efficiency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Farmer_FarmerId",
                table: "Farms",
                column: "FarmerId",
                principalTable: "Farmer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Fertilizing_FertilizingId",
                table: "Farms",
                column: "FertilizingId",
                principalTable: "Fertilizing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Irrigation_IrrigationId",
                table: "Farms",
                column: "IrrigationId",
                principalTable: "Irrigation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Planting_PlantingId",
                table: "Farms",
                column: "PlantingId",
                principalTable: "Planting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Quality_QualityId",
                table: "Farms",
                column: "QualityId",
                principalTable: "Quality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Seeding_SeedingId",
                table: "Farms",
                column: "SeedingId",
                principalTable: "Seeding",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_SpringPloughing_SpringPloughingId",
                table: "Farms",
                column: "SpringPloughingId",
                principalTable: "SpringPloughing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Topping_ToppingId",
                table: "Farms",
                column: "ToppingId",
                principalTable: "Topping",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
