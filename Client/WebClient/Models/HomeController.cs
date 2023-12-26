using Microsoft.AspNetCore.Mvc;

namespace WebClient.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
