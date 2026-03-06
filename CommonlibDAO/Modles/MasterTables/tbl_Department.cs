using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? DepartmentName { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
