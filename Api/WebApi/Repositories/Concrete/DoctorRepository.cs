using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Models.Entities;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories.Concrete
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
