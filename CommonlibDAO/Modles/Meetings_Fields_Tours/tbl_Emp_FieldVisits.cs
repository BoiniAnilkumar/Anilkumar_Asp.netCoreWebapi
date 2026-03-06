using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonlibDAO.Modles.Meetings_Fields_Tours
{
    public class tbl_Emp_FieldVisits
    {
        [Key]
        public long FieldVisitId { get; set; }

        public int EmployeeId { get; set; }

        public int ClientId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime VisitDate { get; set; }

        [MaxLength(20)]
        public string? Latitude { get; set; }

        [MaxLength(20)]
        public string? Longitude { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }
    }
}
