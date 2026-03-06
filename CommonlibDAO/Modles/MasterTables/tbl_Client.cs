using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(200)]
        public string? ClientName { get; set; }

        [MaxLength(200)]
        public string? ContactEmail { get; set; }

        [MaxLength(15)]
        public string? ContactPhone { get; set; }

        [MaxLength(500)]
        public string? Address { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
