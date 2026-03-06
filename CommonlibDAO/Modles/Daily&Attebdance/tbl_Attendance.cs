using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles
{
    public class tbl_Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime DateOfAttend { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? MarkedByEmployeeId { get; set; }

        [MaxLength(20)]
        public string? InTimeLatitude { get; set; }

        [MaxLength(20)]
        public string? InTimeLongitude { get; set; }

        [MaxLength(20)]
        public string? OutTimeLatitude { get; set; }

        [MaxLength(20)]
        public string? OutTimeLongitude { get; set; } 
    }
}
