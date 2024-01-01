using Microsoft.EntityFrameworkCore;
using WebClient.Context;
using WebClient.Models.Entities;
using WebClient.Repositories.Interfaces;

namespace WebClient.Repositories.Concrete
{
    public class PoliclinicRepository : RepositoryBase<Policlinic>, IPoliclinicRepository
    {
        public PoliclinicRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
