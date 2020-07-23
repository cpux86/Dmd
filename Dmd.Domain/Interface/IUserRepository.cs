using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Interface
{
    interface IUserRepository
    {
        // User GetUserById(int id);
        /// <summary>
        /// Вернуть всех пользователей из БД
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetUserList();
    }
}
