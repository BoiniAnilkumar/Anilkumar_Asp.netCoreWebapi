using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BALLib.DTOs.EmployeeDTO
{
    public class EmployeeDetilsDTO
    {
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public string? EmployeeName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Aadhar { get; set;}
        public string? EmailId { get; set; }
        public string? Gender { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        public int DesignationId { get; set; }
        public int? LocationId { get; set; }
        public int? ReportsToEmployeeId { get; set; }
        public bool IsActive { get; set; }
        public bool AllowProxyAttendance { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public int? WorkLocationTypeId { get; set; }
        public int? EmpTypeId { get; set; }
    }
}
