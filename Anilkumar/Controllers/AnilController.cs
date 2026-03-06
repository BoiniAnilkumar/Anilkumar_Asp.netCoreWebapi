using BALLib.Services.Service_Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anilkumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnilController : BaseController
    {
        private readonly IAnilServices _services;
        public AnilController(IAnilServices services)
        {
            _services = services;
        }
        [HttpGet("get-client-by-id/{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var result = await _services.GetClientById(id);
            if (!result.Success)
                return Failure(result.Message , result.Errors);
            return Success(result.Data, result.Message);

        }
    }
}
