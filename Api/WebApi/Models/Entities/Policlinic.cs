using WebApi.Models.Entities.Common;

namespace WebApi.Models.Entities
{
    public class Policlinic : CommonEntity
    {
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
