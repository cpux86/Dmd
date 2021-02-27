using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Entities.ProductAggregate
{
    public class Data : BaseEntities
    {
        // Значение свойства, к примеры для свойства "Процессор" - i7
        public string Title { get; set; }
        public List<Property> Properties { get; set; }
    }
}
