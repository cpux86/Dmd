using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class CreateCategoryResponse
    {
        public int Id { get; set; }
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

        public int? ParentId { get; set; }
    }
}
