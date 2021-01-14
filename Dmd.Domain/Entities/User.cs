using System;
using System.ComponentModel.DataAnnotations;

namespace Dmd.Domain.Entities
{
    public class User : BaseEntities
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid Identity { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
        /// <summary>
        /// Аватарка пользователя
        /// </summary>
        [Display(Name = "Аватарка")]
        public string Avatar { get; set; }
        public string Photo { get; set; }
    }
}
