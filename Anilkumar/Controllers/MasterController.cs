using BALLib.Services.Service_Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anilkumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : BaseController
    {
        private readonly IMasterService _service;

        public MasterController(IMasterService service)
        {
            _service = service;
        }

        [HttpGet("genders")]
        public async Task<IActionResult> GetGenders()
            => Success((await _service.GetGendersAsync()).Data);

        [HttpGet("departments/{clientId}")]
        public async Task<IActionResult> GetDepartments(int clientId)
            => Success((await _service.GetDepartmentsAsync(clientId)).Data);

        [HttpGet("sections/{departmentId}")]
        public async Task<IActionResult> GetSections(int departmentId)
            => Success((await _service.GetSectionsAsync(departmentId)).Data);

        [HttpGet("designations")]
        public async Task<IActionResult> GetDesignations()
            => Success((await _service.GetDesignationsAsync()).Data);

        [HttpGet("locations")]
        public async Task<IActionResult> GetLocations()
            => Success((await _service.GetLocationsAsync()).Data);

        [HttpGet("emptypes")]
        public async Task<IActionResult> GetEmpTypes()
            => Success((await _service.GetEmpTypesAsync()).Data);

        [HttpGet("ReportingEmpId/{clientId}")]
        public async Task<IActionResult> GetReportingEmployees(int clientId)
            => Success((await _service.GetReportingEmployeesAsync(clientId)).Data);

        [HttpGet("hodlevels")]
        public async Task<IActionResult> GetHodLevels()
            => Success((await _service.GetHodLevelsAsync()).Data);

        [HttpGet("clients")]
        public async Task<IActionResult> GetClients()
            => Success((await _service.GetClientAsync()).Data);
    }
}
   