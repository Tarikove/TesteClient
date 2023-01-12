using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TesteClient.Data;
using TesteClient.Models;
using TesteClient.Models.Products;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            context.Database.EnsureCreated();
            //Table Categrorie
            //if (!context.Categories.Any())
            //{
            //    context.Categories.AddRange(new List<Category>()
            //    {

            //        new Category()
            //        {

            //            CategoryName = "Reflex",
            //            Description = "Appareils Type 2",

            //        },

            //        new Category()
            //        {

            //            CategoryName = "Reflex",
            //            Description = "Appareils Type 2",

            //        }
            //    });
            //    context.SaveChanges();



            if (!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>()
                {

                    new Product()
                    {
                        name = "Canon D80",
                        productTechnoId =1,
                        productBrandId=1,
                        price=1200,
                        productDetailsId=1

                    },

                    new Product()
                    {
                        name = "Canon D80",
                        productTechnoId = 1,
                        productBrandId=1,
                        price=1400,
                        productDetailsId=1

                    }
                });
                context.SaveChanges();
            }

            int ICivility = 1;

            if (!context.ApplicationUser.Any())

            {
                context.ApplicationUser.AddRange(new List<ApplicationUser>()
                            {

                        new ApplicationUser()
                                {
                                    UserName = "Admin",
                                    PasswordHash = "Admin@2022",
                                    Email = "Admin@gmail.com",
                                    EmailConfirmed = true,
                                    PhoneNumber = "0666631345",
                                    PhoneNumberConfirmed = true,
                                    Civility = (ApplicationUser.eCivility)ICivility,
                                    LastName = "Tarik",
                                    FirstName = "Aliouchouche",
                                    BirthDate = new DateTime(05/08/1971),
                                },

                        new ApplicationUser()
                                {
                                    UserName = "Admin",
                                    PasswordHash = "Admin1@2022",
                                    Email = "Admin1@gmail.com",
                                    EmailConfirmed = true,
                                    PhoneNumber = "0666631333",
                                    PhoneNumberConfirmed = true,
                                    Civility = (ApplicationUser.eCivility)ICivility,
                                    LastName = "Jeans Pierre",
                                    FirstName = "Moula",
                                    BirthDate = new DateTime(10/10/1977),
                                }
                                });
                context.SaveChanges();
            }




            ////-------- Application User

            //Workbook wb = new Workbook("D:\\Ecommerce.xlsx");
            //WorksheetCollection collection = wb.Worksheets;
            ////Application User




            //for (int worksheetIndex = 0; worksheetIndex < collection.Count; worksheetIndex++)
            //{

            //    Worksheet worksheet = collection[worksheetIndex];


            //    int rows = worksheet.Cells.MaxDataRow;
            //    int cols = worksheet.Cells.MaxDataColumn;
            //    //string Ville;


            //    worksheetIndex = 0;

            //    for (int i = 0; i < rows; i++)
            //    {
            //        if (!context.ApplicationUser.Any())
            //        {
            //            context.ApplicationUser.AddRange(new List<ApplicationUser>()
            //            {
            //                new ApplicationUser()
            //                {
            //                    UserName = Convert.ToString(worksheet.Cells[i, 0].Value),
            //                    PasswordHash = Convert.ToString(worksheet.Cells[i, 1].Value),
            //                    Email = Convert.ToString(worksheet.Cells[i, 3].Value),
            //                    EmailConfirmed = true,
            //                    PhoneNumber = Convert.ToString(worksheet.Cells[i, 2].Value),
            //                    PhoneNumberConfirmed = true,
            //                    Civility = (ApplicationUser.eCivility)worksheet.Cells[i, 4].Value,
            //                    LastName = Convert.ToString(worksheet.Cells[i, 5].Value),
            //                    FirstName = Convert.ToString(worksheet.Cells[i, 6].Value),
            //                    BirthDate = Convert.ToDateTime(worksheet.Cells[i, 7].Value),
            //                }
            //                 });
            //            context.SaveChanges();

            //        }

            //    }

        }


    }
}
}

