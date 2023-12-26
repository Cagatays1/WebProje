using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebClient.Models
{
    public class AppointmentModel
    {
        // Diğer özellikler
        public int PolyclinicId { get; set; }
        public List<SelectListItem>? Polyclinics { get; set; }
    }

}
