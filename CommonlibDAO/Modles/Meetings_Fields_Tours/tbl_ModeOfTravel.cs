using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Meetings_Fields_Tours
{
    public class tbl_ModeOfTravel
    {
        [Key]
        public int ModeOfTravelId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? ModeName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
