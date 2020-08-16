using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Modeles.Entityes
{
    public class Category
    {
        public int? Id { get; set; }
        
        /// <summary>
        /// Заголовок категории
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Имя файла-изображения
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// Описание категории
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// Идентификатор родительской категории
        /// </summary>
        public int? ParentId { get; set; }
        //public Category Parent { get; set; }
        public List<Category> Children { get; set; }

        public List<Product> Products { get; set; }

        public Category()
        {
            Children = new List<Category>();
            Products = new List<Product>();
        }
    }

}
