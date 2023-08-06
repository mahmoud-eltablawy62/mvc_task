using campany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace campany.Controllers
{
    public class GetController : Controller
    {
        campanyContext context;
        public GetController()
        {
            context = new campanyContext();
        }

        public IActionResult Index()
        {
            List <Employee> employees = context.Employees.Include(s => s.off).ToList();
            return View(employees);
        }

        public IActionResult GetById( int id )
        {
            Employee employees = context.Employees.Include(s => s.off).FirstOrDefault(e => e.id == id);
            if (id == null)
            {
                return Content ("employee not found");
            }
            return View(employees);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee emp = context.Employees.SingleOrDefault(c => c.id == id);
            List<office> offs = context.Office.ToList();
            ViewBag.offs = new SelectList(offs, "Id", "Name");
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
           
            Employee oldstudent = context.Employees.SingleOrDefault(c => c.id == emp.id);
            
            oldstudent.name = emp.name;
            oldstudent.age = emp.age;
            oldstudent.password = emp.password;
            oldstudent.salary = emp.salary;
            oldstudent.off_ID = emp.off_ID;

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                Employee emp = context.Employees.SingleOrDefault(c => c.id == id);
                context.Employees.Remove(emp);
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
            List <office> offs = context.Office.ToList();
            ViewBag.offs = new SelectList(offs, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee emps) {
            context.Employees.Add(emps);
            context.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}
