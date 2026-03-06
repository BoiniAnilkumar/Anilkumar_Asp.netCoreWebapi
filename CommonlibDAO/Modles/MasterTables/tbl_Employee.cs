using CommonlibDAO.Migrations;
using CommonlibDAO.Modles.User_Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? EmployeeName { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? EmailId { get; set; }

        
        public int GenderId { get; set; }

        public DateTime Dob { get; set; }

        public DateTime Doj { get; set; }

        public int DepartmentId { get; set; }

        public int? SectionId { get; set; }

        public int DesignationId { get; set; }

        public int? LocationId { get; set; }

        public int? ReportsToEmployeeId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool AllowProxyAttendance { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        [MaxLength(20)]
        public string? StrInTime { get; set; }

        [MaxLength(20)]
        public string? StrOutTime { get; set; }

        public int? WorkLocationTypeId { get; set; }

        public int? DId { get; set; }

        public int? EmpTypeId { get; set; }

        // =========================
        // Additional Fields
        // =========================

        [MaxLength(12)]
        public string? Aadhar { get; set; }

        public bool? IsHod { get; set; }

        public int? HodLevelId { get; set; }

        [MaxLength(20)]
        public string? DeptEmpId { get; set; }

        public int? IsFac { get; set; }

        public int? DeactivateReasonId { get; set; }

        public DateTime? DeactivatedOn { get; set; }

        public int? ProfileUpdateStatus { get; set; }

        public int? ProfileUpdateCounts { get; set; }

        [MaxLength(100)]
        public string? MultiLocation { get; set; }

        public DateTime? LocationUpdatedOn { get; set; }

        [MaxLength(30)]
        public string? TeachingOrNonTeaching { get; set; }

        public int? NotificationStatus { get; set; }

        public int? AllowFrsUpdate { get; set; }

        // =========================
        // Self Reference (Manager)
        // =========================

        public tbl_Employee? ReportsToEmployee { get; set; }
        public tbl_Gender? Gender { get; set; }

        public tbl_Department? Department { get; set; }
        public tbl_Section? Section { get; set; }
        public tbl_Designation? Designation { get; set; }
        public tbl_Location? Location { get; set; }
        public tbl_WorkLocationType? WorkLocationType { get; set; }
        public tbl_EMP_Type? EmpType { get; set; }
        public tbl_HODLevel? HodLevel { get; set; }

        public ICollection<tbl_Employee>? Subordinates { get; set; }
    }
}
