using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Modles.User_Security;
using CommonlibDAO.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlibDAO.Repositories.Implementations
{
    public class MasterRepository : IMasterRepository
    {
        private readonly DBContextEFCore _dBContextEFCore;
        public MasterRepository(DBContextEFCore dBContextEFCore)
        {
            _dBContextEFCore = dBContextEFCore;
        }
        public async Task<List<tbl_Gender>> GetGendersAsync()
          => await _dBContextEFCore.tbl_Gender.ToListAsync();

        public async Task<List<tbl_Department>> GetDepartmentsAsync(int clientId)
            => await _dBContextEFCore.tbl_Department
                .Where(d => d.ClientId == clientId)
                .ToListAsync();

        public async Task<List<tbl_Section>> GetSectionsAsync(int departmentId)
            => await _dBContextEFCore.tbl_Section
                .Where(s => s.DepartmentId == departmentId)
                .ToListAsync();

        public async Task<List<tbl_Designation>> GetDesignationsAsync(int clientId)
            => await _dBContextEFCore.tbl_Designation
            .Where(d => d.ClientId == clientId)
            .ToListAsync();

        public async Task<List<tbl_Location>> GetLocationsAsync(int clientId)
            => await _dBContextEFCore.tbl_Location
            .Where(l => l.ClientId == clientId)
            .ToListAsync();

        //public async Task<List<tbl_Employee>> GetEmpTypesAsync()
        //    => await _dBContextEFCore.tbl_Employee.ToListAsync();

        public async Task<List<tbl_HODLevel>> GetHodLevelsAsync()
            => await _dBContextEFCore.tbl_HODLevel.ToListAsync();
        public async Task<List<tbl_Employee>> GetReportingEmployeesAsync(int clientId)
            => await _dBContextEFCore.tbl_Employee
                .Where(e => e.ClientId == clientId)
                .ToListAsync();

        public async Task<List<tbl_Client>> GetClientAsync()
            => await _dBContextEFCore.tbl_Client.ToListAsync();
    }
}
