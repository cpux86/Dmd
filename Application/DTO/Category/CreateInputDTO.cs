using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO.Category
{
    public class CreateInputDTO
    {
        /// <summary>
        /// Заголовок категории
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Имя файла-изображения
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// Описание категории
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int? Sort { get; set; }

        //[Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int? ParentId { get; set; }
    }
}
