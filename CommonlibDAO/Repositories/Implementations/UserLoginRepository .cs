using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonlibDAO.Modles;
using CommonlibDAO.Modles.User_Security;
using CommonlibDAO.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CommonlibDAO.Repositories.Implementations
{
    public class UserLoginRepository: IUserLoginRepository
    {
        private readonly  DBContextEFCore _context;

        public UserLoginRepository(DBContextEFCore context)
        {
            _context = context;
        }

        public async Task<tbl_UserLogin?> GetByUsernameAsync(string UserName)
        {
            return await _context.tbl_UserLogin
                .FirstOrDefaultAsync(x => x.UserName == UserName);
        }
    }
}
