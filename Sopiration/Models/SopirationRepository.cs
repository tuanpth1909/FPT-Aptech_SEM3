using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sopiration.Models
{
    public interface SopirationRepository
    {
        IQueryable<Book> Books { get; }
    }
}
