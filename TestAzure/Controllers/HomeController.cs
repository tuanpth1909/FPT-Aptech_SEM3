using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestAzure.Models;
using TestAzure.Models.ViewModels;

namespace TestAzure.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index() => View();
        private TAzureRepository repository;
        public int PageSize = 4;

        //private readonly ILogger<HomeController> _logger;

        public HomeController(TAzureRepository repo)
        {
            repository = repo;
        }

        //public IActionResult Index() => View(repository.Products);
        //public ViewResult Index(int productPage = 1)
        //    => View(repository.Products
        //        .OrderBy(p => p.ProductID)
        //        .Skip((productPage - 1) * PageSize)
        //        .Take(PageSize)
        //        );
        public ViewResult Index(int productPage = 1)
           => View(new ProductsListViewModel
           {
               Products = repository.Products
               .OrderBy(p => p.ProductID)
               .Skip((productPage - 1) * PageSize)
               .Take(PageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   TotalItems = repository.Products.Count()
               }
           });
    }
}
