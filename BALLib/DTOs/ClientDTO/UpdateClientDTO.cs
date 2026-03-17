using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLib.DTOs.ClientDTO
{
    public class UpdateClientDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Only alphabets allowed")]
        public string ClientName { get; set; } = string.Empty;

        // [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string ContactEmail { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile number must be 10 digits")]
        public string ContactPhone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
