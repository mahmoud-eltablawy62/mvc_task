using campany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace campany.Controllers
{
    public class projController : Controller
    {

        campanyContext context;
        public projController()
        {
            context = new campanyContext();
        }
        public IActionResult Index()
        {
            List <project> proj = context.Projects.ToList();
            return View(proj);
        }

        public IActionResult GetById(int id)
        {
            project proj = context.Projects.FirstOrDefault(e => e.Id == id);
            if (id == null)
            {
                return Content("employee not found");
            }
            return View(proj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            project proj = context.Projects.SingleOrDefault(c => c.Id == id);
            List<project> projs = context.Projects.ToList();
            return View(proj);
        }
        [HttpPost]
        public IActionResult Edit(project proj)
        {
            project oldstudent = context.Projects.SingleOrDefault(c => c.Id == proj.Id);
            oldstudent.Name = proj.Name;
            oldstudent.Description = proj.Description;       
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            try
            {
                project proj = context.Projects.SingleOrDefault(c => c.Id == id);
                context.Projects.Remove(proj);
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
            List<project> proj= context.Projects.ToList();          
            return View();
        }
        [HttpPost]
        public IActionResult Add(project proj)
        {
            context.Projects.Add(proj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
