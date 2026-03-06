using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.Employee_History
{
    public class tbl_PEER_EMP_Mapping
    {
        [Key]
        public int PeerMappingId { get; set; }

        public int? EmpId { get; set; }

        [MaxLength(50)]
        public string? UserName { get; set; }

        public int? PeerEmpId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
