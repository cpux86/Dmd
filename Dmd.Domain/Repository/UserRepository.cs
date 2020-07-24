using Dmd.Domain.Interface;
using Dmd.Domain.Modeles;
using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
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


        #region CREATE 

        /// <summary>
        /// Создать нового пользователья в БД
        /// </summary>
        /// <param name="user"></param>
        public void CreateUser(User user)
        {
            // проверка на сеществования пользователей с emain  и phone
             IQueryable<User> r = _db.Users.Where(u => u.Email == user.Email || u.Phone == user.Phone);
            var t = r.Count();
            foreach (var item in r)
            {
                var g = item;
            }

        }

        #endregion
        #region READ
        /// <summary>
        /// Вернуть всех пользователей из БД
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetUserList()
        {
            return _db.Users;
        }

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
        /// Получить пользователья по его Guid
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public User GetUserByGuid(string guid)
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
        #endregion
        #region UPDATE

        #endregion
        #region DELETE
        /// <summary>
        /// Удалить пользователя по его id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUserById(int id)
        {

        }
        /// <summary>
        /// Удалить пользователья по его GUID
        /// </summary>
        public void DeleteUserByGuid(string guid)
        {

        }
        #endregion





        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
