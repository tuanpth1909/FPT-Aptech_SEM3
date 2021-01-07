using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestAzure.Models;

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

        public IActionResult Index() => View(repository.Products);

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
