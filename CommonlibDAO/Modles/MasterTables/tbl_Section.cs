using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.MasterTables
{
    public class tbl_Section
    {
        [Key]
        public int SectionId { get; set; }

        public int ClientId { get; set; }

        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? SectionName { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
