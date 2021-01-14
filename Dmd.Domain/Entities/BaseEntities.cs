using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dmd.Domain.Entities
{
    public abstract class BaseEntities
    {
        public Int64 Id { get; set; }
    }
}
