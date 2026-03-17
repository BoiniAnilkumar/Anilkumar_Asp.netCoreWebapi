using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BALLib.Services.Service_Interface;
using System.Threading.Tasks;
using BALLib.DTOs.EmployeeDTO;

namespace Anilkumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        private readonly IAddEmployeeServices _addEmployeeServices;
        public EmployeeController(IAddEmployeeServices addEmployeeServices)
        {
            _addEmployeeServices = addEmployeeServices;
        }
        [HttpPost("employee-register")]
        public async Task<IActionResult> AddEmployee(AddEmployeeDTO dto)
        {
            var result = await _addEmployeeServices.AddEmployeeAsync(dto);
            if (!result.Success)
                return Failure(result.Message, result.Errors);
            return Success(result.Data, result.Message);
        }
        // ================= GET ALL EMPLOYEES =================
        [HttpGet("employees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _addEmployeeServices.GetAllEmployeesAsync();
            return Ok(employees);
        }

        // ================= GET EMPLOYEE BY ID =================
        [HttpGet("employee/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _addEmployeeServices.GetEmployeeByIdAsync(id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }

        // ================= UPDATE EMPLOYEE =================
        [HttpPost("employee-update/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeUpdateDTO dto)
        {
            var result = await _addEmployeeServices.UpdateEmployeeAsync(id, dto);

            if (!result)
                return NotFound("Employee not found");

            return Ok("Employee updated successfully");
        }

        // ================= DELETE EMPLOYEE =================
        [HttpDelete("employee-delete/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _addEmployeeServices.DeleteEmployeeAsync(id);

            if (!result)
                return NotFound("Employee not found");

            return Ok("Employee deleted successfully");
        }

    }
}
  
