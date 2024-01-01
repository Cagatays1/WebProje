using Microsoft.AspNetCore.Mvc;

namespace WebClient.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
