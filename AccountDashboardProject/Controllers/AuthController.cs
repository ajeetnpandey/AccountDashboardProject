using AccountDashboardProject.Models;
using AccountDashboardProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace AccountDashboardProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtTokenService _jwtTokenService;

        public AuthController(IJwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestDto request)
        {
            // Dummy user validation (Replace with actual authentication logic)
            if (request.Email == "test@example.com" && request.Password == "password123")
            {
                var token = _jwtTokenService.GenerateToken("1", request.Email, "User");
                return Ok(new { Token = token });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}
