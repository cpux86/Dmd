using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dmd.Domain.Core.Entities
{
    public class CategoryTree
    {
        public int Id { get; set; }
        /// <summary>
        /// Идентификатор родительской категории
        /// </summary>
        [ForeignKey("parent")]
        public int Parent { get; set; }
        /// <summary>
        /// Идентификатор категории потомка
        /// </summary>
        [ForeignKey("descendant")]
        public int Descendant { get; set; }
        /// <summary>
        /// Уровень вложения
        /// </summary>
        [ForeignKey("level")]
        public int Level { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
