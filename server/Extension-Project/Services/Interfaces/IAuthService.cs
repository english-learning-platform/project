using Extension_Project.Models.Entities;

namespace Extension_Project.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserRole> LoginAsync(string username, string password);
        Task LogoutAsync();
    }
}
