using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebClient.Config;
using WebClient.Context;
using WebClient.Repositories.Concrete;
using WebClient.Repositories.Interfaces;
using WebClient.Services.Concrete;
using WebClient.Services.Interfaces;

namespace WebClient.Extensions
{
    public static class ServiceExtensions
    {
        public static void dataseeding(this IServiceCollection services, IConfiguration configuration)
        {
            var seedData = new VeriEkleme();
            seedData.SeedAsync(configuration).GetAwaiter().GetResult();
        }
        public static void ServiceRegisteration(this IServiceCollection services)
        {
            services.AddScoped<ICitizenRepository, CitizenRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IPoliclinicRepository, PoliclinicRepository>();

            services.AddScoped<IAuthService, AuthService>();
        }
        public static void IdentityConfig(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<DatabaseContext>();
        }
        public static void DbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("WebApi"));
            });
        }

    }
}
