using Microsoft.EntityFrameworkCore;

namespace WebApi.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}
