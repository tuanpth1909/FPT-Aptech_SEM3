using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sopiration.Models
{
    public class SopirationContext : DbContext
    {
        //Tùy biến 
        public SopirationContext(DbContextOptions<SopirationContext> options)
           : base(options) { }

        //Liên kết đến bảng Book trong Database
        public DbSet<Book> Books { get; set; }
    }
}
