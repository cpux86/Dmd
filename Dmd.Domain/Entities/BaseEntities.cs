using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dmd.Domain.Entities
{
    public abstract class BaseEntities
    {
        protected BaseEntities()
        {
            Guid = Guid.NewGuid();
        }

        public int Id { get; set; }
        public Guid Guid { get; set; }
        
    }
}
