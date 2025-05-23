using AuthApi.Core.DTOs;
using AuthApi.Core.Interfaces;

namespace AuthApi.Application.Services;

public class AuthService : IAuthService 
{ 
    public async Task<string> LoginAsync(LoginRequestDTO request)
    {
        return await Task.FromResult("fake-jwt-token");
    }
}
