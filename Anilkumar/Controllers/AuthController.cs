using BALLib.DTOs;
using BALLib.Services.Service_Implementation;
using BALLib.Services.Service_Interface;
using CommonlibDAO.Modles;
using Microsoft.AspNetCore.Mvc;

namespace Anilkumar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : BaseController
    {
        private readonly ILoginService _loginService;

        public AuthController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("login")]//superadmin,$2a$11$hash_superadmin
        public async Task<IActionResult> Login(LoginRequestDTO request)
        {
            var result = await _loginService.LoginAsync(request);

            if (!result.Success)
                return Unauthorized(result);

            return Ok(result);
        }
    }

}
