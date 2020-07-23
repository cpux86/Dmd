using Dmd.Domain.Interface;
using Dmd.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Services
{
    class UserManager : IUserManager
    {
        private readonly IUserRepository _repo;
        public UserManager()
        {
            this._repo = new UserRepository();
        }
        /// <summary>
        /// Создаем нового пользователья
        /// </summary>
        public void CreateUser()
        {
            
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void EditUser()
        {
            throw new NotImplementedException();
        }
    }
}
