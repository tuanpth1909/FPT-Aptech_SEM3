using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Display_Data.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Display_Data")
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}