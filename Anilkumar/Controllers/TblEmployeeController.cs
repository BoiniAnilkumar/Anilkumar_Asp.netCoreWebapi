using BALLib.Common;
using BALLib.DTOs;
using BALLib.Services.Service_Implementation;
using BALLib.Services.Service_Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anilkumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblEmployeeController : BaseController
    {
        private readonly ITblEmployeeServices _service;
        public TblEmployeeController(ITblEmployeeServices service)
        {
            _service = service;
        }
        // ================= CREATE =================

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeCreateDTO dto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return Failure("Validation failed", errors);
            }

            var id = await _service.CreateEmployeeAsync(dto);

            return Success(id, "Employee created successfully");
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _service.GetAllEmployeesAsync();
            return Success(employees, "Employees fetched successfully");
        }
        [HttpGet("{GetBy_Id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _service.GetEmployeeByIdAsync(id);

            if (employee == null)
                return NotFoundResponse("Employee not found");

            return Success(employee, "Employee fetched successfully");
        }

        [HttpPut("{UpdateBy_Id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeUpdateDTO dto)
        {
             if (dto == null)
                return BadRequest();

            var result = await _service.UpdateEmployeeAsync(id, dto);    

            if (!result)
                return NotFound();

            return Ok("Employee Updated Successfully");
        }

        // ================= DELETE (Soft Delete Ready) =================

        [HttpDelete("{DeleteBy_Id}")]
        public async Task<IActionResult> DeleteEmployee(int id) 
        {
            var result = await _service.DeleteEmployeeAsync(id);

            if (!result)
                return NotFoundResponse("Employee not found");  

            return Success(true, "Employee deleted successfully");
        }
    }
}
