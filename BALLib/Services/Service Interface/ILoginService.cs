using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLib.Common;
using System.Threading.Tasks;
using BALLib.DTOs.LoginDTO;

namespace BALLib.Services.Service_Interface
{
    public interface ILoginService
    {
        Task<ApiResponse<LoginResponse>> LoginAsync(LoginRequestDTO request);
    }
}
