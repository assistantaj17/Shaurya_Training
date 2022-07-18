using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "This is my mvc application";
            string[] names = { "tushar", "Ramesh", "rajesh", "rahul" };
            ViewData["namelist"] = names;

            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Id=1,Name="tushar",Department="IT",Salary=25000},
                new Employee{Id=2,Name="ramesh",Department="IT",Salary=27000},
                new Employee{Id=3,Name="rajesh",Department="Admin",Salary=22000},
                new Employee{Id=4,Name="rahul",Department="HR",Salary=28000},
            };
            ViewData["emplist"] = emplist;
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
