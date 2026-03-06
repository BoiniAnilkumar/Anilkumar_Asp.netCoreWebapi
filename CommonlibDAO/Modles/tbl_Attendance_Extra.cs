using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles
{
    public class tbl_Attendance_Extra
    {
        [Key]
        public int ExtraTimeAttendId { get; set; }

        public int? ClientId { get; set; }

        public int EmployeeId { get; set; }

        public byte TypeId { get; set; }

        public DateTime DateOfAttend { get; set; }

        public DateTime? InTime { get; set; }

        public DateTime? OutTime { get; set; }

        [MaxLength(20)]
        public string? InTimeLatitude { get; set; }

        [MaxLength(20)]
        public string? InTimeLongitude { get; set; }

        [MaxLength(20)]
        public string? OutTimeLatitude { get; set; }

        [MaxLength(20)]
        public string? OutTimeLongitude { get; set; }

        public int? DurationMinutes { get; set; }

        [MaxLength(250)]
        public string? Place { get; set; }

        public string? Remarks { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
