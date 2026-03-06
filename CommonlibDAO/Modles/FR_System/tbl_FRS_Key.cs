using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.FR_System
{
    public class tbl_FRS_Key
    {
        [Key]
        public int? KeyId { get; set; }

        [MaxLength(100)]
        public string? KeyName { get; set; }

        public string? KeyValue { get; set; }
    }
}
