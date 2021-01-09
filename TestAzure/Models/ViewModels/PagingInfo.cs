using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAzure.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}

//to support the tag helper,
//pass infomation to the view about the number of pages avaiable
//the current page and the total numbers of products
// => Create ViewModel class to pass data between a controller and a view
