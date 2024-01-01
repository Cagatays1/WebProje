using Microsoft.EntityFrameworkCore;
using WebClient.Context;
using WebClient.Models.Entities;
using WebClient.Repositories.Interfaces;

namespace WebClient.Repositories.Concrete
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
