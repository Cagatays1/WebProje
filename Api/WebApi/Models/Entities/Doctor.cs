using WebApi.Models.Entities.Common;

namespace WebApi.Models.Entities
{
    public class Doctor : CommonEntity
    {
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public Guid PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }
    }
}
