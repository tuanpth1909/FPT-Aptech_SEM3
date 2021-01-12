using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sopiration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sopiration.Controllers
{
    public class HomeController : Controller
    {
        private SopirationRepository repository;

        public HomeController(SopirationRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Books);

        //Khởi tạo controller HomeController

    }
}
