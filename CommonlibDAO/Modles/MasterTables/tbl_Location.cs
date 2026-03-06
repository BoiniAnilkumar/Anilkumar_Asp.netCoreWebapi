using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Location
    {
        [Key]
        public int LocationId { get; set; }

        public int ClientId { get; set; }

        [Required]
        [MaxLength(200)]
        public string? LocationName { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Latitude { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Longitude { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }

        [MaxLength(100)]
        public string? CreatedBy { get; set; }
    }
}
