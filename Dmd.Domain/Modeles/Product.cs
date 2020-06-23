using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.DataModeles
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// Описание товара или услуги
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Изображения данного товора или услуги
        /// </summary>
        public List<Photo> Image { get; set; }
        /// <summary>
        /// Характеристики заказа или особенности услуги
        /// </summary>
        public List<Properties> Properties { get; set; }
        /// <summary>
        /// Каталог к которому принадлежить данный товар или услуга
        /// </summary>
        public Catalog Catalog { get; set; }
        /// <summary>
        /// Счетчик ссылок на данный товар или услугу
        /// </summary>
        public int ReferenceCounter { get; set; }
    }
}
