
using WebClient.Models.Entities;

namespace WebClient.ViewModels
{
    public class AppointmentDtoForCreation
    {
        public DateTime AppointmentDate { get; set; }
        public Guid DoctorId { get; set; }
        public Guid CitizenId { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
