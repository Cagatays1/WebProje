using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Common;

namespace WebApi.Context
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker : Entityler üzerinden yapılan değişikliklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir.
            // Update operasyonlarında Track Edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker
                        .Entries<CommonEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                };
            }

            return await base.SaveChangesAsync(cancellationToken);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
