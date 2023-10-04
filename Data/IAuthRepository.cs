using WebUygulaması.Models;

namespace WebUygulaması.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string? userName,string? password);
        Task<bool> UserExist(string userName);

    }
}
