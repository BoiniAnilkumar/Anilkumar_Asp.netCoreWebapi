using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.FR_System
{
    public class tbl_FAC_Dtls
    {
        [Key]
        public int FacMappingId { get; set; }

        public int EmployeeId { get; set; }

        public int SectionId { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        public int? AssignedBy { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? ModifiedBy { get; set; }
    }
}
