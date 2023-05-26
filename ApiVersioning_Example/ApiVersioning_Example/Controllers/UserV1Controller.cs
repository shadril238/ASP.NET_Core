using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning_Example.Controllers
{
    [Route("api/user")]
    [ApiController]
    [ApiVersion("1.0")]
    public class UserV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            return Ok("User V1 Controller");
        }
    }
}
