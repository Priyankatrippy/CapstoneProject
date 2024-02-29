using BlogTracker.UI.Models;
using Microsoft.AspNetCore.Mvc;



namespace BlogTracker.UI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Index
        public IActionResult Index()
        {
            // Show the default view for the Admin controller
            return View();
        }
        // GET: Admin/AddEmployee
        public IActionResult AddEmployee()
        {
            // Show page for adding employee details for the admin
            return View();
        }

        // POST: Admin/AddEmployee
        [HttpPost]
        public IActionResult AddEmployee(EmployeeViewModel model)
        {
            // Logic to add employee details
            if (ModelState.IsValid)
            {
                // Save employee details to the database or call service layer
                return RedirectToAction("Index", "Home"); // Redirect to home page after successful addition
            }
            else
            {
                // If model state is not valid, return back to the AddEmployee view with validation errors
                return View(model);
            }
        }
    }
}
