using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Meetings_Fields_Tours
{
    public class tbl_EmpMeetings
    {
        [Key]
        public int MeetingId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime DateOfMeeting { get; set; }

        [MaxLength(20)]
        public string? FromTime { get; set; }

        [MaxLength(20)]
        public string? ToTime { get; set; }

        [MaxLength(500)]
        public string? Purpose { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? MeetingTypeId { get; set; }
    }
}
