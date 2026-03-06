using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles
{
    public class tbl_Holiday
    {
        [Key]
        public int HolidayId { get; set; }

        public DateTime HolidayDate { get; set; }

        [Required]
        [MaxLength(200)]
        public string? HolidayName { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public bool IsPublic { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }

        [MaxLength(100)]
        public string? CreatedBy { get; set; }

        public int? ClientId { get; set; }
    }
}
