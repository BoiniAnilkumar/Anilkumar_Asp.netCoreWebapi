using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BALLib.DTOs
{
    public class EmployeeDropdownDTO
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
    }
}
