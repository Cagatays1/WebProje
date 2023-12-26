using WebApi.Models.Entities.Common;

namespace WebApi.Models.Entities
{
    public class Citizen : CommonEntity
    {
        public string CitizenSurname { get; set; }
        public string CitizenName { get; set; }
        public string CitizenEmail { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

    }
}
