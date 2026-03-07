using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Modles.User_Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlibDAO.Repositories.Interface
{
    public interface IMasterRepository
    {
        Task<List<tbl_Gender>> GetGendersAsync();
        Task<List<tbl_Department>> GetDepartmentsAsync(int clientId);
        Task<List<tbl_Section>> GetSectionsAsync(int departmentId);
        Task<List<tbl_Designation>> GetDesignationsAsync(int clientId);
        Task<List<tbl_Location>> GetLocationsAsync(int clientId);
        //Task<List<tbl_Employee>> GetEmpTypesAsync();
        Task<List<tbl_HODLevel>> GetHodLevelsAsync();
        Task<List<tbl_Employee>> GetReportingEmployeesAsync(int clientId);
        Task<List<tbl_Client>> GetClientAsync();

    }
}
