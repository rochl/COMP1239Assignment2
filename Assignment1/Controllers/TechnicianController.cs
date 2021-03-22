using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Assignment1.Controllers
{
    public class TechnicianController : Controller
    {

        private TechnicianContext context { get; set; }

        public TechnicianController(TechnicianContext ctx)
        {
            context = ctx;
        }
        [Route("technicians")]
        public IActionResult list()
        {
            var tech = context.Technicians.OrderBy(p => p.techName).ToList();
            return View(tech);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.action = "Add";
            var tech = context.Technicians.OrderBy(p => p.techName).ToList();
            return View("Edit", new Technician());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.action = "Edit";
            var techs = context.Technicians.OrderBy(p => p.techName).ToList();
            var tech = context.Technicians.Find(id);
            return View(tech);
        }
        [HttpPost]
        public IActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                if (technician.techId == 0)
                {
                    context.Technicians.Add(technician);
                    TempData["Success"] = technician.techName + "  added Succesfully";
                    context.SaveChanges();
                    return RedirectToAction("list");

                }
                else
                {
                    TempData["Success"] = technician.techName + "  updated Succesfully";
                    context.Technicians.Update(technician);
                    context.SaveChanges();
                    return RedirectToAction("list");

                }

            }
            else
            {
                ViewBag.Action = (technician.techId == 0) ? "Add" : "Edit";
                ViewBag.technician = context.Technicians.OrderBy(p => p.techId).ToList();
                return View(technician);
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var tech = context.Technicians.Find(id);
            return View(tech);
        }
        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            context.Technicians.Remove(technician);
            TempData["Success"] = "Technician removed Succesfully";
            context.SaveChanges();
            return RedirectToAction("list");
        }

    }
}
