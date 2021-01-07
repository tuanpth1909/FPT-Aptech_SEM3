using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAzure.Models.DbContexts
{
    public class TAzureDbContext : DbContext
    {
        public TAzureDbContext(DbContextOptions<TAzureDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
