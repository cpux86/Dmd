using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Entities.ProductAggregate
{
    public class Property : BaseEntities
    {
        public string Title { get; set; }
        public List<Data> Data { get; set; }
    }
}
