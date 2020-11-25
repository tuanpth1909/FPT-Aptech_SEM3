using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso_Crafts.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Contoso_Crafts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productsService)
        {
            _logger = logger;
            ProductService = productsService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
