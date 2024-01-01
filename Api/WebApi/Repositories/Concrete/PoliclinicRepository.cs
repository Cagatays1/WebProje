using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories.Concrete
{
    public class PoliclinicRepository : RepositoryBase<Policlinic>, IPoliclinicRepository
    {
        public PoliclinicRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
