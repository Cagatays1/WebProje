using WebApi.Models.Entities;

namespace WebApi.ViewModels
{
    public class AppointmentDtoForCreation
    {
        public DateTime AppointmentDate { get; set; }
        public Guid DoctorId { get; set; }
        public Guid CitizenId { get; set; }
    }
}
