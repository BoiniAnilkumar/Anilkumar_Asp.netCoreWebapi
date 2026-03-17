using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles;
using CommonlibDAO.Modles.MasterTables;

namespace CommonlibDAO.Repositories.Interface
{
    public interface IClientRepositery
    {
        Task<List<tbl_Client>> GetAllClientsAsync();
        Task<tbl_Client>AddClientAsync(tbl_Client client);
        Task<tbl_Client?> GetClientIdAsync(int id);
        Task<bool>UpdatClientAsync(tbl_Client client);
        Task<bool>DeleteClientAsync(int id);
        Task<bool> ISMobileExistAsync(string ContactPhone);
    }
}

