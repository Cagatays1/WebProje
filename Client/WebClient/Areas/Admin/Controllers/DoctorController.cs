using Microsoft.AspNetCore.Mvc;
using WebClient.Repositories.Interfaces;

namespace WebClient.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorrepository;
        private readonly IPoliclinicRepository _policlinicrepository;


        public DoctorController(IDoctorRepository doctorRepository, IPoliclinicRepository policlinicrepository)
        {
            _doctorrepository = doctorRepository;
            _policlinicrepository = policlinicrepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DoktorlarAsync()
        {
            var doctors = _doctorrepository.GetAll().ToList();
            foreach (var doctor in doctors)
            {
                var policlinic = await _policlinicrepository.GetSingleAsync(i => i.Id == doctor.PoliclinicId);
                doctor.Policlinic.Name = policlinic.Name;
            }
            return View(doctors);
        }
    }
}
