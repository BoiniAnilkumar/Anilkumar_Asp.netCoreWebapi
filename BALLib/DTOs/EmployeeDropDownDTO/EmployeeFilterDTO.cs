using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BALLib.DTOs.EmployeeDropDownDTO
{
    public class EmployeeFilterDTO
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public string? Search { get; set; }

        public int? ClientId { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsActive { get; set; }
    }
}
