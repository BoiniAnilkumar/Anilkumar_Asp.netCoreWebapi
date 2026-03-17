using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLib.Common;
using BALLib.DTOs.EmployeeDropDownDTO;

namespace BALLib.Services.Service_Interface
{
    public interface IMasterService
    {
        Task<ApiResponse<List<DropdownDTO>>> GetGendersAsync();
        Task<ApiResponse<List<DropdownDTO>>> GetDepartmentsAsync(int clientId);
        Task<ApiResponse<List<DropdownDTO>>> GetSectionsAsync(int departmentId);
        Task<ApiResponse<List<DropdownDTO>>> GetDesignationsAsync(int clientId);
        Task<ApiResponse<List<DropdownDTO>>> GetLocationsAsync(int clientId);
        //Task<ApiResponse<List<DropdownDTO>>> GetEmpTypesAsync();
        Task<ApiResponse<List<DropdownDTO>>> GetHodLevelsAsync();
        Task<ApiResponse<List<DropdownDTO>>> GetReportingEmployeesAsync(int clientId);
        Task<ApiResponse<List<DropdownDTO>>> GetClientAsync();
    }
}
