using Dmd.Domain.Interface;
using Dmd.Domain.Modeles;
using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _user;
        public UserRepository()
        {
            this._user = new ApplicationContext();
        }

        public IEnumerable<User> GetUserList()
        {
            return _user.Users;
        }

        public void Add(User user)
        {
            _user.Users.Add(user);
        }

        //public User GetUserById(int id)
        //{

        //}
        public void Save()
        {
            _user.SaveChanges();
        }

    }
}
