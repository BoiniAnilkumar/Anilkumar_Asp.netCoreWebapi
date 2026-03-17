using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BALLib.DTOs.EmployeeDTO
{
   public class EmployeeCreateDTO
    {
        [Required]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? EmployeeName { get; set; }

        [Required]
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        public string? EmailId { get; set; }

        [Required]
        public string? GenderId { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public DateTime DOJ { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public int? SectionId { get; set; }

        [Required]
        public int DesignationId { get; set; }

        public int? LocationId { get; set; }

        public int? ReportsToEmployeeId { get; set; }

        public bool AllowProxyAttendance { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public int? WorkLocationTypeId { get; set; }

        public int? EmpTypeId { get; set; }
    }
}
