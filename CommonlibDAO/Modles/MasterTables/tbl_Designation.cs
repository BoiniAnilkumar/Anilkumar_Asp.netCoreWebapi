using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Designation
    {
        [Key]
        public int DesignationId { get; set; }

        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? DesignationName { get; set; }

        public int? ReportsToDesignationId { get; set; }

        public int DepartmentId { get; set; }

        public int? SectionId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsHod { get; set; }
    }
}
