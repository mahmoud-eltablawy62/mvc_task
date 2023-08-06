using campany.Models;
using Microsoft.AspNetCore.Mvc;

namespace campany.Controllers
{
    public class officeController : Controller
    {
        campanyContext context;
        public officeController()
        {
            context = new campanyContext();
        }
        public IActionResult Index()
        {
            List<office> offi = context.Office.ToList();
            return View(offi);
        }

        public IActionResult GetById(int id)
        {
            office offi = context.Office.FirstOrDefault(e => e.Id == id);
            if (id == null)
            {
                return Content("employee not found");
            }
            return View (offi);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            office offi = context.Office.SingleOrDefault(c => c.Id == id);
            List<office> offs = context.Office.ToList();
            return View(offi);
        }
        [HttpPost]
        public IActionResult Edit(office offi)
        {
            office oldoff = context.Office.SingleOrDefault(c => c.Id == offi.Id);
            oldoff.Name = offi.Name;
            oldoff.Location = offi.Location;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            try
            {
                office oldoff = context.Office.SingleOrDefault(c => c.Id == id);
                context.Office.Remove(oldoff);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("Something went wrong");
            }
        }



        [HttpGet]
        public IActionResult Add()
        {
            List<office> off = context.Office.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(office offi)
        {
            context.Office.Add(offi);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
