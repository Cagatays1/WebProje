using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Models.Entities;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories.Concrete
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
