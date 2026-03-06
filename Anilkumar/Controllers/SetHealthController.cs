using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anilkumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetHealthController : ControllerBase
    {
        [HttpGet]
        [Route("GetHealth")]
        public async Task<IActionResult> GetHealth()
        {
            return Ok("Running Anilkumar");
        }
        [HttpPost]
        [Route("SetHealth")]
        public async Task<IActionResult> SetHealth(string healthValue)
        {
            return Ok(healthValue);
        }
    }
}
