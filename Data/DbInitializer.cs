using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            string adminpass = "qwe123";
            byte[] EncDataByte = new byte[adminpass.Length];
            EncDataByte = System.Text.Encoding.UTF8.GetBytes(adminpass);
            string EncryptedPassword = Convert.ToBase64String(EncDataByte);
            if (context.Users.Where(m => m.Email.Equals("admin@admin.com")).ToList().Count() <= 0)
            {
                context.Users.Add(new User() { Email = "admin@admin.com", Password = EncryptedPassword, Role = "Admin", Phone = "123456789" , isVerified=1});
                context.SaveChanges();
            }
            if (context.Products.ToList().Count()<=0)
            {
                Product slimGallon = new Product();
                slimGallon.BaseImage = new ProductBaseImage() { Path = "~/images/slim.jpg", Product = slimGallon };
                slimGallon.BaseName = $"Slim Gallon (Container Only)";
                slimGallon.Description = "Slim Gallon is the standard sized container good for everyone. This is container only.";
                slimGallon.BasePrice = 130.00;
                slimGallon.Category = Utilities.ProductCategory.WithNoWater;
                slimGallon.IsActive = true;
                slimGallon.Stocks = 50;
                slimGallon.Cost = 100;
                context.Products.Add(slimGallon);


                Product slimGallonWithWater = new Product();
                slimGallonWithWater.BaseImage = new ProductBaseImage() { Path = "~/images/slim.jpg", Product = slimGallonWithWater };
                slimGallonWithWater.BaseName = $"Slim Gallon (With Water)";
                slimGallonWithWater.Description = "Slim Gallon is the standard sized container good for everyone. This is filled with water.";
                slimGallonWithWater.BasePrice = 150.00;
                slimGallonWithWater.Category = Utilities.ProductCategory.WithWater;
                slimGallonWithWater.IsActive = true;
                slimGallonWithWater.Stocks = 50;
                slimGallonWithWater.Cost = 130;
                context.Products.Add(slimGallonWithWater);

                Product waterSlimGallon = new Product();
                waterSlimGallon.BaseImage = new ProductBaseImage() { Path = "~/images/slim.jpg", Product = waterSlimGallon };
                waterSlimGallon.BaseName = $"Refill for Slim Gallon";
                waterSlimGallon.Description = "Slim Gallon is the standard sized container good for everyone. This is water refill for slim gallon.";
                waterSlimGallon.BasePrice = 20.00;
                waterSlimGallon.Category = Utilities.ProductCategory.WithWater;
                waterSlimGallon.IsActive = true;
                waterSlimGallon.Stocks = 50;
                waterSlimGallon.Cost = 10;
                context.Products.Add(waterSlimGallon);

                Product roundGallon = new Product();
                roundGallon.BaseImage = new ProductBaseImage() { Path = "~/images/round.jpg", Product = roundGallon };
                roundGallon.BaseName = $"Round Gallon (Container Only)";
                roundGallon.Description = "Round Gallon is the standard sized container good for everyone. This is container only.";
                roundGallon.BasePrice = 100.00;
                roundGallon.Category = Utilities.ProductCategory.WithNoWater;
                roundGallon.IsActive = true;
                roundGallon.Stocks = 50;
                roundGallon.Cost = 80;
                context.Products.Add(roundGallon);

                Product roundGallonWithWater = new Product();
                roundGallonWithWater.BaseImage = new ProductBaseImage() { Path = "~/images/round.jpg", Product = roundGallonWithWater };
                roundGallonWithWater.BaseName = $"Round Gallon (With Water)";
                roundGallonWithWater.Description = "Round Gallon is the standard sized container good for everyone. This is filled with water.";
                roundGallonWithWater.BasePrice = 120.00;
                roundGallonWithWater.Category = Utilities.ProductCategory.WithWater;
                roundGallonWithWater.IsActive = true;
                roundGallonWithWater.Stocks = 50;
                roundGallonWithWater.Cost = 100;
                context.Products.Add(roundGallonWithWater);

                Product waterRoundGallon = new Product();
                waterRoundGallon.BaseImage = new ProductBaseImage() { Path = "~/images/round.jpg", Product = waterRoundGallon };
                waterRoundGallon.BaseName = $"Refill for Round Gallon";
                waterRoundGallon.Description = "Round Gallon is the standard sized container good for everyone. This is water refill for round gallon.";
                waterRoundGallon.BasePrice = 20.00;
                waterRoundGallon.Category = Utilities.ProductCategory.WithWater;
                waterRoundGallon.IsActive = true;
                waterRoundGallon.Stocks = 50;
                waterRoundGallon.Cost = 10;
                context.Products.Add(waterRoundGallon);

                Product waterBottle350ml = new Product();
                waterBottle350ml.BaseImage = new ProductBaseImage() { Path = "~/images/waterbottle.jpg", Product = waterBottle350ml };
                waterBottle350ml.BaseName = $"Plastic Water Bottle 350 mL";
                waterBottle350ml.Description = "Standard small sized water bottle filled with mineral water. Good for summer!";
                waterBottle350ml.BasePrice = 4.50;
                waterBottle350ml.Category = Utilities.ProductCategory.Small;
                waterBottle350ml.IsActive = true;
                waterBottle350ml.Stocks = 50;
                waterBottle350ml.Cost = 2.5;
                context.Products.Add(waterBottle350ml);

                Product waterBottle500ml = new Product();
                waterBottle500ml.BaseImage = new ProductBaseImage() { Path = "~/images/waterbottle.jpg", Product = waterBottle500ml };
                waterBottle500ml.BaseName = $"Plastic Water Bottle 500 mL";
                waterBottle500ml.Description = "Standard medium sized water bottle filled with mineral water. Good for summer!";
                waterBottle500ml.BasePrice = 6;
                waterBottle500ml.Category = Utilities.ProductCategory.Medium;
                waterBottle500ml.IsActive = true;
                waterBottle500ml.Stocks = 50;
                waterBottle500ml.Cost = 3;
                context.Products.Add(waterBottle500ml);

                Product waterBottle1L = new Product();
                waterBottle1L.BaseImage = new ProductBaseImage() { Path = "~/images/waterbottle.jpg", Product = waterBottle1L };
                waterBottle1L.BaseName = $"Plastic Water Bottle 1Liter";
                waterBottle1L.Description = "Standard large sized water bottle filled with mineral water. Good for summer!";
                waterBottle1L.BasePrice = 10;
                waterBottle1L.Category = Utilities.ProductCategory.Large;
                waterBottle1L.IsActive = true;
                waterBottle1L.Stocks = 50;
                waterBottle1L.Cost = 5;
                context.Products.Add(waterBottle1L);

                Product bigCap = new Product();
                bigCap.BaseImage = new ProductBaseImage() { Path = "~/images/bigcap.png", Product = bigCap };
                bigCap.BaseName = $"Big Cap";
                bigCap.Description = "Big cap for slim gallons. You'll never be missing a cap for your water! Ensures water is clean all the time!";
                bigCap.BasePrice = 10;
                bigCap.Category = Utilities.ProductCategory.Large;
                bigCap.IsActive = true;
                bigCap.Stocks = 50;
                bigCap.Cost = 5;
                context.Products.Add(bigCap);

                Product smallCap = new Product();
                smallCap.BaseImage = new ProductBaseImage() { Path = "~/images/smallcap.jpg", Product = smallCap };
                smallCap.BaseName = $"Small Cap";
                smallCap.Description = "Small cap for slim gallons. You'll never be missing a cap for your water! Ensures water is clean all the time!";
                smallCap.BasePrice = 5;
                smallCap.Category = Utilities.ProductCategory.Small;
                smallCap.IsActive = true;
                smallCap.Stocks = 50;
                smallCap.Cost = 2.5;
                context.Products.Add(smallCap);
            }
           
            context.SaveChanges();
        }
    }
}