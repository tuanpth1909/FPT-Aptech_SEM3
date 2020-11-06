using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "d";
        }

        public string DEO(string name , string category, int id=1)
        {
            return HttpUtility.HtmlEncode("id: " + id + "name: " + name + "category" + category);
        }
    }
}