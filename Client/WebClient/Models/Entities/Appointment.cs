using WebClient.Models.Entities.Common;

namespace WebClient.Models.Entities
{
    public class Appointment : CommonEntity
    {
        public DateTime AppointmentDate { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid CitizenId { get; set; }
        public Citizen Citizen { get; set; }
    }
}
