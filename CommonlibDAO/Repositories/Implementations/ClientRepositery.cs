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
        public async Task<tbl_Client> AddClientAsync(tbl_Client client)
        {
            _context.tbl_Client.Add(client);
            await _context.SaveChangesAsync();
            return client;
        } 

        public async Task<List<tbl_Client>> GetAllClientsAsync()
        {
            return await _context.tbl_Client.ToListAsync();
        }

        public async Task<tbl_Client?> GetClientIdAsync(int id)
        {
            return await _context.tbl_Client
                .FirstOrDefaultAsync(x => x.ClientId == id);
        }

        public async Task<bool> UpdatClientAsync(tbl_Client client)
        {
            _context.tbl_Client.Update(client);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> DeleteClientAsync(int id)
        {
            var client = await _context.tbl_Client.FindAsync(id);

            if (client == null)
                return false;

            _context.tbl_Client.Remove(client);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ISMobileExistAsync(string ContactPhone)
        {
            return await _context.tbl_Client
                .AnyAsync(x => x.ContactPhone == ContactPhone == true);
        }

        //public Task<tbl_Client?> GetClientIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
