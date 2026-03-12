using BALLib.Common;
using BALLib.DTOs;
using BALLib.DTOs.ClientDTO;
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

       public async Task<ApiResponse<List<GetClientDTO>>> GetAllClientsAsync()
{
    var clients = await _repo.GetAllClientsAsync();

    if (clients == null || clients.Count == 0)
        return ApiResponse<List<GetClientDTO>>
            .FailureResponse("No clients found.");

    var dtoList = clients.Select(c => new GetClientDTO
    {
        Id = c.ClientId,
        ClientName = c.ClientName,
        Email = c.ContactEmail,
        Phone = c.ContactPhone,
        Address = c.Address
    }).ToList();

    return ApiResponse<List<GetClientDTO>>
        .SuccessResponse(dtoList);
}

    }
}
