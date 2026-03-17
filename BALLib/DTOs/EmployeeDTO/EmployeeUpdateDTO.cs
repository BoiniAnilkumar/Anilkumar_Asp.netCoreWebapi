using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BALLib.DTOs.EmployeeDTO
{
    public class EmployeeUpdateDTO
    {
        public string? EmployeeName { get; set; }
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        public string? EmailId { get; set; }
        public int GenderId { get; set; }
        public DateTime Dob { get; set; }
        public DateTime Doj { get; set; }

        public int? DepartmentId { get; set; }

        public int? SectionId { get; set; }

        public int? DesignationId { get; set; }

        public int? LocationId { get; set; }

        public int? ReportsToEmployeeId { get; set; }

        public bool AllowProxyAttendance { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public int? WorkLocationTypeId { get; set; }

        public int? EmpTypeId { get; set; }
    }
}
