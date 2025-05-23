using AuthApi.Core.DTOs;

namespace AuthApi.Core.Interfaces;

public interface IAuthService 
{
    Task<string> LoginAsync(LoginRequestDTO request);
}
