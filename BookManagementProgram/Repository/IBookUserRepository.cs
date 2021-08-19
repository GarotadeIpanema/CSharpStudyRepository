namespace BookManagementProgram.Repository
{
    interface IBookUserRepository
    {
        string Login(string userId, string userPw);

        string FindById(string userNo, string userName);

        bool FindByPassword(string userNo, string userId, string newPassword);

        bool InsertLoginLog();
    }
}
