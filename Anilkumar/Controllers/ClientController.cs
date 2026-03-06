using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BALLib.Common;
using BALLib.DTOs;
using BALLib.Services.Service_Interface;
//using BALLib.Services.Service_Implementation;
//using CommonlibDAO.Repositories.Interface;
//using CommonlibDAO.Repositories.Implementations;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace Anilkumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseController
    {
        private readonly IClientServices _clientServices;
        public ClientController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }
        [HttpGet("get-client")]
        public async Task<IActionResult> GetClient()
        {
            var result = await _clientServices.GetAllClientsAsync();
            if (!result.Success)
                return Failure(result.Message, result.Errors);
            return Success(result.Data, result.Message);
        }
    }
}
