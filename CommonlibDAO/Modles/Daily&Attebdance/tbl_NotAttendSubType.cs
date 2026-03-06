using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles
{
    public class tbl_NotAttendSubType
    {
        [Key]
        public int NotAttendSubTypeId { get; set; }

        public int TypeOfNotAttend { get; set; }

        [Required]
        [MaxLength(200)]
        public string? NotAttendSubTypeName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
