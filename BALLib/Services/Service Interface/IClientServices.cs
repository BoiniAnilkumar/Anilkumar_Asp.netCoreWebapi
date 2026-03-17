using BALLib.Common;
using BALLib.DTOs;
using BALLib.DTOs.ClientDTO;
using CommonlibDAO.Modles.MasterTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLib.Services.Service_Interface
{
    public interface IClientServices
    {
        //Task<ApiResponse<List<GetClientDTO>>> GetAllClientsAsync();
        //Task<ApiResponse<tbl_Client>> AddClientAsync(tbl_Client client);
        //Task<ApiResponse<tbl_Client>>GetClientByidAsync(int id);
        //Task<ApiResponse<bool>> UpdateClientAsync(tbl_Client client);
        //Task<ApiResponse<bool>>DeleteClientAsync(int id);
        //Task<ApiResponse<string>> IsMobileExistAsync(string ContactPhone);
        Task<ApiResponse<string>> AddClientAsync(AddClientDTO dto);

        Task<IEnumerable<GetClientDTO>> GetAllClientsAsync();

        Task<GetClientDTO?> GetClientIdAsync(int id);

        Task<bool> UpdateClientAsync(int id, UpdateClientDTO dto);

        Task<bool> DeleteClientAsync(int id);

        Task<ApiResponse<string>> IsMobileExistsAsync(string phone);
    }
}
