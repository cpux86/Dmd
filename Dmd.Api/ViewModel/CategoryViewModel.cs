using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Dmd.Api.ViewModel
{
    public class CategoryViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
