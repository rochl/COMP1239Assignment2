using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Models;


namespace Assignment1.Controllers
{
    public class IncidentController : Controller
    {

        private IncidentContext context { get; set; }
      

        public IncidentController(IncidentContext ctx)
        {
            context = ctx;
        }
        [Route("incidents")]
        public IActionResult list()
        {
            var incidents = context.Incidents.OrderBy(p => p.incidentTitle).ToList();
            return View(incidents);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.action = "Add";
           
            var incidents = context.Incidents.OrderBy(p => p.incidentTitle).ToList();
            return View("Edit", new Incident());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.action = "Edit";
            ViewBag.Customers = new List<string>
            {
                "Gindy Raz","Kailtyn Anothini","Katty Brown","Maya Kavi"
            };
            ViewBag.Products = new List<string>
            {
                "Computer Headset edit 3","Computer Mouse","Computer Montior 28'","Computer Keyboard"
            };
            ViewBag.Technicians = new List<string>
            {
                "1","2","3"
            };
            var incidents = context.Incidents.OrderBy(p => p.incidentTitle).ToList();
            var incident = context.Incidents.Find(id);
            return View(incident);
        }
        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if (incident.incidentId == 0)
                {
                    context.Incidents.Add(incident);
                    context.SaveChanges();
                    return RedirectToAction("list");

                }
                else
                {
                    context.Incidents.Update(incident);
                    context.SaveChanges();
                    return RedirectToAction("list");

                }

            }
            else
            {
                ViewBag.Action = (incident.incidentId == 0) ? "Add" : "Edit";
                ViewBag.Customers = new List<string>
            {
                "Gindy Raz","Kailtyn Anothini","Katty Brown","Maya Kavi"
            };
                ViewBag.Products = new List<string>
            {
                "Computer Headset edit 3","Computer Mouse","Computer Montior 28'","Computer Keyboard"
            };
                ViewBag.Technicians = new List<string>
            {
                "1","2","3"
            };
                ViewBag.incidents = context.Incidents.OrderBy(p => p.incidentTitle).ToList();
                return View(incident);
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = context.Incidents.Find(id);
            return View(incident);
        }
        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("list");
        }



    }
}
