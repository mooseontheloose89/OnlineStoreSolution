using Microsoft.EntityFrameworkCore;
using OnlineStore.Api.Entities;

namespace OnlineStore.Api.Data
{
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Cosmetic Make up palette",
                Description = "194 Colors Cosmetic Make up Palette Set Kit with Eyeshadow Blusher Eyebrow Powder Face Concealer,All-in-One High Pigment Powder Pallet Kit with Mirror, Applicators",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 23.99M,
                Quantity = 125,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Rimmel London Natural Bronzer",
                Description = "Bronzing powder that gives your skin a natural sunkissed look",
                ImageURL = "/Images/Beauty/Beauty2.png",
                Price = 5.97M,
                Quantity = 250,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "BEAKEY Diversity Makeup Brushes 12 Pcs Makeup Kit",
                Description = "BEAKEY Diversity Makeup Brushes 12 Pcs Makeup Kit, Premium Synthetic Kabuki Foundation Face Powder Concealers Eyeshadow Blush Brushes Makeup Brush Set, with 2pcs Blender Sponges (Black/Silver)",
                ImageURL = "/Images/Beauty/Beauty3.png",
                Price = 6.78M,
                Quantity = 175,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Maybelline New York, Volume Mascara, Lash Sensational, Colour: Very Black, 9.5 mL",
                Description = "Very black volume mascara with curved silicone brush that has 6 different size bristles for an enhanced look Fan effect, No clumping, No smudging for extra-black volume even on the thinnest lashes. Place the brush at the base of your lashes and slightly twist upward to coat them;",
                ImageURL = "/Images/Beauty/Beauty4.png",
                Price = 7.07M,
                Quantity = 280,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Glitter Powder Spray",
                Description = "AOOWU Glitter Powder Spray, Shiny Body Glitter Spray for Women, Highlighter Loose Powder Spray, Shimmer Sparkle Pearl Powder Makeup Spray for Body, Hair, Face and Clothing, Colorful White",
                ImageURL = "/Images/Beauty/Beauty5.png",
                Price = 6.29M,
                Quantity = 147,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Single Plant Pot",
                Description = "A sturdy single plant pot perfect for your latest gardening venture",
                ImageURL = "/Images/Garden/Garden1.png",
                Price = 12.0M,
                Quantity = 45,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Multiple tool gardening set",
                Description = "The perfect birthday present for anyone who loves gardening.",
                ImageURL = "/Images/Garden/Garden2.png",
                Price = 35.54M,
                Quantity = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Garden Trowel",
                Description = "A single garden trowel",
                ImageURL = "/Images/Garden/Garden3.png",
                Price = 4.99M,
                Quantity = 23,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Watering Can",
                Description = "The perfect watering can comes in the colour of yellow.",
                ImageURL = "/Images/Garden/Garden4.png",
                Price = 14.99M,
                Quantity = 19,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Wellington Boots",
                Description = "Footwear for a rainy day and for puddle splashing.",
                ImageURL = "/Images/Garden/Garden5.png",
                Price = 65.0M,
                Quantity = 10,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Apple Airpods (3rd Generation)",
                Description = "Airpods the perfect in ear wireless headphones.",
                ImageURL = "/Images/Electronics/Electronic1.png",
                Price = 159.0M,
                Quantity = 25,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "SteelSeries Arctis Nova 7",
                Description = "SteelSeries multi system wireless headset.",
                ImageURL = "/Images/Electronics/Electronic2.png",
                Price = 129.0M,
                Quantity = 45,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Razer BlackShark V2 Pro",
                Description = "Razer BlackShark V2 Pro wireless premium gaming headset.",
                ImageURL = "/Images/Electronics/Electronic3.png",
                Price = 147.44M,
                Quantity = 75,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Duracell Plus AA Batteries (24 pack)",
                Description = "Duracell batteries with reliability for everyday devices.",
                ImageURL = "/Images/Electronics/Electronic4.png",
                Price = 20.0M,
                Quantity = 100,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Fitbit",
                Description = "Fitbit by Google, 7 days battery life.",
                ImageURL = "/Images/Electronics/Electronic5.png",
                Price = 139.0M,
                Quantity = 40,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Millionaire Point Court Kitten Heels",
                Description = "Kitten heels are here to stay so stay on trend with our Millionaire slingback courts. This versatile style can be dressed up or down, with the adjustable sling back straps making them comfortable enough to take you from the office to the dancefloor.",
                ImageURL = "/Images/Shoes/Shoes1.png",
                Price = 39.99M,
                Quantity = 36,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "BIRKENSTOCK Boston Clogs",
                Description = "The classic Boston clog by BIRKENSTOCK, designed to wear all year round. The adaptable strap and strong metal buckle, along with foam layered soft footbed make these clogs comfortable for all foot types. With Suede lining and upper and Birko-Flor®, a flawless imitation of real nubuck. This pair has a narrow fit.",
                ImageURL = "/Images/Shoes/Shoes2.png",
                Price = 115.0M,
                Quantity = 47,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Monroe Derby Shoes",
                Description = "Office Monroe derby shoes perfect for smart occasions.",
                ImageURL = "/Images/Shoes/Shoes3.png",
                Price = 44.99M,
                Quantity = 58,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Bronx Daff Buckle Knee High Boots",
                Description = "Bronx Daff Buckle Knee High Boots made out of leather and with a rubber sole.",
                ImageURL = "/Images/Shoes/Shoes4.png",
                Price = 160.0M,
                Quantity = 25,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Vagabond Shoemakers Kenova Stretch Boots",
                Description = "Vagabond Shoemakers Kenova Stretch Boots, comfy pull on fit and with a synthetic sole.",
                ImageURL = "/Images/Shoes/Shoes5.png",
                Price = 165.0M,
                Quantity = 15,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "The year of the locust",
                Description = "The ground-breaking second novel from the internationally bestselling author of I AM PILGRIM",
                ImageURL = "/Images/Books/Books-Yearoflocust.png",
                Price = 16.99M,
                Quantity = 33,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "The Islanders",
                Description = "Traumatised by the death of a child in her care, top London paediatrician Claire seeks refuge on remote Selkie Island in the wilds of the Irish Sea with her husband Daniel and their baby daughter Kitty. Hidden away in Daniel’s old family home, Claire hopes to be as cut off from her guilt as she is from the mainland, but can she find peace in a place so full of its own secrets?",
                ImageURL = "/Images/Books/Books-TheIslanders.png",
                Price = 6.99M,
                Quantity = 64,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "The Lodge",
                Description = "I take a deep breath as I pull up to the glass-fronted lodge my ex-mother-in-law, Angela, has booked for her birthday. I didn’t want to come on holiday with my ex-husband and his new wife, but she insisted that me and my children play happy families. It isn’t exactly my idea of fun, but Angela has always been kind to me, and the kids are happy. I try to ignore the snow clouds gathering above. The last thing I want is to be trapped here.",
                ImageURL = "/Images/Books/Books-TheLodge.png",
                Price = 8.99M,
                Quantity = 50,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = "LET ME IN",
                Description = "From the bestselling author of What You Did comes the story of a young couple who are about to discover that in a house full of secrets there’s nowhere to hide…",
                ImageURL = "/Images/Books/Books-LetMeIn.png",
                Price = 6.99M,
                Quantity = 74,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 25,
                Name = "Small Gods",
                Description = "Religion is a competitive business in the Discworld. Everyone has their own opinion and their own gods, of every shape and size - all fighting for faith, followers, and a place at the top.",
                ImageURL = "/Images/Books/Books-SmallGods.png",
                Price = 9.19M,
                Quantity = 174,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 26,
                Name = "Everything is F*cked",
                Description = "We live in an interesting time. Materially, everything is the best it’s ever been—we are freer, healthier and wealthier than any people in human history. Yet, somehow everything seems to be irreparably and horribly f*cked—the planet is warming, governments are failing, economies are collapsing, and everyone is perpetually offended on Twitter. At this moment in history, when we have access to technology, education and communication our ancestors couldn’t even dream of, so many of us come back to an overriding feeling of hopelessness.",
                ImageURL = "/Images/Books/Books-Everythingisfucked.png",
                Price = 11.95M,
                Quantity = 201,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 27,
                Name = "Same as ever",
                Description = "Same As Ever will arm you with a powerful new ability to think about risk and opportunity, and navigate the uncertainty of the future. When planning for the future, we often ask something like, “What will the economy be doing this time next year?” Or we want to know, “What will be different ten years from now?”",
                ImageURL = "/Images/Books/Books-Sameasever.png",
                Price = 11.99M,
                Quantity = 100,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 28,
                Name = "The Diary Of A CEO",
                Description = "At the very heart of all the success and failure I've been exposed to - both my own entrepreneurial journey and through the thousands of interviews I've conducted on my podcast - are a set of principles that can stand the test of time, apply to any industry, and be used by anyone who is search of building something great or becoming someone great.",
                ImageURL = "/Images/Books/Books-DiaryofCEO.png",
                Price = 10.00M,
                Quantity = 89,
                CategoryId = 5
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Harry"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sarah"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Beauty",
                IconCSS = "fa-solid fa-paintbrush"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Garden",
                IconCSS = "fa-solid fa-worm"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Electronics",
                IconCSS = "fa-solid fa-headset"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Shoes",
                IconCSS = "fa-solid fa-socks"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 5,
                Name = "Books",
                IconCSS = "fa-solid fa-book"
            });
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
