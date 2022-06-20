using _17._06._2022_ASP_DataTransfer_DbContext.Models;
using _17._06._2022_ASP_DataTransfer_DbContext.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _17._06._2022_ASP_DataTransfer_DbContext.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Elgun";
            ViewData["Surname"] = "Guluzade";
            TempData["Age"] = 29;


            List<Student> students = new List<Student>
            {
                new Student { Id =0, Name="Elgun", Surname="Guluzade", Age=29},
                new Student { Id =1, Name="Hesen", Surname="Hesenzade", Age=23},
                new Student { Id =2, Name="Eli", Surname="Abbasov", Age=25}
            };

            List<Group> groups = new List<Group>
            {
                new Group { Id =0, GroupName="P116"},
                new Group { Id =1, GroupName="P322"}
            };

            HomeVM home = new HomeVM();
            home.Students = students;
            home.Groups = groups;


            //return RedirectToAction(nameof(About));
            return View(home);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
