using Microsoft.EntityFrameworkCore;
using WebClient.Models.Entities;
using WebClient.Context;
using WebClient.Repositories.Interfaces;

namespace WebClient.Repositories.Concrete
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
