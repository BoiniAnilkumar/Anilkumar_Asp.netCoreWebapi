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
        Task<ApiResponse<List<GetClientDTO>>> GetAllClientsAsync();
    }
}
