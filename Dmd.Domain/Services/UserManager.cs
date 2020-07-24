using Dmd.Domain.Interface;
using Dmd.Domain.Modeles.Entityes;
using Dmd.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Services
{
    class UserManager : IUserManager
    {
        private readonly IUserRepository _db;
        public UserManager()
        {
            this._db = new UserRepository();
        }
    }
}
