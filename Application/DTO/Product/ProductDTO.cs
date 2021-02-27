using Dmd.Domain.Entities;
using Dmd.Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO.Product
{
    public class ProductDTO : BaseDTO
    {
        public string Title { get; set; }
        /// <summary>
        /// Описание товара или услуги
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Принадлежность к категории
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Изображения данного товора или услуги
        /// </summary>
        public List<Photo> Image { get; set; }
        /// <summary>
        /// Характеристики заказа или особенности услуги
        /// </summary>
        public List<Property> Properties { get; set; }
    }
}
