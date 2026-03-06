using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Support
{
    public class tbl_DeactivateReasons
    {
        [Key]
        public int DeactivateReasonId { get; set; }

        [MaxLength(100)]
        public string? DeactivateReason { get; set; }
    }
}
