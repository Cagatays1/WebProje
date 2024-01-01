using Microsoft.EntityFrameworkCore;
using WebClient.Context;
using WebClient.Models.Entities;
using WebClient.Repositories.Interfaces;

namespace WebClient.Repositories.Concrete
{
    public class CitizenRepository : RepositoryBase<Citizen>, ICitizenRepository
    {
        public CitizenRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
