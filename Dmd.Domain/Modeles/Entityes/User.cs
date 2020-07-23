using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Dmd.Domain.Modeles.Entityes
{
    public class User
    {
        public User()
        {
            this.Guid = Guid.NewGuid();
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid Identity { get; set; }
        public int Id { get; set; }

        public Guid Guid { get; set; }
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
