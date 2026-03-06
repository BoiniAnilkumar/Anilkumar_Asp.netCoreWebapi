using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles.MasterTables;

namespace CommonlibDAO.Repositories.Interface
{
    public interface IAddEmployeeRepository
    {

        Task<tbl_Employee> AddEmployeeAsync(tbl_Employee employee);
        Task<List<tbl_Employee>> GetAllEmployeesAsync();
        Task<tbl_Employee?> GetEmployeeIdAsync(int Id);
        Task<bool> UpdateEmployeeAsync(tbl_Employee employee);
        Task<bool> DeleteEmployeeAsync(int Id);

        Task<bool> IsMobileExistsAsync(string phoneNumber);

        Task<bool> IsEmployeeNameExistsAsync(string employeeName);

        Task<bool> IsAadharExistsAsync(string aadhar);
    }
}
