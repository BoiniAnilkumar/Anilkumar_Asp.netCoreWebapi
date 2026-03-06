using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CommonlibDAO.Repositories.Implementations
{
    public class AddEmployeeRepository : IAddEmployeeRepository
    {
        private readonly DBContextEFCore _context;

        public AddEmployeeRepository(DBContextEFCore context)
        {
            _context = context;
        }

        public async Task<tbl_Employee> AddEmployeeAsync(tbl_Employee employee)
        {
            _context.tbl_Employee.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
        async Task<bool> IAddEmployeeRepository.UpdateEmployeeAsync(tbl_Employee employee)
        {
            _context.tbl_Employee.Update(employee);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<tbl_Employee?> GetEmployeeIdAsync(int Id)
        {
            return await _context.tbl_Employee
                .Include(e => e.ReportsToEmployee)
                .FirstOrDefaultAsync(e => e.EmployeeId == Id);
        }
        public async Task<tbl_Employee?> GetEmployeeNameAsync(string employeeName)
        {
            return await _context.tbl_Employee
                .Include(e => e.ReportsToEmployee)
                .FirstOrDefaultAsync(e => e.EmployeeName == employeeName);
        }
        public async Task<List<tbl_Employee>> GetAllEmployeesAsync()
        {
            return await _context.tbl_Employee
                .Include(e => e.ReportsToEmployee)
                .ToListAsync();
        }
        public async Task<bool> DeleteEmployeeAsync(int Id)
        {
           var employee = await _context.tbl_Employee.FindAsync(Id);
            if (employee == null)
                return false;
            _context.tbl_Employee.Remove(employee);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> IsMobileExistsAsync(string phoneNumber)
        {
            return await _context.tbl_Employee
                .AnyAsync(e => e.PhoneNumber == phoneNumber && e.IsActive == true);
        }

        public async Task<bool> IsEmployeeNameExistsAsync(string employeeName)
        {
            return await _context.tbl_Employee
                .AnyAsync(e => e.EmployeeName == employeeName && e.IsActive == true);
        }

        public async Task<bool> IsAadharExistsAsync(string aadhar)
        {
            return await _context.tbl_Employee
                .AnyAsync(e => e.Aadhar == aadhar && e.IsActive == true);
        }       
    }
}
