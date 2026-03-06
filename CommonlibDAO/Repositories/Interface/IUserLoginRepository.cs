using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles;
using CommonlibDAO.Modles.User_Security;


namespace CommonlibDAO.Repositories.Interface
{
    public interface IUserLoginRepository
    {
        Task<tbl_UserLogin?> GetByUsernameAsync(string username);
    }
}
