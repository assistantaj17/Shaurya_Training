using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVC_Demo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> options = new List<string>();  
            options.Add("Select an Option");
            options.Add("Yes");
            options.Add("No");
            ViewData["Options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form,ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.options = form["options"];
            return View("Display");
        }
    }
}
