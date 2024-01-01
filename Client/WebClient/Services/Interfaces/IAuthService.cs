using Microsoft.AspNetCore.Identity;

namespace WebClient.Services.Interfaces
{
    public interface IAuthService
    {
        public interface IAuthService
        {
            IEnumerable<IdentityRole> Roles { get; }
            IEnumerable<IdentityUser> GetAllUsers();
        }
    }
}
