using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
namespace BALLib.Security
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool verifyPassword(string enteredpassword,string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredpassword, storedHash);
        }
    }
}
