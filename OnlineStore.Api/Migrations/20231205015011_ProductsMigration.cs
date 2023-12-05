using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class ProductsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconCSS",
                value: "fa-solid fa-paintbrush");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fa-solid fa-worm", "Garden" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconCSS",
                value: "fa-solid fa-headset");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "IconCSS",
                value: "fa-solid fa-socks");

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[] { 5, "fa-solid fa-book", "Books" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "194 Colors Cosmetic Make up Palette Set Kit with Eyeshadow Blusher Eyebrow Powder Face Concealer,All-in-One High Pigment Powder Pallet Kit with Mirror, Applicators", "/Images/Beauty/Beauty-CosmeticMakeupPalette.png", "Cosmetic Make up palette", 23.99m, 125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Bronzing powder that gives your skin a natural sunkissed look", "/Images/Beauty/Beauty-RimmelLondonNaturalBronzer.png", "Rimmel London Natural Bronzer", 5.97m, 250 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "BEAKEY Diversity Makeup Brushes 12 Pcs Makeup Kit, Premium Synthetic Kabuki Foundation Face Powder Concealers Eyeshadow Blush Brushes Makeup Brush Set, with 2pcs Blender Sponges (Black/Silver)", "/Images/Beauty/Beauty-BEAKEYDiversityMakeupBrushes.png", "BEAKEY Diversity Makeup Brushes 12 Pcs Makeup Kit", 6.78m, 175 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Very black volume mascara with curved silicone brush that has 6 different size bristles for an enhanced look Fan effect, No clumping, No smudging for extra-black volume even on the thinnest lashes. Place the brush at the base of your lashes and slightly twist upward to coat them;", "/Images/Beauty/Beauty-MaybellineNewYorkVolumeMascara.png", "Maybelline New York, Volume Mascara, Lash Sensational, Colour: Very Black, 9.5 mL", 7.07m, 280 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "AOOWU Glitter Powder Spray, Shiny Body Glitter Spray for Women, Highlighter Loose Powder Spray, Shimmer Sparkle Pearl Powder Makeup Spray for Body, Hair, Face and Clothing, Colorful White", "/Images/Beauty/Beauty-GlitterPowderSpray.png", "Glitter Powder Spray", 6.29m, 147 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "A sturdy single plant pot perfect for your latest gardening venture", "/Images/Garden/Garden-SinglePlantPot.png", "Single Plant Pot", 12.0m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "The perfect birthday present for anyone who loves gardening.", "/Images/Garden/Garden-MultipleToolGardeningSet.png", "Multiple tool gardening set", 35.54m, 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "A single garden trowel", "/Images/Garden/Garden-GardenTrowel.png", "Garden Trowel", 4.99m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "The perfect watering can comes in the colour of yellow.", "/Images/Garden/Garden-WateringCan.png", "Watering Can", 14.99m, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Footwear for a rainy day and for puddle splashing.", "/Images/Garden/Garden-WellingtonBoots.png", "Wellington Boots", 65.0m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Airpods the perfect in ear wireless headphones.", "/Images/Electronics/Electronics-AppleAirpods.png", "Apple Airpods (3rd Generation)", 159.0m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "SteelSeries multi system wireless headset.", "/Images/Electronics/Electronics-SteelSeriesArctis.png", "SteelSeries Arctis Nova 7", 129.0m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Razer BlackShark V2 Pro wireless premium gaming headset.", "/Images/Electronics/Electronics-RazerBlackShark.png", "Razer BlackShark V2 Pro", 147.44m, 75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Duracell batteries with reliability for everyday devices.", "/Images/Electronics/Electronics-DuracellPlusAA.png", "Duracell Plus AA Batteries (24 pack)", 20.0m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Fitbit by Google, 7 days battery life.", "/Images/Electronics/Electronics-Fitbit.png", "Fitbit", 139.0m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 4, "Kitten heels are here to stay so stay on trend with our Millionaire slingback courts. This versatile style can be dressed up or down, with the adjustable sling back straps making them comfortable enough to take you from the office to the dancefloor.", "/Images/Shoes/Shoes-MillionairePointCourtKittenHeels.png", "Millionaire Point Court Kitten Heels", 39.99m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 4, "The classic Boston clog by BIRKENSTOCK, designed to wear all year round. The adaptable strap and strong metal buckle, along with foam layered soft footbed make these clogs comfortable for all foot types. With Suede lining and upper and Birko-Flor®, a flawless imitation of real nubuck. This pair has a narrow fit.", "/Images/Shoes/Shoes-BIRKENSTOCKBostonClogs.png", "BIRKENSTOCK Boston Clogs", 115.0m, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Office Monroe derby shoes perfect for smart occasions.", "/Images/Shoes/Shoes-MonroeDerbyShoes.png", "Monroe Derby Shoes", 44.99m, 58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Bronx Daff Buckle Knee High Boots made out of leather and with a rubber sole.", "/Images/Shoes/Shoes-BronxDaffBuckleKneeHighBoots.png", "Bronx Daff Buckle Knee High Boots", 160.0m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Vagabond Shoemakers Kenova Stretch Boots, comfy pull on fit and with a synthetic sole.", "/Images/Shoes/Shoes-VagabondShoemakersKenovaStretchBoots.png", "Vagabond Shoemakers Kenova Stretch Boots", 165.0m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 5, "The ground-breaking second novel from the internationally bestselling author of I AM PILGRIM", "/Images/Books/Books-Yearoflocust.png", "The year of the locust", 16.99m, 33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 5, "Traumatised by the death of a child in her care, top London paediatrician Claire seeks refuge on remote Selkie Island in the wilds of the Irish Sea with her husband Daniel and their baby daughter Kitty. Hidden away in Daniel’s old family home, Claire hopes to be as cut off from her guilt as she is from the mainland, but can she find peace in a place so full of its own secrets?", "/Images/Books/Books-TheIslanders.png", "The Islanders", 6.99m, 64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 5, "I take a deep breath as I pull up to the glass-fronted lodge my ex-mother-in-law, Angela, has booked for her birthday. I didn’t want to come on holiday with my ex-husband and his new wife, but she insisted that me and my children play happy families. It isn’t exactly my idea of fun, but Angela has always been kind to me, and the kids are happy. I try to ignore the snow clouds gathering above. The last thing I want is to be trapped here.", "/Images/Books/Books-TheLodge.png", "The Lodge", 8.99m, 50 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 24, 5, "From the bestselling author of What You Did comes the story of a young couple who are about to discover that in a house full of secrets there’s nowhere to hide…", "/Images/Books/Books-LetMeIn.png", "LET ME IN", 6.99m, 74 },
                    { 25, 5, "Religion is a competitive business in the Discworld. Everyone has their own opinion and their own gods, of every shape and size - all fighting for faith, followers, and a place at the top.", "/Images/Books/Books-SmallGods.png", "Small Gods", 9.19m, 174 },
                    { 26, 5, "We live in an interesting time. Materially, everything is the best it’s ever been—we are freer, healthier and wealthier than any people in human history. Yet, somehow everything seems to be irreparably and horribly f*cked—the planet is warming, governments are failing, economies are collapsing, and everyone is perpetually offended on Twitter. At this moment in history, when we have access to technology, education and communication our ancestors couldn’t even dream of, so many of us come back to an overriding feeling of hopelessness.", "/Images/Books/Books-Everythingisfucked.png", "Everything is F*cked", 11.95m, 201 },
                    { 27, 5, "Same As Ever will arm you with a powerful new ability to think about risk and opportunity, and navigate the uncertainty of the future. When planning for the future, we often ask something like, “What will the economy be doing this time next year?” Or we want to know, “What will be different ten years from now?”", "/Images/Books/Books-Sameasever.png", "Same as ever", 11.99m, 100 },
                    { 28, 5, "At the very heart of all the success and failure I've been exposed to - both my own entrepreneurial journey and through the thousands of interviews I've conducted on my podcast - are a set of principles that can stand the test of time, apply to any industry, and be used by anyone who is search of building something great or becoming someone great.", "/Images/Books/Books-DiaryofCEO.png", "The Diary Of A CEO", 10.00m, 89 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconCSS",
                value: "fas fa-spa");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-couch", "Furniture" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconCSS",
                value: "fas fa-headphones");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "IconCSS",
                value: "fas fa-shoe-prints");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30m, 85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m, 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40m, 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40m, 300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m, 212 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m, 112 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m, 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m, 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m, 73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200m, 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 4, "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120m, 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 4, "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { 4, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50m, 150 });
        }
    }
}
