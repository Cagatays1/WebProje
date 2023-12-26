using Microsoft.AspNetCore.Identity;

namespace WebApi.Services.Interfaces
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
