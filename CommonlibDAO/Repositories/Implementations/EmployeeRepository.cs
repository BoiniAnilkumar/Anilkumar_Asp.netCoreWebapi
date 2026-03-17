//using CommonlibDAO;
//using CommonlibDAO.Modles;
//using CommonlibDAO.Modles.MasterTables;
//using CommonlibDAO.Repositories.Interface;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CommonlibDAO.Repositories.Implementations
//{
//    public class EmployeeRepository : IEmployeeRepository
//    {
//        private readonly DBContextEFCore _context;

//        public EmployeeRepository(DBContextEFCore context)
//        {
//            _context = context;
//        }

//        public async Task AddAsync(tbl_Employee employee)
//        {
//            await _context.tbl_Employee.AddAsync(employee);
//        }

//        public async Task<List<tbl_Employee>> GetAllAsync()
//        {
//            return await _context.tbl_Employee.ToListAsync();
//        }

//        public async Task SaveAsync()
//        {
            
//            await _context.SaveChangesAsync();
//        }
//    }
//}
