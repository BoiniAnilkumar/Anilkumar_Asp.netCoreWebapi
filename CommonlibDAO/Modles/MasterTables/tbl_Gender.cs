using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Gender
    {
        [Key]
        public int GenderId { get; set; }

        [Required]
        [MaxLength(20)]
        public string? GenderName { get; set; }

        // Navigation Property
        public ICollection<tbl_Employee>? Employees { get; set; }
    }
}
