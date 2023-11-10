using CurdEntityMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurdEntityMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeerepository repository;
        public EmployeeController(IEmployeerepository repository) 
        {
            this.repository = repository;
        }
        public IActionResult Details()
        {
            return View(repository.GetAllEmployee());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            return View(repository.Add(employee));
        }
        public IActionResult Delete(int id)
        {
            return View(repository.Delete(id));
        }
        public IActionResult Edit(Employee employee) 
        {
            return View(repository.Update(employee));
        }
        
    }
}
