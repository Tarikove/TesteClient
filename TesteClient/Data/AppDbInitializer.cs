using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteClient.Data;
using TesteClient.Models;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            context.Database.EnsureCreated();
            //Table Categrorie
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(new List<Category>()
                {

                    new Category()
                    {
                        
                        CategoryName = "Reflex",
                        Description = "Appareils Type 2",

                    },

                    new Category()
                    {
                        
                        CategoryName = "Reflex",
                        Description = "Appareils Type 2",

                    }
                });
                context.SaveChanges();



                if (!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>()
                {

                    new Product()
                    {
                        ProductName = "Canon D750",
                        Description = "Appareil photo Reflex",
                        ImagePath = "EMG\\CanonD750.JPG",
                        UnitPrice = 450,
                        CategoryID = 1
                    },

                    new Product()
                    {
                        ProductName = "Canon D80",
                        Description = "Appareil photo Reflex",
                        ImagePath = "EMG\\Canon80.JPG",
                        UnitPrice = 890,
                        CategoryID = 1,

                    },

                    new Product()
                    {
                        ProductName = "Canon 600",
                        Description = "Appareil photo Reflex",
                        ImagePath = "EMG\\Canon600.JPG",
                        UnitPrice = 400,
                        CategoryID = 1,

                    }
                });
                context.SaveChanges();
            }
                        }
    }
}
}








