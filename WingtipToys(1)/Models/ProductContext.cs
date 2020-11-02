using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WingtipToys_1_.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() :base("WingtipToys_1_")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCarrtItems { get; set; }
    }
}