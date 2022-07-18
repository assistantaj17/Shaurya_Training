using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
using System.Collections.Generic;

namespace MVC_Demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product{Id=101,Name="HP Laptop",Price=45000 },
                new Product{Id=102,Name="Dell Laptop",Price=48000 },
                new Product{Id=103,Name="Lenovo Laptop",Price=50000 },
            };
            ViewBag.ProductList = plist;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
    
}
