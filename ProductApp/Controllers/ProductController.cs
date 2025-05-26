using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Collections.Generic;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 15000000 },
                new Product { Id = 2, Name = "Mouse", Price = 150000 },
                new Product { Id = 3, Name = "Keyboard", Price = 300000 }
            };

            return View(products);
        }
    }
}
