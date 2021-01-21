using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sopiration.Models;

namespace Sopiration.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private SopirationRepository repository;

        //Khởi tạo Contructor
        public NavigationMenuViewComponent(SopirationRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
