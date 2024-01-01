using WebClient.Models.Entities.Common;

namespace WebClient.Models.Entities
{
    public class Policlinic : CommonEntity
    {
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
