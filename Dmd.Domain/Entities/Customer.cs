using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        /// <summary>
        /// История заказов, перечень полученных услуг
        /// </summary>
        public List<Order> History { get; set; }
    }
}
