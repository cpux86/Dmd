using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Modeles.Entityes
{
    /// <summary>
    /// Сведения о фотографиях
    /// </summary>
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Пользоательский заголовок
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Описания фотографии или комментарии к ней
        /// </summary>
        public string Description { get; set; }
    }
}
