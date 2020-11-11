using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session8.Controllers 
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ceate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name, Emailid")] CustomerController customerController)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(customerController);
        }
    }
}
