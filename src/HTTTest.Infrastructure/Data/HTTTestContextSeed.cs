using HTTTest.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTTest.Infrastructure.Data
{
    public sealed class HTTTestContextSeed
    {
        public static async Task SeedAsync(HTTTestContext context, ILogger logger)
        {
            if (!await context.Categories.AnyAsync())
            {
                logger.LogInformation("Database is empty");

                var categories = GetInitialCategories().ToList();
                await context.Categories.AddRangeAsync(categories);

                var products = GetInitialProducts(categories).ToList();
                await context.Products.AddRangeAsync(products);

                await context.SaveChangesAsync();                

                logger.LogInformation("Seed database complete");
            }
        }

        private static IEnumerable<Category> GetInitialCategories()
        {
            return new List<Category>
            {
                new Category { Id = new Guid(), Name = "Pizza", Measure = "g" },
                new Category { Id = new Guid(), Name = "Salad", Measure = "g"  },
                new Category { Id = new Guid(), Name = "Drink", Measure = "ml" },
            };
        }

        private static IEnumerable<Product> GetInitialProducts(List<Category> categories)
        {
            return new List<Product>
            {
                new Product { Id = new Guid(), Name = "Сarbonara", Weight = 250, Price = 18.99M, CategoryId = categories[0].Id,
                    Description = "Onion, bacon, fresh cream, ham, mushrooms, mozzarella cheese", PictureUrl ="images\\carbonara.png" },
                new Product { Id = new Guid(), Name = "4 seasons", Weight = 300, Price = 14.99M, CategoryId = categories[0].Id,
                    Description = "Ranch sauce, mushrooms, tomatoes, pepperoni, feta, pineapple, mozzarella cheese, shrimps", PictureUrl ="images\\4seasons.png" },
                new Product { Id = new Guid(), Name = "Meatbollo", Weight = 275, Price = 15.49M, CategoryId = categories[0].Id,
                    Description = "Burger sauce, beef meatballs, cucumber, mozzarella cheese, chicken, onion, sweet pepper", PictureUrl ="images\\meatbollo.png" },
                new Product { Id = new Guid(), Name = "Bolognese", Weight = 350, Price = 13.49M, CategoryId = categories[0].Id,
                    Description = "Ham, beef meatballs, tomatoes, domino's tomato sauce, onion, mushrooms, mozzarella cheese", PictureUrl ="images\\bolognese.png" },
                new Product { Id = new Guid(), Name = "Munich", Weight = 200, Price = 16.99M, CategoryId = categories[0].Id,
                    Description = "Bavarian sausages, ham, tomatoes, mozzarella cheese, mustard, barbecue sauce, Munich sausages", PictureUrl ="images\\munich.png" },
                new Product { Id = new Guid(), Name = "Chedderoni", Weight = 225, Price = 15.99M, CategoryId = categories[0].Id,
                    Description = "Pepperoni, mozzarella cheese, cheddar, ham, cream fresh", PictureUrl ="images\\chedderoni.png" },

                new Product { Id = new Guid(), Name = "Greek salad", Weight = 300, Price = 10.99M, CategoryId = categories[1].Id,
                    Description = "Olive oil, olives, cherry tomatoes, feta", PictureUrl ="images\\greeksalad.png" },
                new Product { Id = new Guid(), Name = "Caesar salad", Weight = 300, Price = 9.99M, CategoryId = categories[1].Id,
                    Description = "Chicken, cherry tomatoes, parmesan, caesar sauce", PictureUrl ="images\\caesar.png" },

                new Product { Id = new Guid(), Name = "Coca Cola Classic", Weight = 500, Price = 3.99M, CategoryId = categories[2].Id,
                    Description = "Water, sugar, E395", PictureUrl ="images\\colaclassic.png" },
                new Product { Id = new Guid(), Name = "Fanta Orange", Weight = 500, Price = 3.99M, CategoryId = categories[2].Id,
                    Description = "Water, sugar, E189", PictureUrl ="images\\fantaorange.png" },
                new Product { Id = new Guid(), Name = "Bonaqua Still", Weight = 500, Price = 1.99M, CategoryId = categories[2].Id,
                    Description = "Water carbonated", PictureUrl ="images\\bonaquastill.png" },
            };
        }
    }
}
