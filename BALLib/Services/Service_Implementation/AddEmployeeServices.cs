using BALLib.Common;
using BALLib.DTOs;
using BALLib.Services.Service_Interface;
using CommonlibDAO;
using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Repositories.Implementations;
using CommonlibDAO.Repositories.Interface;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace BALLib.Services.Service_Implementation
{
    public class AddEmployeeServices : IAddEmployeeServices
    {
        private readonly IAddEmployeeRepository _repository;
        private readonly DBContextEFCore _context;

        public AddEmployeeServices(
            IAddEmployeeRepository repository,
            DBContextEFCore context)
        {
            _repository = repository;
            _context = context;
        }

        // ================= ADD EMPLOYEE =================

        public async Task<ApiResponse<string>> AddEmployeeAsync(AddEmployeeDTO dto)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                if (await _repository.IsMobileExistsAsync(dto.PhoneNumber))
                    return ApiResponse<string>.FailureResponse("Mobile number already exists");

                if (!string.IsNullOrEmpty(dto.AadharNumber) &&
                    await _repository.IsAadharExistsAsync(dto.AadharNumber))
                    return ApiResponse<string>.FailureResponse("Aadhar already exists");
                // ================= REPORTING MANAGER VALIDATION =================

                if (dto.ReportsToEmployeeId.HasValue)
                {
                    var reportingEmployee =
                        await _repository.GetEmployeeIdAsync(dto.ReportsToEmployeeId.Value);

                    if (reportingEmployee == null)
                        return ApiResponse<string>.FailureResponse("Reporting Employee does not exist.");
                }

                // ================= HOD VALIDATION =================

                if (dto.IsHod && dto.HodLevelId == null)
                    return ApiResponse<string>.FailureResponse("HOD Level is required when employee is HOD.");

                if (!dto.IsHod)
                    dto.HodLevelId = null;


                var employee = new tbl_Employee
                {
                    ClientId = dto.ClientId,
                    EmployeeName = dto.EmployeeName,
                    PhoneNumber = dto.PhoneNumber,
                    Aadhar = dto.AadharNumber,
                    EmailId = dto.EmailId,
                    GenderId = dto.GenderId,
                    Dob = dto.Dob,
                    Doj = dto.Doj,
                    DepartmentId = dto.DepartmentId,
                    SectionId = dto.SectionId,
                    DesignationId = dto.DesignationId,
                    LocationId = dto.LocationId,
                    //WorkLocationTypeId = dto.WorkLocationTypeId,
                    ReportsToEmployeeId = dto.ReportsToEmployeeId,
                    IsHod = dto.IsHod,
                    HodLevelId = dto.HodLevelId,
                   // EmpTypeId = dto.EmpTypeId,
                    InTime = dto.InTime,
                    OutTime = dto.OutTime,
                    AllowProxyAttendance = dto.AllowProxyAttendance,
                    IsActive = true,
                    CreatedOn = DateTime.Now
                };

                await _repository.AddEmployeeAsync(employee);

                await transaction.CommitAsync();

                return ApiResponse<string>.SuccessResponse("Employee Registered Successfully");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ApiResponse<string>.FailureResponse(ex.Message);
            }
        }

        // ================= GET ALL =================

        public async Task<IEnumerable<EmployeeListDTO>> GetAllEmployeesAsync()
        {
            var employees = await _repository.GetAllEmployeesAsync();
            return employees.Adapt<IEnumerable<EmployeeListDTO>>();
        }

        // ================= GET BY ID =================

        public async Task<EmployeeDetilsDTO> GetEmployeeByIdAsync(int id)
        {
            var employee = await _repository.GetEmployeeIdAsync(id);

            if (employee == null)
                return null;

            return employee.Adapt<EmployeeDetilsDTO>();
        }

        // ================= UPDATE =================

        public async Task<bool> UpdateEmployeeAsync(int id, EmployeeUpdateDTO dto)
        {
            var employee = await _repository.GetEmployeeIdAsync(id);

            if (employee == null)
                return false;

            dto.Adapt(employee);

            employee.UpdatedOn = DateTime.UtcNow;

            return await _repository.UpdateEmployeeAsync(employee);
        }

        // ================= DELETE =================

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            return await _repository.DeleteEmployeeAsync(id);
        }

        // ================= VALIDATIONS =================

        public async Task<ApiResponse<string>> IsMobileExistsAsync(string phoneNumber)
        {
            var exists = await _repository.IsMobileExistsAsync(phoneNumber);

            if (exists)
                return ApiResponse<string>.FailureResponse("Mobile already exists");

            return ApiResponse<string>.SuccessResponse("Mobile available");
        }

        //public async Task<ApiResponse<string>> IsEmployeeNameExistsAsync(string employeeName)
        //{
        //    var exists = await _repository.IsEmployeeNameExistsAsync(employeeName);

        //    if (exists)
        //        return ApiResponse<string>.FailureResponse("Employee name already exists");

        //    return ApiResponse<string>.SuccessResponse("Employee name available");
        //}

        public async Task<ApiResponse<string>> IsAadharExistsAsync(string aadhar)
        {
            var exists = await _repository.IsAadharExistsAsync(aadhar);

            if (exists)
                return ApiResponse<string>.FailureResponse("Aadhar already exists");

            return ApiResponse<string>.SuccessResponse("Aadhar available");
        }

        //public async Task<ApiResponse<string>> IsEmailExistsAsync(string email)
        //{
        //    var exists = await _context.tbl_Employee
        //        .AnyAsync(e => e.EmailId == email && e.IsActive == true);

        //    if (exists)
        //        return ApiResponse<string>.FailureResponse("Email already exists");

        //    return ApiResponse<string>.SuccessResponse("Email available");
        //}
    }
}