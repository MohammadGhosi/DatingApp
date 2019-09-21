using DatingApp.API.Models;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string Password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}