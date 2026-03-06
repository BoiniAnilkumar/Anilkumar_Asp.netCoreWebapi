using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace CommonlibDAO.Repositories.Implementations
{
    public class TblEmployeeRepository : ITblEmployeeRepository   
    {
        private readonly DBContextEFCore _context;
        public TblEmployeeRepository(DBContextEFCore context)
        {
            _context = context;
        }
        public async Task<int> AddEmployeeAsync(tbl_Employee employee)
        {
            try
            {
                await _context.tbl_Employee.AddAsync(employee);
                await _context.SaveChangesAsync();
                return employee.EmployeeId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException?.Message ?? ex.Message);
            }
        }
        public async Task<List<tbl_Employee>> GetAllEmployeesAsync()
        {
            return await _context.tbl_Employee
            .Include(e => e.ReportsToEmployee).ToListAsync();
        }
        public async Task<tbl_Employee?> GetEmployeeIdAsync(int Id)
        {
            return await _context.tbl_Employee
                 .Include(e => e.ReportsToEmployee)
                 .FirstOrDefaultAsync(e => e.EmployeeId == Id);
        }
        public async Task<bool> UpdateEmployeeAsync(tbl_Employee employee)
        {
            _context.tbl_Employee.Update(employee);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteEmployeeAsync(int Id)
        {
            var employee = await _context.tbl_Employee.FindAsync(Id);
            if (employee == null)
                return false;
            _context.tbl_Employee.Remove(employee);
            return await _context.SaveChangesAsync() > 0;
        }
        
        //public async Task SaveAsync()
        //{
        //    await _context.SaveChangesAsync();
        //}

        //public Task<int> SaveAsync(tbl_Employee employee)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
