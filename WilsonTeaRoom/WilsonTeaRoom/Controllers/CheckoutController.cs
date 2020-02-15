using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WilsonTeaRoom.Models;

namespace WilsonTeaRoom.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Checkout
        public ActionResult Checkout()
        {
            return View();
        }

        //
        // POST: /Checkout/Checkout
        [HttpPost]
        public ActionResult Checkout(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);
            try
            {
                    order.Username = User.Identity.Name;
                    order.OrderDate = DateTime.Now;

                    //Save Order
                    
                    //Process the order
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);
                    

                return RedirectToAction("Complete", new { id = order.OrderId });
                
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        //
        // GET: /Checkout/Complete
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = db.Orders.Any(
                o => o.OrderId == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }

    }
}