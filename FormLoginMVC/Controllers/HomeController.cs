using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormLoginMVC.Models;

namespace FormLoginMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Notification obj = new Notification
            {
                MessageNotofication = "Ok Fine"
            };
            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(Notification obj)
        {
            ViewBag.MessageNotification = "ok";
            return View(obj);
        }
    }
}
