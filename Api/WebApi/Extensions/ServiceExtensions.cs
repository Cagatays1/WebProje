using Microsoft.Extensions.Configuration;
using WebApi.Config;

namespace WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void dataseeding(this IServiceCollection services, IConfiguration configuration)
        {
            var seedData = new VeriEkleme();
            seedData.SeedAsync(configuration).GetAwaiter().GetResult();
        }
    }
}
