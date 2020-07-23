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
        private readonly ApplicationContext _db;
        public UserRepository()
        {
            this._db = new ApplicationContext();
        }
        /// <summary>
        /// Вернуть всех пользователей из БД
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetUserList()
        {
            return _db.Users;
        }

        public void Add(User user)
        {
            _db.Users.Add(user);
        }
        #region MyRegion

        #endregion
        /// <summary>
        /// Возращаем пользователья по его id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserById(int id)
        {
            return new User();
        }
        /// <summary>
        /// Получаем пользователья по номеру телефона
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public User GetUserByPhone(string phone)
        {
            return new User();
        }
        /// <summary>
        /// Получаем пользователья по адресу электронной почты
        /// </summary>
        /// <param name="emain"></param>
        /// <returns></returns>
        public User GetUserByEmain(string emain)
        {
            return new User();
        }
        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
