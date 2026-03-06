using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Employee_History
{
    public class tbl_EmployeeReportingHistory
    {
        [Key]
        public int HistoryId { get; set; }

        public int ClientId { get; set; }

        public int DepartmentId { get; set; }

        public int EmployeeId { get; set; }

        public int OldReportsToEmployeeId { get; set; }

        public int NewReportsToEmployeeId { get; set; }

        public DateTime ChangedOn { get; set; }

        public int ChangedBy { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }
    }
}
