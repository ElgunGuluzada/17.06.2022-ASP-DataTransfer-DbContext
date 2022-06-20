using Microsoft.AspNetCore.Mvc;

namespace _17._06._2022_ASP_DataTransfer_DbContext.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Elgun";
            ViewData["Surname"] = "Guluzade";
            TempData["Age"] = 29;

            return RedirectToAction(nameof(About));
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
