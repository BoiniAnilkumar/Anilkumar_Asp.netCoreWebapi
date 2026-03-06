using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Employee_History
{
    public class tbl_EMP_TransferHistory
    {
        [Key]
        public int TransferId { get; set; }

        public int EmployeeId { get; set; }

        public int? OldDepartmentId { get; set; }

        public int NewDepartmentId { get; set; }

        public int? OldSectionId { get; set; }

        public int? NewSectionId { get; set; }

        public int? OldDesignationId { get; set; }

        public int? NewDesignationId { get; set; }

        public int? OldReportsToEmployeeId { get; set; }

        public int? NewReportsToEmployeeId { get; set; }

        public int? ChangedBy { get; set; }

        public DateTime ChangedOn { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }
    }
}
