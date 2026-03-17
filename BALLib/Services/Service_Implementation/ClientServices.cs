using BALLib.Common;
using BALLib.DTOs;
using BALLib.DTOs.ClientDTO;
using BALLib.DTOs.EmployeeDTO;
using BALLib.Services.Service_Interface;
using CommonlibDAO;
using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Repositories.Implementations;
using CommonlibDAO.Repositories.Interface;
using Mapster;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace BALLib.Services.Service_Implementation
{
    public class ClientServices : IClientServices
    {
        private readonly IClientRepositery _repository;
        private readonly DBContextEFCore _context;

        public ClientServices(IClientRepositery repository,
                              DBContextEFCore context)
        {
            _repository = repository;
            _context = context;
        }

        // ================= ADD CLIENT =================

        public async Task<ApiResponse<string>> AddClientAsync(AddClientDTO dto)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                if (await _repository.ISMobileExistAsync(dto.ContactPhone))
                    return ApiResponse<string>.FailureResponse("Mobile already exists");

                var client = new tbl_Client
                {
                    //ClientId = dto.Id,
                    ClientName = dto.ClientName,
                    ContactEmail = dto.ContactEmail,
                    ContactPhone = dto.ContactPhone,
                    Address = dto.Address,
                    CreatedOn = DateTime.Now
                };

                await _repository.AddClientAsync(client);

                await transaction.CommitAsync();

                return ApiResponse<string>.SuccessResponse("Client Added Successfully");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ApiResponse<string>.FailureResponse(ex.Message);
            }
        }

        // ================= GET ALL CLIENTS =================

        public async Task<IEnumerable<GetClientDTO>> GetAllClientsAsync()
        {
            var clients = await _repository.GetAllClientsAsync();

            return clients.Adapt<IEnumerable<GetClientDTO>>();
        }

        // ================= GET CLIENT BY ID =================

        public async Task<GetClientDTO?> GetClientIdAsync(int id)
        {
            var client = await _repository.GetClientIdAsync(id);

            if (client == null)
                return null;

            return client.Adapt<GetClientDTO>();
        }

        // ================= UPDATE CLIENT =================

        public async Task<bool> UpdateClientAsync(int id, UpdateClientDTO dto)
        {
            var client = await _repository.GetClientIdAsync(id);

            if (client == null)
                return false;

            dto.Adapt(client);

            return await _repository.UpdatClientAsync(client);
        }

        // ================= DELETE CLIENT =================

        public async Task<bool> DeleteClientAsync(int id)
        {
            return await _repository.DeleteClientAsync(id);
        }

        // ================= MOBILE VALIDATION =================

        public async Task<ApiResponse<string>> IsMobileExistsAsync(string phone)
        {
            var exists = await _repository.ISMobileExistAsync(phone);

            if (exists)
                return ApiResponse<string>.FailureResponse("Mobile already exists");

            return ApiResponse<string>.SuccessResponse("Mobile available");
        }
    }
}
