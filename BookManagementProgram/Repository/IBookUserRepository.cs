using BookManagementProgram.Model;
using System.Collections.Generic;
using System.Data;

namespace BookManagementProgram.Repository
{
    interface IBookUserRepository
    {
        string Login(string userId, string userPw);

        string FindById(string userNo, string userName);

        bool FindByPassword(string userNo, string userId, string newPassword);

        bool InsertLoginLog();

        DataTable GetAllUsers();

        Dictionary<string, object> GetAuthList();
        Dictionary<string, object> GetGradeList();

        bool AddUser(User user);

        User GetUserByNumber(string userNo);

        bool DeleteUserByNumber(string userNo);

        bool UpdateUserInfo(User user);
    }
}
