using Microsoft.AspNetCore.Mvc;

namespace BlogTracker.UI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
