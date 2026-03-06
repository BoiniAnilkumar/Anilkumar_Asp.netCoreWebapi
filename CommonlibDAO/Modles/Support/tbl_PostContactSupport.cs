using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Support
{
    public class tbl_PostContactSupport
    {
        [Key]
        public int SupportId { get; set; }

        public int EmployeeId { get; set; }

        [MaxLength(200)]
        public string? Issue { get; set; }

        public string? Description { get; set; }

        public byte Status { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [MaxLength(500)]
        public string? ImagePath { get; set; }

        [MaxLength(255)]
        public string? ImageFileName { get; set; }
    }
}
