using Dmd.Domain.Modeles.Entityes;
using System.Collections.Generic;

namespace Dmd.Domain.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void DeleteUserByGuid(string guid);
        void DeleteUserById(int id);
        User GetUserByEmain(string emain);
        User GetUserByGuid(string guid);
        User GetUserById(int id);
        User GetUserByPhone(string phone);
        IEnumerable<User> GetUserList();
        void Save();
    }
}