using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sopiration.Models
{
    public class EFSopirationRepository : SopirationRepository
    {
        private SopirationContext context; //Khởi tạo biến Db

        public EFSopirationRepository(SopirationContext ctx)//Khởi tạo controller
        {
            context = ctx;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
