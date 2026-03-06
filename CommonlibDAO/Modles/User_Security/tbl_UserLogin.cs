using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommonlibDAO.Modles.User_Security
{
    public class tbl_UserLogin
    {
        [Key]
        public int UserId { get; set; }

        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? UserName { get; set; }

        [Required]
        [MaxLength(256)]
        public string? PasswordHash { get; set; }

        [MaxLength(50)]
        public string? Role { get; set; }

        public int? EmployeeId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? FailedAttempts { get; set; }

        public DateTime? LastFailedAttempt { get; set; }

        public DateTime? LockoutUntil { get; set; }
    }
}
