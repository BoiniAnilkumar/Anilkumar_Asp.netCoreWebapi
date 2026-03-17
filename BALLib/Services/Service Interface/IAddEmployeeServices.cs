using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLib.Common;
using BALLib.DTOs.EmployeeDTO;

namespace BALLib.Services.Service_Interface
{
    public interface IAddEmployeeServices
    {
        Task<ApiResponse<string>> AddEmployeeAsync(AddEmployeeDTO dto);

        Task<IEnumerable<EmployeeListDTO>> GetAllEmployeesAsync();

        Task<EmployeeDetilsDTO> GetEmployeeByIdAsync(int id);

        Task<bool> UpdateEmployeeAsync(int id, EmployeeUpdateDTO dto);

        Task<bool> DeleteEmployeeAsync(int id);

        Task<ApiResponse<string>> IsMobileExistsAsync(string phoneNumber);
        Task<ApiResponse<string>> IsAadharExistsAsync(string aadhar);
    }
}

