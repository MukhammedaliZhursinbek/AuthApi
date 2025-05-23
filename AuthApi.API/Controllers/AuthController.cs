using AuthApi.Core.DTOs;
using AuthApi.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.API.Controllers 
{
    [ApiController]
    [Route("api/controller")]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            var token = await _authService.LoginAsync(request);
            return Ok(new {token});
        }
    }
}
