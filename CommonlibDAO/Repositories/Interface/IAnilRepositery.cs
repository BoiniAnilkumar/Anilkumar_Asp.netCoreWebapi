using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles.MasterTables;

namespace CommonlibDAO.Repositories.Interface
{
    public interface IAnilRepositery
    {
        Task<tbl_Client?> GetById(int id);
    }
}
