using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Modeles.Entityes
{
    public class Customer : User
    {
        public int Id { get; set; }
        /// <summary>
        /// История заказов, перечень полученных услуг
        /// </summary>
        public List<Order> History { get; set; }
    }
}
