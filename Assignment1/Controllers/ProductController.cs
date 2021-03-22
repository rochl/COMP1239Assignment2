using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {
       
        private ProductContext context { get; set; }
         

        public ProductController(ProductContext ctx)
        {
            context = ctx;
        }
        [Route("products")]
        public IActionResult list()
        {
            var products = context.Products.OrderBy(p => p.DateAdded).ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Add()
        {

            ViewBag.action = "Add";
            var products = context.Products.OrderBy(p => p.productName).ToList();
            return View("Edit",new Product());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.action = "Edit";
            var products = context.Products.OrderBy(p => p.productName).ToList();
            var product = context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.productId == 0)
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    TempData["Success"] = product.productName + "  added Succesfully";
                    return RedirectToAction("list");

                }
                else
                {
                    TempData["Success"] = product.productName + "  updated Succesfully";
                    context.Products.Update(product);
                    context.SaveChanges();
                    return RedirectToAction("list");
                    

                }
                
            }   
            else
            {
                ViewBag.Action = (product.productId == 0) ? "Add" : "Edit";
                ViewBag.products = context.Products.OrderBy(p => p.productName).ToList();
                return View(product);
            }
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            
            TempData["Success"] = "item deleted Succesfully";
            context.Products.Remove(product);
            
            context.SaveChanges();
            
            return RedirectToAction("list");
        }



    }
}
