using Microsoft.AspNetCore.Mvc;

namespace AuthApi.API.Controllers 
{
    [ApiController]
    [Route("api/controller")]

    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            return Ok("Login endpoint");
        }
    }
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
