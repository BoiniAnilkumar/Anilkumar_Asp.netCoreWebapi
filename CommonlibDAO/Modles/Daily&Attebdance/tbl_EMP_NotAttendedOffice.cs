using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles
{
    public class tbl_EMP_NotAttendedOffice
    {
        [Key]
        public int NotAttendedId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        [MaxLength(500)]
        public string? Purpose { get; set; }

        [MaxLength(200)]
        public string? Place { get; set; }

        public int? TotalDays { get; set; }

        public byte TypeOfNotAttended { get; set; }

        public DateTime CreatedOn { get; set; }

        public byte SubTypeOfNotAttended { get; set; }

        public byte? ModeOfTravelId { get; set; }
    }
}
