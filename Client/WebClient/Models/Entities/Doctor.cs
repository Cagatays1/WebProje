using WebClient.Models.Entities.Common;

namespace WebClient.Models.Entities
{
    public class Doctor : CommonEntity
    {
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public Guid PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
