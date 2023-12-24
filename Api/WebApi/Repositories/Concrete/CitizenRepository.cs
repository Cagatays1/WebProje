using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Models.Entities;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories.Concrete
{
    public class CitizenRepository : RepositoryBase<Citizen>, ICitizenRepository
    {
        public CitizenRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
