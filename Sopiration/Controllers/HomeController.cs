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
        public IActionResult Index() => View();

        //Khởi tạo controller HomeController

    }
}
