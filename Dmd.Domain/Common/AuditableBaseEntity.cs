using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Common
{
    public class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        /// <summary>
        /// Дата модификации
        /// </summary>
        public DateTimeOffset DateModified { get; set; }
    }
}
