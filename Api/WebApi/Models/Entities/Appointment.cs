using WebApi.Models.Entities.Common;

namespace WebApi.Models.Entities
{
    public class Appointment : CommonEntity
    {
        public DateTime SelectedDay { get; set; }
        public DateTime SelectedHours { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid CitizenId { get; set; }
        public Citizen Citizen { get; set; }
    }
}
