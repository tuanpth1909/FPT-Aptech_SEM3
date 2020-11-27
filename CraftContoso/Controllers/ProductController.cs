﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Services;
using CraftContoso.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contoso_Crafts.Controllers
{
    [Route("[controller]")]

    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productsService)
        {
            this.ProductService = productsService;
        }

        public JsonFileProductService ProductService
        {
            get;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery] string ProductId, [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
