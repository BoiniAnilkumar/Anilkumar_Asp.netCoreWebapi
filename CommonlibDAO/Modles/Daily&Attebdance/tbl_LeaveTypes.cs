using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles
{
    public class tbl_LeaveTypes
    {
        [Key]
        public int LeaveTypeId { get; set; }

        [Required]
        [MaxLength(200)]
        public string? LeaveTypeName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
