using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles
{
    public class tbl_Notifications
    {
        [Key]
        public int NotificationId { get; set; }

        public string? NotificationText { get; set; }

        public byte? Status { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
  