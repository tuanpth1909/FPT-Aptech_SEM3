using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAzure.Models;

namespace TestAzure.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
        private TAzureRepository repository;

        //Khởi tạo Contructor
        public NavigationMenuViewComponent(TAzureRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
