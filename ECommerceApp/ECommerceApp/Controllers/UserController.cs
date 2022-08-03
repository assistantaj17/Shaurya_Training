using ECommerceApp.DAL;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace ECommerceApp.Controllers
{
    public class UserController : Controller
    {
        UserDAL db = new UserDAL();
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User users)
        {
            try
            {
                int res = db.UserSignUp(users);
                if (res == 1)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }

        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User users)
        {
            User user = db.UserLogin(users);
            if (user.Password == users.Password)
            {
                HttpContext.Session.SetString("username", user.FirstName + " " + user.LastName);
                HttpContext.Session.SetInt32("userid", user.Id);
                HttpContext.Session.SetInt32("isAdmin", user.isAdmin);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
