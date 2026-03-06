using CommonlibDAO.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles;
using Microsoft.EntityFrameworkCore;
using CommonlibDAO.Modles.MasterTables;


namespace CommonlibDAO.Repositories.Implementations
{
    public class ClientRepositery : IClientRepositery
    {
        private readonly DBContextEFCore _context;

        public ClientRepositery(DBContextEFCore context)
        {
            _context = context;
        }

        public async Task<List<tbl_Client>> GetAllClientsAsync()
        {
            return await _context.tbl_Client.ToListAsync();
        }
    }
}
