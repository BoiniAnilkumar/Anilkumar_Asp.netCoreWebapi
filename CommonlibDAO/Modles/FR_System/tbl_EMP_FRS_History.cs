using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.FR_System
{
    public class tbl_EMP_FRS_History
    {
        [Key]
        public int HistoryId { get; set; }

        public int FrsId { get; set; }

        public int EmployeeId { get; set; }

        public string? ImageTemplate { get; set; }

        public byte? FrsStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime DeletedOn { get; set; }

        [MaxLength(300)]
        public string? ImagePath { get; set; }

        [MaxLength(300)]
        public string? ImageFileName { get; set; }

        public int? DeletedBy { get; set; }

        [MaxLength(300)]
        public string? DeletedReason { get; set; }
    }
}
