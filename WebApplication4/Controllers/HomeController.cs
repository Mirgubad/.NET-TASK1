using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Task1";
            ViewBag.Name = "Ali";
            ViewBag.Surname = "Aliyev";
            ViewBag.Age = "25";
            ViewBag.Country = "Azerbaijan";
            ViewBag.Phone = "+994551234567";
            return View();
        }
    }
}
