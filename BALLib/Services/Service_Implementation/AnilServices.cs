//using BALLib.Common;
//using BALLib.DTOs;
//using BALLib.DTOs.ClientDTO;
//using BALLib.Services.Service_Interface;
//using CommonlibDAO.Repositories.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////using CommonlibDAO.Repositories.Implementations;

//namespace BALLib.Services.Service_Implementation
//{
//    public class AnilServices: IAnilServices
//    {
//        private readonly IAnilRepositery _repo;
//        public AnilServices(IAnilRepositery repo)
//        {
//            _repo = repo;
//        }
//       public async Task<ApiResponse<GetClientDTO>> GetClientById(int id)
//        {
//            var client = await _repo.GetById(id);
//            if (client == null)
//                return ApiResponse<GetClientDTO>
//                    .FailureResponse("Client not found.");
//            var dto = new GetClientDTO
//            {
//                Id = client.ClientId,
//                ClientName = client.ClientName ?? string.Empty,
//                Email = client.ContactEmail ?? string.Empty,
//                Phone = client.ContactPhone ?? string.Empty,
//                Address = client.Address ?? string.Empty 
//            };
//            return ApiResponse<GetClientDTO>
//                .SuccessResponse(dto);
//        }
//    }
//}
