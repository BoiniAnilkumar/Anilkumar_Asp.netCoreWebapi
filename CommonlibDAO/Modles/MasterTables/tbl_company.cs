using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(255)]
        public string? CompanyName { get; set; }
    }
}
