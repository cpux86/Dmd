using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Modeles.Entityes
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// Аватарка пользователя
        /// </summary>
        public string Avatar { get; set; }
        public string Photo { get; set; }
    }
}
