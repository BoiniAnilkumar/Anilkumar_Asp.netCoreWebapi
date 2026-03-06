using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BALLib.DTOs
{
    public class LoginRequestDTO
    {
        [Required]
        public string Username { get; set; }= string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
