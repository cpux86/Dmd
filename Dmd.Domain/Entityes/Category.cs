﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Dmd.Domain.Core.Entities
{

    public class Category : BaseEntities
    {
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
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
        /// Дата модификации
        /// </summary>
        public DateTimeOffset DateModified { get; set; }
        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int? Sort { get; set; }
        //public int Level { get; set; }

        //public int Parent { get; set; }
        
        
        public ICollection<Category> Children { get; set; }

        
    }

}
