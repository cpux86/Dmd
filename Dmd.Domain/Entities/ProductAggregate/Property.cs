using Dmd.Domain.ValueObject.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Domain.Entities
{
    public class Property : BaseEntities
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
