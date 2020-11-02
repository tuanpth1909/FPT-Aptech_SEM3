using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Display_Data.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));

        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Boats"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Roockets"
                },
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                     ProductName = "Convertible Car",
                     Description = "bla bla",
                     ImagePath = "carconvert.png",
                     UnitPrice = 22.5,
                     CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                     ProductName = "Old-time Car",
                     Description = "bla bla",
                     ImagePath = "carearly.png",
                     UnitPrice = 15.95,
                     CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                     ProductName = "Fast Car",
                     Description = "bla bla",
                     ImagePath = "carfast.png",
                     UnitPrice = 32.99,
                     CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                     ProductName = "Super Fast Car",
                     Description = "bla bla",
                     ImagePath = "carfaster.png",
                     UnitPrice = 8.95,
                     CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                     ProductName = "Old Style Racer",
                     Description = "bla bla",
                     ImagePath = "carracer.png",
                     UnitPrice = 34.95,
                     CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                     ProductName = "Ace Plane",
                     Description = "bla bla",
                     ImagePath = "planeace.png",
                     UnitPrice = 95,
                     CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                     ProductName = "Glider ",
                     Description = "bla bla",
                     ImagePath = "planeglider.png",
                     UnitPrice = 4.95,
                     CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                     ProductName = "Paper Plane",
                     Description = "bla bla",
                     ImagePath = "planepaper.png",
                     UnitPrice = 2.95,
                     CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                     ProductName = "Propeller Plane",
                     Description = "bla bla",
                     ImagePath = "planeprop.png",
                     UnitPrice = 32.95,
                     CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                     ProductName = "Early Truck",
                     Description = "bla bla",
                     ImagePath = "truckearly.png",
                     UnitPrice = 15,
                     CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                     ProductName = "Fire Truck",
                     Description = "bla bla",
                     ImagePath = "truckfire.png",
                     UnitPrice = 26,
                     CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                     ProductName = "Big Truck Car",
                     Description = "bla bla",
                     ImagePath = "truckbig.png",
                     UnitPrice = 29,
                     CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                     ProductName = "Big Ship",
                     Description = "bla bla",
                     ImagePath = "boatbig.png",
                     UnitPrice = 95,
                     CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                     ProductName = "Big Ship",
                     Description = "bla bla",
                     ImagePath = "carconvert.png",
                     UnitPrice = 22.5,
                     CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                     ProductName = "Sail Boat",
                     Description = "bla bla",
                     ImagePath = "boatsail.png",
                     UnitPrice = 42.95,
                     CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                     ProductName = "Rocket Car",
                     Description = "bla bla",
                     ImagePath = "rocket.png",
                     UnitPrice = 122.95,
                     CategoryID = 4
                },
            };
            return products;
        }
    }
}