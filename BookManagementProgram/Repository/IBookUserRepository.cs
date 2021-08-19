using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram.Repository
{
    interface IBookUserRepository
    {
        string Login(string userId, string userPw);

        string FindById(string userNo, string userName);

        bool FindByPassword(string userNo, string userId, string newPassword);
    }
}
