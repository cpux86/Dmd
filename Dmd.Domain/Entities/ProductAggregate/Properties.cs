using Dmd.Domain.ValueObject.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Entities
{
    public class Properties : BaseEntities
    {
        public List<PropertyData> propertyDatas { get; set; } 
    }
}
