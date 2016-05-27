using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamA_Tentamen.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public StoreContext() : base("StoreContext")
        {
        }
    }

    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var stores = new List<Store>()
            {
                new Store()
                {
                    StoreID = 1,
                    Name = "IcaMaxi",
                    Adress = "Regementsvägen",
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                           ProductID = 1, Name = "Ben And Jerrys", ProductText = "Mycket god glass", ProductNumber = "p13", Price = 50, ProductInStock = true
                        },
                                                new Product()
                        {
                           ProductID = 2, Name = "Potatis", ProductText = "Kilopris", ProductNumber = "p125", Price = 5, ProductInStock = true
                        }
                    }
                },
                 new Store()
                 {
                     StoreID = 2,
                     Name = "Netto",
                     Adress = "Filbornavägen",
                     Products = new List<Product>()
                     {
                           new Product()
                        {
                           ProductID = 3, Name = "Tomat", ProductText = "Svenska tomater", ProductNumber = "p133", Price = 8, ProductInStock = true
                        },
                           new Product()
                        {
                           ProductID = 4, Name = "KanelBulle", ProductText = "Nybakade bullar", ProductNumber = "p5", Price = 15, ProductInStock = true
                        }
                     }
                 }
            };

            foreach (var store in stores)
            {
                context.Stores.Add(store);
            }


            var products = new List<Product>()
            {
                           new Product()
                        {
                           ProductID = 1, Name = "Ben And Jerrys", ProductText = "Mycket god glass", ProductNumber = "p13", Price = 50, ProductInStock = true
                        },
                            new Product()
                        {
                           ProductID = 2, Name = "Potatis", ProductText = "Kilopris", ProductNumber = "p125", Price = 5, ProductInStock = true
                        },
                           new Product()
                        {
                           ProductID = 3, Name = "Tomat", ProductText = "Svenska tomater", ProductNumber = "p133", Price = 8, ProductInStock = true
                        },
                           new Product()
                        {
                           ProductID = 4, Name = "KanelBulle", ProductText = "Nybakade bullar", ProductNumber = "p5", Price = 15, ProductInStock = true
                        }
            };


            foreach (var product in products)
            {
                context.Products.Add(product);
            }
        }
    }
}
