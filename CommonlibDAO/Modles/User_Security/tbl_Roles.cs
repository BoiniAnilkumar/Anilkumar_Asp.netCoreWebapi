using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlibDAO.Modles.User_Security
{
    public class tbl_Roles
    {
        [Key]
        public int RoleId { get; set; }

        [MaxLength(20)]
        public string? RoleName { get; set; }

        [MaxLength(50)]
        public string? Role { get; set; }
    }
}
