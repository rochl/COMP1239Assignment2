using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Assignment1.Controllers
{
    public class CustomerController : Controller
    {

        private CustomerContext context { get; set; }

        public CustomerController(CustomerContext ctx)
        {
            context = ctx;
        }
        [Route("customers")]
        public IActionResult list()
        {
            var cust = context.Customers.OrderBy(p => p.customerFirstName).ToList();
            return View(cust);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.action = "Add";
            var cust = context.Customers.OrderBy(p => p.customerFirstName).ToList();
            return View("Edit", new Customer());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.action = "Edit";
            var custs = context.Customers.OrderBy(p => p.customerFirstName).ToList();
            var cust = context.Customers.Find(id);
            return View(cust);
        }
        [HttpPost]
        public IActionResult Edit(Customer cust)
        {
            if (ModelState.IsValid)
            {
                if (cust.customerId == 0)
                {
                    context.Customers.Add(cust);
                    context.SaveChanges();
                    return RedirectToAction("list");

                }
                else
                {
                    context.Customers.Update(cust);
                    context.SaveChanges();
                    return RedirectToAction("list");

                }

            }
            else
            {
                ViewBag.Action = (cust.customerId == 0) ? "Add" : "Edit";
                ViewBag.customer = context.Customers.OrderBy(p => p.customerId).ToList();
                return View(cust);
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cust = context.Customers.Find(id);
            return View(cust);
        }
        [HttpPost]
        public IActionResult Delete(Customer cust)
        {
            context.Customers.Remove(cust);
            context.SaveChanges();
            return RedirectToAction("list");
        }

    }
}
