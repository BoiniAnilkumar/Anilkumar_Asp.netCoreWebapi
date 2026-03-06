using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.User_Security
{
    public class tbl_HODLevel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string? HodLevel { get; set; }
    }
}
