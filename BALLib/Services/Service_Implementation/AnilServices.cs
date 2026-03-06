using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLib.Common;
using BALLib.DTOs;
using BALLib.Services.Service_Interface;
using CommonlibDAO.Repositories.Interface;
//using CommonlibDAO.Repositories.Implementations;

namespace BALLib.Services.Service_Implementation
{
    public class AnilServices: IAnilServices
    {
        private readonly IAnilRepositery _repo;
        public AnilServices(IAnilRepositery repo)
        {
            _repo = repo;
        }
       public async Task<ApiResponse<ClientDTO>> GetClientById(int id)
        {
            var client = await _repo.GetById(id);
            if (client == null)
                return ApiResponse<ClientDTO>
                    .FailureResponse("Client not found.");
            var dto = new ClientDTO
            {
                Id = client.ClientId,
                Name = client.ClientName ?? string.Empty,
                Email = client.ContactEmail ?? string.Empty,
                Phone = client.ContactPhone ?? string.Empty,
                Address = client.Address ?? string.Empty 
            };
            return ApiResponse<ClientDTO>
                .SuccessResponse(dto);
        }
    }
}
