using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_EMP_Type
    {
        [Key]
        public int EmpTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? EmpTypeName { get; set; }

        public int? ClientId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
