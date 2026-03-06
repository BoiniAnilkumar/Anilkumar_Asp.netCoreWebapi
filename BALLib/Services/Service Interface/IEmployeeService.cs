using BALLib.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BALLib.Services.Service_Interface
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO> CreateAsync(CreateEmployeeDTO dto);
        Task<List<EmployeeDTO>> GetAllAsync();
       
    }
}
