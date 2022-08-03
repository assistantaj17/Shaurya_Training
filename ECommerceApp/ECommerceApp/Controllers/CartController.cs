using ECommerceApp.DAL;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    public class CartController : Controller
    {
        CartDAL db = new CartDAL();
        public IActionResult Index()
        {
            /*var model = db.ViewProductsFromCart(int UserId);
            return View(model);*/
            return View();
        }
        public IActionResult Show()
        {
            /*var model = db.ViewProductsFromCart(int Userid);
            return View(model);*/
            string abc = "Order Confirm";
            return View(abc);
        }

        // GET: ProductController/Create
        public ActionResult AddProductToCart()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProductToCart(Cart cart)
        {
            try
            {
                int result = db.AddToCart(cart);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            /*var model = db.ViewProductsFromCart(int Userid);
            return View(model);*/
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = db.RemoveFromCart( id);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
