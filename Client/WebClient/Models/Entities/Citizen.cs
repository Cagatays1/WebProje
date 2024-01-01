using WebClient.Models.Entities.Common;

namespace WebClient.Models.Entities
{
    public class Citizen : CommonEntity
    {
        public string CitizenSurname { get; set; }
        public string CitizenName { get; set; }
        public string CitizenEmail { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
