using campany.Models;
using campany.viewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;

namespace campany.Controllers
{
    public class addController : Controller
    {
        campanyContext context;
        
        public addController()
        {
            context = new campanyContext();
        }

        [HttpGet]
        public ActionResult Add() {
            
            return View();
        }


        [HttpPost]
        public ActionResult Add(addV add) {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee()
                {
                    id = add.id,
                    name = add.name,
                    age = add.age,
                    password = add.password
                };
                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index", "Get");
            }
            else
            {
                return View();
            }
        }
    }
}
