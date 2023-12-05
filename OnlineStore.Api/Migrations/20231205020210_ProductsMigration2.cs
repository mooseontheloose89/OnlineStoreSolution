using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class ProductsMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-MakeupPalette.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-RimmelBronzer.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-BeakeyBrushSet.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-MaybellineMascara.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-GlitterSpray.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/Garden/Garden-PlantPot.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/Garden/Garden-ToolSet.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/Garden/Garden-Trowel.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/Images/Electronics/Headphones-AppleAirpods.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/Images/Electronics/Headphones-SteelSeriesArctis.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "/Images/Electronics/Headphones-RazerBlackShark.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "/Images/Electronics/Battery-DuracellPlusAA.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "/Images/Electronics/Watch-Fitbit.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-KittenHeels.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-BirkenstockClogs.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-MonroeDerby.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-Bronx.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-Vagabond.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-CosmeticMakeupPalette.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-RimmelLondonNaturalBronzer.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-BEAKEYDiversityMakeupBrushes.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-MaybellineNewYorkVolumeMascara.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty-GlitterPowderSpray.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/Garden/Garden-SinglePlantPot.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/Garden/Garden-MultipleToolGardeningSet.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/Garden/Garden-GardenTrowel.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/Images/Electronics/Electronics-AppleAirpods.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/Images/Electronics/Electronics-SteelSeriesArctis.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "/Images/Electronics/Electronics-RazerBlackShark.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "/Images/Electronics/Electronics-DuracellPlusAA.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "/Images/Electronics/Electronics-Fitbit.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-MillionairePointCourtKittenHeels.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-BIRKENSTOCKBostonClogs.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-MonroeDerbyShoes.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-BronxDaffBuckleKneeHighBoots.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes-VagabondShoemakersKenovaStretchBoots.png");
        }
    }
}
