using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Dist
    {
        [Key]
        public int DId { get; set; }

        [MaxLength(100)]
        public string? DName { get; set; }
    }
}
