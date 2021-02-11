using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Entities
{
    public class Product : BaseEntities
    {
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
        public List<Property> Properties { get; set; }

        public List<Order> Orders { get; set; }

        //public int CatalogId { get; set; }
        /// <summary>
        /// Каталог к которому принадлежить данный товар или услуга
        /// </summary>
        //public Category Catalog { get; set; }

    }
}
