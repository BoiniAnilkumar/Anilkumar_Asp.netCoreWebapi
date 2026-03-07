using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLib.DTOs
{
    public class AddEmployeeDTO
    {
        [Required]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? EmployeeName { get; set; }
        [Required] 
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Aadhar must be 12 digits")]
        public string ? AadharNumber { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile number must be 10 digits")]
        public string? PhoneNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? EmailId { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public DateTime Doj { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public int? SectionId { get; set; }
        [Required]
        public int DesignationId { get; set; }

        //public int? WorkLocationTypeId { get; set; }
        [Required]
        public int? LocationId { get; set; }
        public int? ReportsToEmployeeId { get; set; }

        public bool IsHod { get; set; }
        public int? HodLevelId { get; set; }

        public int? EmpTypeId { get; set; }

        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }

        public bool AllowProxyAttendance { get; set; }
    }
}  
