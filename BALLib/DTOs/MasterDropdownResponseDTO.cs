using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BALLib.DTOs
{
    public class MasterDropdownResponseDTO
    {
        public List<DropdownDTO>? Genders { get; set; }
        public List<DropdownDTO>? Departments { get; set; }
        public List<DropdownDTO>? Sections { get; set; }
        public List<DropdownDTO>? Designations { get; set; }
        public List<DropdownDTO>? Locations { get; set; }
        public List<DropdownDTO>? WorkLocationTypes { get; set; }
        public List<DropdownDTO>? ReportsToEmployeeId { get; set; }
        public List<DropdownDTO>? HodLevels { get; set; }
        public List<DropdownDTO>? ReportingEmployees { get; set; }
        public List<DropdownDTO>? Clients { get; set; }
    }
}
