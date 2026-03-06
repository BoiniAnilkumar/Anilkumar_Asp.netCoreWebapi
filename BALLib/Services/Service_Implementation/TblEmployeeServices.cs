using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLib.Services.Service_Interface;
using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Repositories.Interface;
using BALLib.DTOs;
using Mapster;


namespace BALLib.Services.Service_Implementation
{
    public class TblEmployeeServices : ITblEmployeeServices
    {
        private readonly ITblEmployeeRepository _employeeRepository;
        public TblEmployeeServices(ITblEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> CreateEmployeeAsync(EmployeeCreateDTO dto)
        {
            var employee = dto.Adapt<tbl_Employee>();
            employee.CreatedOn = DateTime.UtcNow;
            //employee.updated_on = DateTime.UtcNow;
            employee.IsActive = true;
           return await _employeeRepository.AddEmployeeAsync(employee);

        }  

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            return await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task<IEnumerable<EmployeeListDTO>> GetAllEmployeesAsync()
        {
            var employees = await _employeeRepository.GetAllEmployeesAsync();   
            return employees.Adapt<IEnumerable<EmployeeListDTO>>();
        }

        public async Task<EmployeeDetilsDTO> GetEmployeeByIdAsync(int id)
        {
            var employee = await _employeeRepository.GetEmployeeIdAsync(id);
            return employee.Adapt<EmployeeDetilsDTO>();
        }

        public async Task<bool> UpdateEmployeeAsync(int id, EmployeeUpdateDTO dto)
        {
            var employee = await _employeeRepository.GetEmployeeIdAsync(id);
            if(employee == null)
            {
                return false;
            }
            dto.Adapt(employee);
            employee.UpdatedOn = DateTime.UtcNow;
            return await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
