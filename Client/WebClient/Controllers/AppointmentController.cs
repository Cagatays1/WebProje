using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebClient.Models;
using WebClient.Models.Entities;
using WebClient.Repositories.Interfaces;
using WebClient.ViewModels;

public class AppointmentController : Controller
{
    private readonly ICitizenRepository _citizenRepository;
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IDoctorRepository _doctorRepository;
    private readonly IPoliclinicRepository _policlinicRepository;
    public AppointmentController(ICitizenRepository citizenRepository, IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository, IPoliclinicRepository policlinicRepository)
    {
        _citizenRepository = citizenRepository;
        _appointmentRepository = appointmentRepository;
        _doctorRepository = doctorRepository;
        _policlinicRepository = policlinicRepository;
    }
    public IActionResult Randevu()
    {
        return View();
    }

    public IActionResult AddAppointment()
    {
        var doctors = _doctorRepository.GetAll().ToList();
        ViewBag.Doctors = new SelectList(doctors, "Id", "Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddAppointment(AppointmentDtoForCreation dto)
    {
        var appointment = new Appointment()
        {
            Id = Guid.NewGuid(),
            AppointmentDate = dto.AppointmentDate,
            CreatedDate = DateTime.Now,
            CitizenId = dto.CitizenId,
            DoctorId = dto.DoctorId,
        };
        appointment.Doctor = await _doctorRepository.GetByIdAsync(dto.DoctorId.ToString());
        appointment.Citizen = await _citizenRepository.GetByIdAsync(dto.CitizenId.ToString());
        await _appointmentRepository.AddAsync(appointment);
        return View();
    }
}
