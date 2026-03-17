using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BALLib.DTOs.EmployeeDTO
{
    public class EmployeeListDTO
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmailId {get; set;}
        public string?  ClientName { get; set; }
        public string? DepartmentName { get; set; }
        public string? DesignationName { get; set; }
        public string? ManagerName { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
