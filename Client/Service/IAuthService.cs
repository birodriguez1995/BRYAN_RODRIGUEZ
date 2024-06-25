using Proyecto_Fullstack.Shared.Models;

namespace Proyecto_Fullstack.Client.Service
{
    public interface IAuthService
    {
        Task<RegisterResult> Register(RegisterModel registerModel);
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
    }
}