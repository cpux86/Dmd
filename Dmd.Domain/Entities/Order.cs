using Dmd.Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Entities
{

    public class Order : BaseEntities
    {
        public string Number { get; set; }
        /// <summary>
        /// Содержимое заказа
        /// </summary>
        public List<Product> Products { get; set; }
        /// <summary>
        /// Дата и время создания заказа
        /// </summary>
        public DateTime DateCreate { get; set; }
        /// <summary>
        /// Статус заказа. К примеру: в обработке, в готовоности.
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Покупатель/клиент
        /// </summary>
        public Customer Customer { get; set; }
    }
}
