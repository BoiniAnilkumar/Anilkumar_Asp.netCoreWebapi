using BALLib.Common;
using BALLib.DTOs;
using BALLib.DTOs.ClientDTO;
using BALLib.Services.Service_Interface;
//using BALLib.Services.Service_Implementation;
//using CommonlibDAO.Repositories.Interface;
//using CommonlibDAO.Repositories.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            var clients = await _clientServices.GetAllClientsAsync();

            return Ok(clients);
            //var result = await _clientServices.GetAllClientsAsync();
            //if (!result.Success)
            //    return Failure(result.Message, result.Errors);
            //return Success(result.Data, result.Message);
        }

        [HttpPost("client-register")]
        public async Task<IActionResult> AddClient(AddClientDTO dto)
        {
            var result = await _clientServices.AddClientAsync(dto);

            if (!result.Success)
                return Failure(result.Message, result.Errors);

            return Success(result.Data, result.Message);
        }

        // ================= GET CLIENT BY ID =================

        [HttpGet("client/{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var client = await _clientServices.GetClientIdAsync(id);

            if (client == null)
                return NotFound("Client not found");

            return Ok(client);
        }

        // ================= UPDATE CLIENT =================

        [HttpPost("client-update/{id}")]
        public async Task<IActionResult> UpdateClient(int id, [FromBody] UpdateClientDTO dto)
        {
            var result = await _clientServices.UpdateClientAsync(id, dto);

            if (!result)
                return NotFound("Client not found");

            return Ok("Client updated successfully");
        }

        // ================= DELETE CLIENT =================

        [HttpDelete("client-delete/{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var result = await _clientServices.DeleteClientAsync(id);

            if (!result)
                return NotFound("Client not found");

            return Ok("Client deleted successfully");
        }
    }

}

