using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.FR_System
{
    public class tbl_EMP_FRS_Registration
    {
        [Key]
        public int Frs_Id { get; set; }

        public int EmployeeId { get; set; }

        [MaxLength(500)]
        public string? ImagePath { get; set; }

        [MaxLength(255)]
        public string? ImageFileName { get; set; }

        public string? ImageTemplate { get; set; }

        public byte? FrsStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
