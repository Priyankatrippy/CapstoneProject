using BlogTracker.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BlogTracker.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Sample data for blogs added by employees
            var blogs = new List<BlogViewModel>
            {
                new BlogViewModel
                {
                    Title = "ASP.Net MVC",
                    EmpEmailId = "scott@gmail.com",
                    DateOfCreation = new DateTime(2022, 3, 10),
                    BlogUrl = "https://devblogs.microsoft.com/dotnet/category"
                },
                new BlogViewModel
                {
                    Title = "ASP.Net Web API",
                    EmpEmailId = "scott@gmail.com",
                    DateOfCreation = new DateTime(2022, 3, 18),
                    BlogUrl = "https://devblogs.microsoft.com/dotnet/tag/app/"
                },
                new BlogViewModel
                {
                    Title = "MS-SQL Server",
                    EmpEmailId = "tiger@gmail.com",
                    DateOfCreation = new DateTime(2022, 7, 15),
                    BlogUrl = "https://cloudblogs.microsoft.com/iq/server"
                }
                // Add more blog items as needed
            };

            return View(blogs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


