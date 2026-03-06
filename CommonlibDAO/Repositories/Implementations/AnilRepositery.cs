using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Repositories.Interface;

namespace CommonlibDAO.Repositories.Implementations
{
    public class AnilRepositery : IAnilRepositery
    {
        private readonly DBContextEFCore _context;
        public AnilRepositery(DBContextEFCore context)
        {
            _context = context;
        }
        public async Task<tbl_Client?> GetById(int id)
        {
            return await _context.tbl_Client.FindAsync(id);
        }
        
    }
}
