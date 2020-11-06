using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "FPT Aptech";
        }

        //public string Welcome()
        //{
        //    return "Welcome lady and gentlemen";
        //}

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", ID" + ID);
        }

       
    }
}