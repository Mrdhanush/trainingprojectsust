using Microserviceproject.Services.AuthAPI.Models;

namespace Microserviceproject.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
