using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Employee_History
{
    public class tbl_EMP_History
    {
        [Key]
        public int HistoryId { get; set; }

        public int EmployeeId { get; set; }

        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? EmployeeName { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? EmailId { get; set; }

        [MaxLength(1)]
        public string? Gender { get; set; }

        public DateTime Dob { get; set; }

        public DateTime Doj { get; set; }

        public int DepartmentId { get; set; }

        public int? SectionId { get; set; }

        public int DesignationId { get; set; }

        public int? LocationId { get; set; }

        public int? ReportsToEmployeeId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool AllowProxyAttendance { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        [MaxLength(20)]
        public string? StrInTime { get; set; }

        [MaxLength(20)]
        public string? StrOutTime { get; set; }

        public int? WorkLocationTypeId { get; set; }

        public DateTime ChangedOn { get; set; }

        public int? EmpTypeId { get; set; }
    }
}
