using Microsoft.AspNetCore.Mvc;
using Sopiration.Models;
using Sopiration.Models.ViewModels;
using System.Linq;

namespace Sopiration.Controllers
{
    public class HomeController : Controller
    {
        private SopirationRepository repository;
        public int PageSize = 4;

        public HomeController(SopirationRepository repo)
        {
            repository = repo;
        }

        //public IActionResult Index() => View(repository.Books);

        //public ViewResult Index(int productPage = 1) =>
        //    View(new ProductsListViewModel
        //    {
        //        //Product
        //         Books = repository.Books
        //        .OrderBy(p => p.BookId)
        //        .Skip((productPage - 1) * PageSize)
        //        .Take(PageSize),  
        //        //PagingInfo
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = productPage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = repository.Books.Count()
        //        }
        //    });

        public ViewResult Index(string category, int productPage = 1)
           => View(new ProductsListViewModel
           {
               Books = repository.Books
               .Where(p => category == null || p.Category == category)  
               .OrderBy(p => p.BookId)
               .Skip((productPage - 1) * PageSize)
               .Take(PageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   TotalItems = repository.Books.Count()
               }
           });
    }
}
