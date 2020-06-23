using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.DataModeles
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// Аватарка пользователя
        /// </summary>
        public string Avatar { get; set; }
        public string Photo { get; set; }
    }
}
