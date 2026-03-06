using BALLib.Common;
using BALLib.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BALLib.Services.Service_Interface
{
    public interface IAnilServices
    {
        Task<ApiResponse<ClientDTO>> GetClientById(int id);
        //Task<ApiResponse<List<ClientDTO>>> GetAllClientsAsync();
    }
}
 