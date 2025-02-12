using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountDashboardProject.Controllers
{
    [Route("api/protected")]
    [ApiController]
    [Authorize]
    public class ProtectedController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSecretData()
        {
            return Ok(new { Message = "This is a protected resource" });
        }
    }
}
