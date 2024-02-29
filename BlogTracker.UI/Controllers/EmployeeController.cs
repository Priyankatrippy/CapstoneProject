using BlogTracker.Service.Interfaces;
using BlogTracker.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogTracker.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees(); 

            return View(employees);
        }




        public IActionResult AddBlog()
        {
      
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(BlogViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home"); 
            }
            else
            {
                return View(model);
            }
        }
    }
}

