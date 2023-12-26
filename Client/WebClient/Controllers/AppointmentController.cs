using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebClient.Models;

public class AppointmentController : Controller
{
    public IActionResult Randevu()
    {
        return View();
    }
    public IActionResult Create()
    {
        // Poliklinik verileri örneği (veritabanından alınacak)
        var polyclinics = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Genel Cerrahi" },
            new SelectListItem { Value = "2", Text = "Dahiliye" },
            new SelectListItem { Value = "3", Text = "Göz" },
            new SelectListItem { Value = "4", Text = "Kulak-Burun-Boğaz" },
            new SelectListItem { Value = "5", Text = "Kalp Cerrahi" },
          
            // Diğer poliklinikler
        };

        var model = new AppointmentModel
        {
            Polyclinics = polyclinics
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Create(AppointmentModel model)
    {
        // Seçilen poliklinik id'sini kullanarak randevu oluştur
        // İşlemler...

        return RedirectToAction("Index", "Home"); // Başka bir sayfaya yönlendirilebilir
    }
}
