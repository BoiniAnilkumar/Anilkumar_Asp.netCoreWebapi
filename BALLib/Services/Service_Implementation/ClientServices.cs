using BALLib.Common;
using BALLib.DTOs;
using BALLib.Services.Service_Interface;
using CommonlibDAO.Repositories.Implementations;
using CommonlibDAO.Repositories.Interface;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace BALLib.Services.Service_Implementation
{
    public class ClientServices : IClientServices   //  IMPLEMENT INTERFACE
    {
        private readonly IClientRepositery _repo;
        private readonly IConfiguration _config;

        public ClientServices(IClientRepositery repo, IConfiguration config) //  CORRECT TYPE
        {
            _repo = repo;
            _config = config;
        }

       public async Task<ApiResponse<List<ClientDTO>>> GetAllClientsAsync()
{
    var clients = await _repo.GetAllClientsAsync();

    if (clients == null || clients.Count == 0)
        return ApiResponse<List<ClientDTO>>
            .FailureResponse("No clients found.");

    var dtoList = clients.Select(c => new ClientDTO
    {
        Id = c.ClientId,
        Name = c.ClientName,
        Email = c.ContactEmail,
        Phone = c.ContactPhone,
        Address = c.Address
    }).ToList();

    return ApiResponse<List<ClientDTO>>
        .SuccessResponse(dtoList);
}

    }
}
