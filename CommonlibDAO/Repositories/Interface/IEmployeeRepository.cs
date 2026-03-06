using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles.MasterTables;

namespace CommonlibDAO.Repositories.Interface
{
    public interface IEmployeeRepository
    {
        Task AddAsync(tbl_Employee employee);
        Task<List<tbl_Employee>> GetAllAsync();
        Task SaveAsync();
    }
}
